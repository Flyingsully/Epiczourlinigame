using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class Main_Menu : Node

{
	//public AudioStreamPlayer horse;
	private Button start;
	private Button exit;
	private Button options;
	private PackedScene Main_game;
	private PackedScene Main_menu;
	private PackedScene Options_menu;
	 



	public override void _Ready()
	{
		//BUTTONS AREA AND WHAT THEY DO 

		start = GetNode<Button>("Camera3D/CanvasLayer/Control/TextureRect/MarginContainer/HBoxContainer/VBoxContainer/Start");

		options = GetNode<Button>("Camera3D/CanvasLayer/Control/TextureRect/MarginContainer/HBoxContainer/VBoxContainer/Options");

		exit = GetNode<Button>("Camera3D/CanvasLayer/Control/TextureRect/MarginContainer/HBoxContainer/VBoxContainer/Exit");

		Main_menu = (PackedScene)ResourceLoader.Load("res://Scenes/main_menu.tscn");

		Main_game = (PackedScene)ResourceLoader.Load("res://Scenes/main_game.tscn");

		Options_menu = (PackedScene)ResourceLoader.Load("res://Scenes/options.tscn");

		start.Connect("pressed", new Callable(this, nameof(Babaisstartpressed)));

		options.Connect("pressed", new Callable(this, nameof(Babaisoptionspressed)));

		exit.Connect("pressed", new Callable(this, nameof(Babaisexitpressed)));

		//AUDIO AREA

		//horse = GetNode<AudioStreamPlayer>("HorseBreakingEverything");

		// Load the audio file into the AudioStreamPlayer
		//AudioStream audioStream = (AudioStream)ResourceLoader.Load("res://Sounds/HORSE BREAKING EVERYTHING.mp3");

		// Assign the audio stream to the player
		//horse.Stream = audioStream;


		// Play the audio
		//horse.Play();

	}

		//WHERE THE BUTTONS LEAD YOU TO WHEN THEY ARE PRESSED 

	public void Babaisstartpressed()
	{
		GetTree().ChangeSceneToPacked(Main_game);
	}

	public void Babaisoptionspressed()
	{
		GetTree().ChangeSceneToPacked(Options_menu);
	}

	public void Babaisexitpressed()
	{
		GetTree().Quit();
	}




	}
