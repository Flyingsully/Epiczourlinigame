using Godot;
using System;

public partial class ScoreManager : Node
{
    private const string SaveLocation = "user://SaveFile.save";

    private int highestScore = 0;
    private int currentScore = 0;

    public override void _Ready()
    {
        LoadScore();
    }

    private void SaveScore()
    {
        using var file = FileAccess.Open(SaveLocation, FileAccess.ModeFlags.WriteRead);
        file.Store32((uint)highestScore);
    }

    private void LoadScore()
    {
        if (FileAccess.FileExists(SaveLocation))
        {
            using var file = FileAccess.Open(SaveLocation, FileAccess.ModeFlags.Read);
            highestScore = (int)file.Get32();
        }
    }
}
