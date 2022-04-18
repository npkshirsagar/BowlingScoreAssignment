using BowlingGame;

Console.WriteLine("Welcome to the world of bowling");
Game game = new Game();

Console.WriteLine("Please enter the pins down per frame : ");
for (int i = 0; i <= 9; i++)
{
    int j = 1;
    Console.WriteLine($"Frame {i} :");
    Console.Write($"Roll {j++} : ");
    var v1 = int.Parse(Console.ReadLine());
    game.RollBall(v1);
    Console.WriteLine();
    if (v1 != 10)
    {
        Console.Write($"Roll {j} : ");
        var v2 = int.Parse(Console.ReadLine());
        game.RollBall(v2);
        if (v1 + v2 == 10)
        {
            Console.Write("It's Spare !!");
        }
    }
    else
    {
        Console.Write(" It's Strike !!");
    }
    Console.WriteLine($"Frame score : { game.Score }");
}
Console.ReadLine();
