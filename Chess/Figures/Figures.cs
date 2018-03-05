using System;
namespace Chess.Figures
{
    public interface Figure
    {
        Position position;

        Color color;

        bool Move();
    }
}

public enum Color {Black, White}
