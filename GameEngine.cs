using System;
using System.Drawing;

namespace Life
{
    class GameEngine
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Ticks { get; set; }
        private Color[,] Grid { get; set; }

        public GameEngine(int h, int w)
        {
            if (h <= 0 || w <= 0)
                throw new ArgumentOutOfRangeException("Indices cannot be negative!");

            Height = h;
            Width = w;
            Ticks = 0;
            Grid = new Color[h, w];

            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Width; i++)
                    Grid[j, i] = Color.FromArgb(0, 0, 0, 0);

        }

        public Color this[int y, int x]
        {
            get
            {
                if (IsOutOfBounds(y, x))
                    throw new ArgumentOutOfRangeException("Indices out of bounds!");
                return Grid[y, x];
            }

            set
            {
                if (IsOutOfBounds(y, x))
                    throw new ArgumentOutOfRangeException("Indices out of bounds!");
                Grid[y, x] = value;
            }
        }

        private bool IsOutOfBounds(int y, int x) =>
            (y < 0 || y >= Height || x < 0 || x >= Width);

        private Color[,] CloneBoard()
        {
            Color[,] boardCopy = new Color[Height, Width];

            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Width; i++)
                    boardCopy[j, i] = Grid[j, i];

            return boardCopy;
        }

        public void Tick()
        {
            Color[,] boardCopy = CloneBoard();

            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Width; i++)
                    boardCopy[j, i] = GetNextState(j, i);

            Grid = boardCopy;
            Ticks++;
        }

        private Color GetNextState(int y, int x)
        {
            if (IsOutOfBounds(y, x))
                throw new ArgumentOutOfRangeException("Invalid Coordinates!");

            int alpha = 0;
            int red = 0;
            int green = 0;
            int blue = 0;

            for (int j = y - 1; j <= y + 1; j++)
                for (int i = x - 1; i <= x + 1; i++)
                    if (!IsOutOfBounds(j, i))
                    {
                        alpha = alpha + Grid[j, i].A;
                        red = red + Grid[j, i].R;
                        green = green + Grid[j, i].G;
                        blue = blue + Grid[j, i].B;
                    }
            alpha = alpha - Grid[y, x].A;
            red = red - Grid[y, x].R;
            green = green - Grid[y, x].G;
            blue = blue - Grid[y, x].B;

            switch (alpha)
            {
                case 510:
                    return Grid[y, x];
                case 765:
                    return Color.FromArgb(255, (red / 3), (green / 3), (blue / 3));
                default:
                    return Color.FromArgb(0, 0, 0, 0);
            }
        }
    }
}
