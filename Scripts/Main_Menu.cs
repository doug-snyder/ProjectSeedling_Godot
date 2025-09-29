using Godot;
using System;

public partial class Main_Menu : Control
{

	public override void _Ready()
	{
		GetNode<Button>("Nation_Panel").Text = "Nation Panel Test";
		GetNode<Button>("City_Name").Text = "City Name Test";
		GetNode<Button>("Social_Panel").Text = "Social Panel Test";
		GetNode<Button>("City_Management").Text = "City Management Test";
		GetNode<Button>("News_Panel").Text = "News Panel Test";
	}

}
