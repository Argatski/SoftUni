namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0'; //■
        public Wall(int leftX, int topY) : base(leftX, topY)
        {
            this.InitializeWallBordes();
        }

        private void SetHorizontalLine(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }

        private void SetVerticalLine(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }

        private void InitializeWallBordes()
        {
            SetHorizontalLine(0);
            SetHorizontalLine(this.TopY - 1);

            SetVerticalLine(0);
            SetVerticalLine(this.LeftX - 1);
        }

        public bool IsPointOfWall(Point snake)
        {
            return snake.TopY == 0 || snake.LeftX == 0
                || snake.LeftX == this.LeftX - 1 || snake.TopY == this.TopY;
        }

    }
}
