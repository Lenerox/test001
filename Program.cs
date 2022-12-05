//pozdro dla Karola
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Console.WriteLine("Witaj Karolu");
        var x = "tekst";
        x = Console.ReadLine();
        Console.WriteLine(x);
    }

    private string GetDebuggerDisplay() => ToString();
}