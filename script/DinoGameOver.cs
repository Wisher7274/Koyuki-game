using Godot;
using System;

public partial class DinoGameOver : Control
{
	public override void _Ready()
	{
	}
	public override void _Process(double delta)
	{
	}

	private void OnRestartPressed()
	{
		GetTree().ReloadCurrentScene();
		this.QueueFree();
	}

	private void OnExitPressed()
	{
		GetTree().ChangeSceneToPacked(GD.Load<PackedScene>("res://scenes/main_menu.tscn"));	//返回主界面
		//依旧一行神人
	}
}
