using Walking.src.Models;

Player player = new Player("p", "q");
Scene scene = new Scene("_", 100);
ConsoleKey key;

scene.Print(player);

do
{
    key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.LeftArrow:
            // Walk to the left
            player.Walk(false, scene.Size);
            scene.Print(player);
            break;

        case ConsoleKey.RightArrow:
            //Walk to the right
            player.Walk(true, scene.Size);
            scene.Print(player);
            break;

        case ConsoleKey.UpArrow:
            // Jump
            player.Jumping = true;
            scene.Print(player);
            player.Jump();
            player.Jumping = false;
            scene.Print(player);
            break;

        default:
            scene.Print(player);
            break;
    }
} while (key != ConsoleKey.Escape);