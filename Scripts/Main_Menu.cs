using Godot;
using System;

public partial class Main_Menu : Control
{
	Button nationButton;
	Button cityButton;
	Button socialButton;
	Button managementButton;
	Button newsButton;

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
	}

	private void cityButtonPressed() {
		GD.Print("City Button Pressed");
	}

	private void socialButtonPressed() {
		GD.Print("Social Button Pressed");
	}

	private void managementButtonPressed() {
		GD.Print("Management Button Pressed");
	}

	private void newsButtonPressed() {
		GD.Print("News Button Pressed");
	}

}
