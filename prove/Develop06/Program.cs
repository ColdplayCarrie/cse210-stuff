//Added ShowCountdown to GoalManager and used it in DisplayPlayerInfo as well as using Thread.Sleep in DisplayPlayerInfo
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}