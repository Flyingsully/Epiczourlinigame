using Godot;
using System;

public partial class DeathScreen : Node2D
{
    private Button Backtomain;

    private PackedScene main_menu;

    public override void _Ready()
    {
        main_menu = (PackedScene)ResourceLoader.Load("res://Scenes/main_menu.tscn");

        Backtomain = GetNode<Button>("CanvasLayer/Button");

        Backtomain.Connect("pressed", new Callable(this, nameof(Backpressed)));
    }

    public void Backpressed()
    {
        GetTree().ChangeSceneToPacked(main_menu);
    }
    
}
