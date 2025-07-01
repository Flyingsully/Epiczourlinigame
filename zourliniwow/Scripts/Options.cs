using Godot;
using System;
using System.IO;

public partial class Options : Control

{
    private Button exit;

    private PackedScene main_game;

    public override void _Ready()
    {

        main_game = (PackedScene)ResourceLoader.Load("res://Scenes/main_menu.tscn");

        exit = GetNode<Button>("TextureRect/MarginContainer/VBoxContainer/HBoxContainer/Exit");

        exit.Connect("pressed", new Callable(this, nameof(ExitPressed)));
    }

    public void ExitPressed()
    {
        GetTree().ChangeSceneToPacked(main_game);
    }


}

