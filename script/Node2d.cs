using Godot;
using System;

public partial class Node2d : Node2D
{
	public static int Score1 { get; set; } = 0;
	public static int Score2 { get; set; } = 0;

	public override void _Ready()
	{
		
	}
	
	public override void _Process(double delta)
	{
		GetNode<Label>("/root/Node2D/Score1").Text = Score1.ToString();
		GetNode<Label>("/root/Node2D/Score2").Text = Score2.ToString();
		//分数显示

		GetNode<AudioStreamPlayer>("BGM").StreamPaused = !GetNode<CheckButton>("BGMSwitch").ButtonPressed;
		//声音开关
	}

	public void exit()
	{
		SceneTree st = this.GetTree();
		st.ChangeSceneToFile("res://scenes/main_menu.tscn");
	}

	public override void _ExitTree()
	{
		Score1 = 0;
		Score2 = 0;
	}
}
