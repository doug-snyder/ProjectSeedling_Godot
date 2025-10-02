using Godot;
using System;

public partial class Main_Menu : Control
{
	Button nationButton;
	Button cityButton;
	Button socialButton;
	Button managementButton;
	Button newsButton;

	PackedScene nationScene = GD.Load<PackedScene>("res://Scenes/Nation_Scene.tscn");
	PackedScene cityScene = GD.Load<PackedScene>("res://Scenes/City_Scene.tscn");
	PackedScene socialScene = GD.Load<PackedScene>("res://Scenes/Social_Scene.tscn");
	PackedScene managementScene = GD.Load<PackedScene>("res://Scenes/Management_Scene.tscn");
	PackedScene newsScene = GD.Load<PackedScene>("res://Scenes/News_Scene.tscn");

	public override void _Ready()
	{
		nationButton = GetNode<Button>("Nation_Panel");
		nationButton.Text = "Nation Panel Test";
		nationButton.Pressed += nationButtonPressed;

		cityButton = GetNode<Button>("City_Name");
		cityButton.Text = "City Name Test";
		cityButton.Pressed += cityButtonPressed;

		socialButton = GetNode<Button>("Social_Panel");
		socialButton.Text = "Social Panel Test";
		socialButton.Pressed += socialButtonPressed;

		managementButton = GetNode<Button>("City_Management");
		managementButton.Text = "City Management Test";
		managementButton.Pressed += managementButtonPressed;

		newsButton = GetNode<Button>("News_Panel");
		newsButton.Text = "News Panel Test";
		newsButton.Pressed += newsButtonPressed;
	}

	private void nationButtonPressed() {
		GD.Print("Nation Button Pressed");
		var nationInstance = nationScene.Instantiate();
		AddChild(nationInstance);
	}

	private void cityButtonPressed() {
		GD.Print("City Button Pressed");
		var cityInstance = cityScene.Instantiate();
		AddChild(cityInstance);
	}

	private void socialButtonPressed() {
		GD.Print("Social Button Pressed");
		var socialInstance = socialScene.Instantiate();
		AddChild(socialInstance);
	}

	private void managementButtonPressed() {
		GD.Print("Management Button Pressed");
		var managementInstance = managementScene.Instantiate();
		AddChild(managementInstance);
	}

	private void newsButtonPressed() {
		GD.Print("News Button Pressed");
		var newsInstance = newsScene.Instantiate();
		AddChild(newsInstance);
	}

}
