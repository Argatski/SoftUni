using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char snakeSymbol = '\u25CF';

        private readonly Queue<Point> snakeElments;
        private Food[] food;
        private Wall wall;
        private int nextLeftX;
        private int nextTopY;
        private int foodIndex;

        public int RandomFoodNumer => new Random().Next(0, this.food.Length);

        public Snake(Wall wall)
        {
            this.wall = wall;
            snakeElments = new Queue<Point>();
            this.food = new Food[3];
            this.foodIndex = RandomFoodNumer;
            this.CreateSnake();
            this.GetFoods();
        }

        //TODO.......
        private void CreateSnake()
        {
            for (int topY = 1; topY <= 6; topY++)
            {
                this.snakeElments.Enqueue(new Point(2, topY));
                
            }

        }

        private void GetFoods()
        {
            this.food[0] = new FoodHash(this.wall);
            this.food[1] = new FoodDollar(this.wall);
            this.food[1] = new FoodAsterisk(this.wall);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElments.Last();

            GetNextPoint(direction, currentSnakeHead);

            bool isPointOfSnake = this.snakeElments
                .Any(x => x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);

            if (this.wall.IsPointOfWall(snakeNewHead))
            {
                return false;
            }
            this.snakeElments.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);

            if (food[foodIndex].IsFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElments.Dequeue();
            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = food[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElments.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                GetNextPoint(direction, currentSnakeHead);
            }
            this.foodIndex = this.RandomFoodNumer;
            this.food[foodIndex].SetRandomPosition(this.snakeElments);
        }
    }
}
