using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach (string a in animation)
        {
            Console.Write(a);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }

    }
}