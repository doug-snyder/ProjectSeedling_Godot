using Godot;
using System;

public partial class Main_Menu : Control
{
	Button nationButton;
	Button cityButton;
	Button socialButton;
	Button managementButton;
	Button newsButton;

	PackedScene nationScreen = GD.Load<PackedScene>("res://Scenes/Screens/Nation_Screen.tscn");
	PackedScene cityScreen = GD.Load<PackedScene>("res://Scenes/Screens/City_Screen.tscn");
	PackedScene socialScreen = GD.Load<PackedScene>("res://Scenes/Screens/Social_Screen.tscn");
	PackedScene managementScreen = GD.Load<PackedScene>("res://Scenes/Screens/Management_Screen.tscn");
	PackedScene newsScreen = GD.Load<PackedScene>("res://Scenes/Screens/News_Screen.tscn");

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
		var nationInstance = nationScreen.Instantiate();
		AddChild(nationInstance);
	}

	private void cityButtonPressed() {
		GD.Print("City Button Pressed");
		var cityInstance = cityScreen.Instantiate();
		AddChild(cityInstance);
	}

	private void socialButtonPressed() {
		GD.Print("Social Button Pressed");
		var socialInstance = socialScreen.Instantiate();
		AddChild(socialInstance);
	}

	private void managementButtonPressed() {
		GD.Print("Management Button Pressed");
		var managementInstance = managementScreen.Instantiate();
		AddChild(managementInstance);
	}

	private void newsButtonPressed() {
		GD.Print("News Button Pressed");
		var newsInstance = newsScreen.Instantiate();
		AddChild(newsInstance);
	}

}
