using Godot;
using System;

public partial class Obstacle : Node2D
{
	[Export] int speed = 20;	//移速
	private Sprite2D yuuka;
	public override void _Ready()
	{
		yuuka = GetNode<Sprite2D>("Yuuka");
	}

	public override void _Process(double delta)
	{
		yuuka.Position = new Vector2(yuuka.Position.X -speed, yuuka.Position.Y);	//移动
		if (yuuka.Position.X < 0)
		{
			this.QueueFree();	//出界销毁
		}
	}

	public void Freeze()
	{
		speed = 0;
	}
	

	public void Remove(Node body)
	{
		this.QueueFree();
	}
}
