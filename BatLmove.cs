using Godot;
using System;

public partial class BatLmove : Sprite2D
{

	public override void _Ready()
	{
		//小雪初始位置
		this.Position = new Vector2(30, 324);
	}


	public override void _Process(double delta)
	{
		//控制移动
		var moveInput = Input.GetAxis("leftUp", "leftDown");
		var currentY = Mathf.Clamp(this.Position.Y + moveInput*5, 0, 648);	//防止小雪乱跑
		this.Position =  new Vector2(30,currentY);	

	}
}
