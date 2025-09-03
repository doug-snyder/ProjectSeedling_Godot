using Godot;
using System;

public partial class PlayerData : Node
{
	static ConfigFile config = new ConfigFile();

	static void CreatePlayerData()
	{
		config.SetValue("Player", "PlayerName", "Boulder Daddy");
		config.SetValue("Nation", "NationName", "Planet Rock");
		config.SetValue("Nation", "NationRulerName", "Jade");
		config.SetValue("Nation", "NationPower", 9001);

		config.Save("user://PlayerData.cfg");
	}

	// Accept a Dictionary or return a Dictionary?
	static void LoadPlayerData()
	{
		Error loadPlayerDataError = config.Load("user://PlayerData.cfg");
		if (loadPlayerDataError != Error.Ok) { return; }

		foreach (String section in config.GetSections())
		{
			// Change this to use fetched section headers or similar
			var playerName = (String)config.GetValue(section, "PlayerName");
			var nationName = (String)config.GetValue(section, "NationName");
			var nationRulerName = (String)config.GetValue(section, "NationRulerName");
			var nationPower = (int)config.GetValue(section, "NationPower");
		}
	}

	static void SavePlayerData()
	{
		config.Save("user://PlayerData.cfg");
	}
}
