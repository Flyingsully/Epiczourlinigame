using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class SaveLoad : Node
{
    private const string SaveLocation = "user://SaveFile.save";

    int HighScore = 0;
    int CurrentScore = 0;

    private void SaveScore()
    {
        using var file = FileAccess.Open(SaveLocation, FileAccess.ModeFlags.WriteRead);
        file.Store32((uint)HighScore);
    }
    private void LoadScore()
    {
        if (FileAccess.FileExists(SaveLocation)) ;
        {
            using var file = FileAccess.Open(SaveLocation, FileAccess.ModeFlags.Read);
            HighScore = (int)file.Get32();
        }

    }
    
}
