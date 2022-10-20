namespace Walking.src.Models;

public class Player
{
    public byte Position { get; set; }
    public string Aparance { get; set; }
    public string FacingRight { get; set; }
    public string FacingLeft { get; set; }
    public bool Jumping { get; set; }

    public Player(string right, string left)
    {
        Position = 0;
        FacingRight = right;
        FacingLeft = left;
        Aparance = FacingRight;
        Jumping = false;
    }

    public void Jump()
    {
        Console.Beep(234, 100);
    }

    public void Walk(bool direction, byte limit)
    {
        if (direction)
        {
            if (Position < limit)
            {
                Position++;
                Aparance = FacingRight;
            }
        }
        else
        {
            if (Position > 0)
            {
                Position--;
                Aparance = FacingLeft;
            }
        }
    }
}