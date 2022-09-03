using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Elf("Elf", 15);

            Console.WriteLine(hero);

            hero = new MuseElf("Pesho", 0);

            Console.WriteLine(hero);

            hero = new Knight("Gosho", 25);

            Console.WriteLine(hero);

            hero = new DarkKnight("Tosho", -5);

            Console.WriteLine(hero);

            hero = new BladeKnight("Shosho", 25);

            Console.WriteLine(hero);

        }
    }
}
