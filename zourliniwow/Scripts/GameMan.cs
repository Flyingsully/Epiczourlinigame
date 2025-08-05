//using Godot;
//using System;
//using System.IO;
//
//public partial class Gameman : Node
//{
//    private double _startTime;
//    private double _endTime;
//
//    private string SaveLocation;
//
//    public override void _Ready()
//    {
//        SaveLocation = ProjectSettings.GlobalizePath("user://session_log.txt");
//    }
//
//    public void startedwhen()
//    {
//        startedwhen = Time.GetUnixTimeFromSystem();
//        GD.Print("Game started at: " + _startTime);
//    }
//
//    public void endedwhen()
//    {
//        endedwhen = Time.GetUnixTimeFromSystem();
//        double duration = _endTime - _startTime;
//
//        GD.Print("Game won at: " + _endTime);
//        GD.Print("Total duration: " + duration + " seconds");
//
//        SaveSessionToFile(_startTime, _endTime, duration);
//    }
//
//    private void SaveSessionToFile(double start, double end, double duration)
//    {
//        string logEntry = $"Session Start: {UnixTimeToString(start)} | End: {UnixTimeToString(end)} | Duration: {duration} seconds\n";
//
//        try
//        {
//            File.AppendAllText(_logFilePath, logEntry);
//            GD.Print("Session logged to file.");
//        }
//        catch (Exception ex)
//        {
//            GD.PrintErr("Failed to write session log: ", ex.Message);
//        }
//    }
//
//    private string UnixTimeToString(double unixTime)
//    {
//        DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeSeconds((long)unixTime);
//        return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
//    }
//}
//