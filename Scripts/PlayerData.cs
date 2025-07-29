using Godot;
using System;

public partial class PlayerData : ConfigFile
{
	static void CreatePlayerData()
	{
		this.SetValue("Player", "PlayerName", "Rock Person");
		this.SetValue("Nation", "NationName", "Planet Rock");
		this.SetValue("Nation", "NationRulerName", "Ruler of Planet Rock");
		this.SetValue("Nation", "NationPower", 9001);

		this.Save("user://PlayerData.cfg");
	}

	// Accept a Dictionary or return a Dictionary?
	static void LoadPlayerData()
	{
		Error loadPlayerDataError = this.Load("user://PlayerData.cfg");
		if (loadPlayerDataError != Error.Ok) { return; }

		foreach (String section in this.GetSections())
		{
			// Change this to use fetched section headers or similar
			var playerName = (String)this.GetValue(section, "PlayerName");
			var nationName = (String)this.GetValue(section, "NationName");
			var nationRulerName = (String)this.GetValue(section, "NationRulerName");
			var nationPower = (int)this.GetValue(section, "NationPower");
		}
	}

	static void SavePlayerData()
	{
		this.Save("user://PlayerData.cfg");
	}
}
