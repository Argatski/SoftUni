using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instance
            Puppy puppy = new Puppy();

            puppy.Eat(); //Inheritance Puppy->Dog->Animla

            puppy.Bark(); // Inheritance Puppy->Dog

            puppy.Weep(); // Methods of puppy
        }
    }
}
