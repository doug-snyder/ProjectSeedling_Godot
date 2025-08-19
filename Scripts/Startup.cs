using Godot;
using System;

public partial class Startup : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Load initial scene (loading screen, login screen, or Main_Menu?)
		var scene = GD.Load<PackedScene>("res://Main_Menu.tscn");
		var instance = scene.Instantiate();
		AddChild(instance);

		// Load player-specific data

		return;
	}

}
