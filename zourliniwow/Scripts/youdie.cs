using Godot;
using System;

public partial class youdie : Area3D
{
    public PackedScene DeathScreen;

    public CharacterBody3D Player;


    public override void _Ready()
    {
        BodyEntered += _on_area_3d_body_entered;

        DeathScreen = (PackedScene)ResourceLoader.Load("res://Scenes/DeathScreen.tscn");
    }


    private void _on_area_3d_body_entered(Node3D body)
    {
        if (body.Name == "Player")
        {
            GetTree().ChangeSceneToPacked(DeathScreen);
            GD.Print("fb;nkl;sdds");
        }
    }

}
