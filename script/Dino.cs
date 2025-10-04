using Godot;
using System;

public partial class Dino : Node2D
{
	[Export] PackedScene input;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("leftUp"))
		{
			Node obstacle = input.Instantiate();
			this.AddChild(obstacle);
		}
	}
}
