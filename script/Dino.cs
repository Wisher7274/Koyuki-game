using Godot;
using System;

public partial class Dino : Node2D
{
	[Export] PackedScene input;
	[Export] public float MinSpawnTime = 1.0f;
	[Export] public float MaxSpawnTime = 3.0f;
	private int score = 0;
	private bool spwaning = true;
	private RandomNumberGenerator rng = new RandomNumberGenerator();

	public override void _Ready()
	{
		rng.Randomize();
		StartNextSpawn();
	}
	private async void StartNextSpawn()
	{
		while (IsInsideTree())
		{
			// 等待随机时间
			float randomDelay = rng.RandfRange(MinSpawnTime, MaxSpawnTime);
			await ToSignal(GetTree().CreateTimer(randomDelay), "timeout");
            
			// 生成障碍
			if (spwaning){ObstacleSpawn();}
		}
	}

	private void ObstacleSpawn()	//生成高速移动的百吨王
	{
		Node obstacle = input.Instantiate();
		this.AddChild(obstacle);
	}

	//被百吨王创飞后的处理逻辑
	public void Crashed(Area2D body)	
	{
		GetNode<RigidBody2D>("Koyuki").SetDeferred("freeze",true);	//焊死小雪
		GetNode<Obstacle>("Obstacle").Freeze();		//焊死优香
		spwaning = false;	//停止生成
		
		GetNode<AudioStreamPlayer>("BGM").StreamPaused = true;		//暂停BGM
		GetNode<AudioStreamPlayer>("Koyuki/Lost").Play();		//小雪鬼叫
		GetTree().CurrentScene.AddChild(GD.Load<PackedScene>("res://scenes/dino_game_over.tscn").Instantiate());	//显示gameover
		//偶遇一行神人拼尽全力无法战胜
	}
	//计分
	public void Count(Area2D body)
	{
		score++;
		GetNode<Label>("Score").Text = score.ToString();
	}
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("space") && spwaning)	//不让小雪二段跳
		{
			GetNode<AudioStreamPlayer>("Koyuki/Jump").Play();
		}
		if(spwaning){GetNode<AudioStreamPlayer>("BGM").StreamPaused = !GetNode<CheckButton>("BGMSwitch").ButtonPressed;}	//依旧长难句
	}
	
}
