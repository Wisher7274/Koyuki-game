using Godot;
using System;

public partial class Koyuki : RigidBody2D
{
	[Export] int strength = 800;
	private bool isOnGround;
	public override void _Ready()
	{
		this.LockRotation = true;	//防止小雪滚动
	}
	public override void _Process(double delta)
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		if (Input.IsActionJustPressed("space") && isOnGround)	//不让小雪二段跳
		{
			this.LinearVelocity = new Vector2(this.LinearVelocity.X, -strength);
		}
	}
	
	//小雪状态判定
	public void OnGround(Node body)
	{
		isOnGround = true;
	}
	public void InAir(Node body)
	{
		isOnGround = false;
	}
}
