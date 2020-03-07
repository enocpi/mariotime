using System;

namespace createmario_lab_danabridges
{
    class Program
    { public struct mario
        {
            public enum size {
                small,
                large

            }

            public int numOfLives;
            public string currentLevel;
            public size sizeOfmario;
                public bool canShootFireBalls;
            public bool isJumping;
            public int numOfcoins;


        }
        static void Main(string[] args)

            

        {
            mario mario = new mario();
            mario.numOfLives = 3;
            mario.currentLevel = "world 1-1";
            mario.sizeOfmario = mario.size.large;
            mario.canShootFireBalls = true;
            mario.isJumping = true;
            mario.numOfcoins = 100;
            Console.WriteLine("Hello World!");
        }
    }
}
