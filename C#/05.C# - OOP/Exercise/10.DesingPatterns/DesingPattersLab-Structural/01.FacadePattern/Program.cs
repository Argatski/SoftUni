﻿using _01.FacadePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IDrawable picture = new ComplexShape("Picture");

        IDrawable sky = new ComplexShape("Sky");

        IDrawable cloud = new ComplexShape("Cloud");
        cloud.AddChild(new Circle());
        cloud.AddChild(new Circle());
        cloud.AddChild(new Circle());

        IDrawable cloud2 = new ComplexShape("Cloud");
        cloud2.AddChild(new Circle());
        cloud2.AddChild(new Circle());
        cloud2.AddChild(new Circle());

        sky.AddChild(cloud);
        sky.AddChild(cloud2);

        IDrawable ground = new ComplexShape("Ground");
        ground.AddChild(new Circle());

        picture.AddChild(sky);
        picture.AddChild(ground);

        picture.Draw(1);


    }
}