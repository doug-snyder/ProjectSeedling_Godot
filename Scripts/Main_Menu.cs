using Godot;
using System;

public partial class Main_Menu : Control
{

	public override void _Ready()
	{
		GetNode<Button>("City_Name").Text = "Test";
	}

}
