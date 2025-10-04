using Godot;
using System;

public partial class Koyuki : RigidBody2D
{
	public override void _Ready()
	{
		this.LockRotation = true;	//防止小雪滚动
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		if (Input.IsActionJustPressed("space"))
		{
			this.LinearVelocity = new Vector2(this.LinearVelocity.X, -500);
		}
	}
}
