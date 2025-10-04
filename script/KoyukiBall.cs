using Godot;
using System;

public partial class KoyukiBall : Sprite2D
{
	Vector2 velocity = Vector2.Zero;	//移动向量
	[Export] private float strength = 4;	//速度强度
	
	
	public override void _Ready()
	{ 
		Reset();
	}
	public void Reset()
	{
		//biubiubiubiubiu！发射小雪！
		GetNode<AudioStreamPlayer>("Echo2").Play();	//小雪乱叫
		float initAngle = (float)GD.RandRange(0.523 , 1.04); //nihahahaha不管啦竖直上抛就重开吧！
		Vector2 speed = new Vector2(Mathf.Cos(initAngle)*strength, Mathf.Sin(initAngle)*strength);
		velocity = speed;
		this.Position = new Vector2(576, 324);
	}
	
	//积分与命中处理
	public void OnCollision(Area2D collision)
	{
		GetNode<AudioStreamPlayer>("Echo3").Play();		//小雪乱叫
		if (collision == GetNode<Area2D>("/root/Node2D/BatL/L"))
		{
			velocity = new Vector2(-velocity.X, velocity.Y);	//命中反弹
		}
		if (collision == GetNode<Area2D>("/root/Node2D/BatR/R"))
		{
			velocity = new Vector2(-velocity.X, velocity.Y);	//命中反弹
		}

		if (collision == GetNode<Area2D>("/root/Node2D/EdgeL"))
		{
			GetNode<AudioStreamPlayer>("Echo").Play();	//小雪乱叫
			Reset();	//出界复位
			Node2d.Score2 = 1 + Node2d.Score2;	//出界积分
		}
		if (collision == GetNode<Area2D>("/root/Node2D/EdgeR"))
		{
			GetNode<AudioStreamPlayer>("Echo").Play();	//小雪乱叫
			Reset();	//出界复位
			Node2d.Score1 = 1 + Node2d.Score1;	//出界积分
		}
	}
	
	public override void _Process(double delta)
	{
		this.Position = this.Position + velocity;	//移动
		this.Rotation = this.Rotation + (float)delta;	//小雪转圈圈！
		
		//上下边界反弹
		if (this.Position.Y >= 648)
		{
			velocity = new Vector2(velocity.X, -velocity.Y);
		}
		if (this.Position.Y <= 0)
		{
			velocity = new Vector2(velocity.X, -velocity.Y);
		}
		
	}
}
