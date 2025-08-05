using Godot;
using System;

public partial class Youwin : Area3D
{
    public PackedScene Winscreen;

    public CharacterBody3D Player;


    public override void _Ready()
    {
        BodyEntered += _on_area_3d_body_entered;

        Winscreen = (PackedScene)ResourceLoader.Load("res://Scenes/Winscreen.tscn");
    }


    private void _on_area_3d_body_entered(Node3D body)
    {
        if (body.Name == "Player")
        {
            GetTree().ChangeSceneToPacked(Winscreen);
            GD.Print("fb;nkl;sdds");
        }
    }

}

