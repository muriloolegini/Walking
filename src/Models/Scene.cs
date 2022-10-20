namespace Walking.src.Models;

public class Scene
{
    public string Ground { get; set; }
    public byte Size { get; set; }
    
    public Scene(string ground, byte size)
    {
        this.Ground = ground;
        this.Size = size;

    }

    public void Print(Player player)
    {
        Console.Clear();
        Console.WriteLine();

        // Prints the first line
        if (player.Jumping)
        {
            for (byte i = 0; i < player.Position; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(player.Aparance);
        }
        else
        {
            Console.WriteLine();
        }

        // Prints the second line
        for (byte i = 0; i < player.Position; i++)
        {
            Console.Write(Ground);
        }

        if (player.Jumping)
        {
            Console.Write(Ground);
        }
        else
        {
            Console.Write(player.Aparance);
        }

        for (byte i = 0; i < (Size - player.Position); i++)
        {
            Console.Write(Ground);
        }
    }
}