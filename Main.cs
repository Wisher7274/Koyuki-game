using Godot;
using System;

public partial class Main : Node
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
	}
}
