using Godot;
using System;

public partial class Yuuka : Sprite2D
{
	[Export] public float MoveSpeed = 200.0f;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position -= new Vector2(MoveSpeed * (float)delta, 0);
        
		// 如果移出屏幕左侧，销毁自己
		if (Position.X < 0)
		{
			QueueFree();
		}
	}
}
