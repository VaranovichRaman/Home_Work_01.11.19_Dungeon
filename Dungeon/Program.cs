using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map = new string [100,100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                        map[i, j] = " ";                    
                }
            }
            CreateRoom(3,3,5, 9, map);
            CreateRoom(2,8,7, 10, map);
            CreateRoom(5,14, 7, 12, map);
            CreateHero(3, 3, map);
            CreateDoor(5, 8, map);
            CreateMonster(5, 5, map);
        }
        public static void CreateRoom(int baseX, int baseY, int x, int y, string [,] map)
        {
            for (int i = baseX; i < baseX + x; i++)
            {
                for (int j = baseY; j < baseY + y; j++)
                {
                    if (i == baseX || i == (baseX + x) -1 || j == baseY || j == (baseY + y) - 1)
                    {
                        map[i, j] = "0";
                    }
                    else
                    {
                        map[i, j] = " ";
                    }
                }
            }
        }
        public static void CreateDoor(int x, int y, string[,] map)
        {
            map[x, y] = "D";
        }
        public static void CreateMonster(int x, int y, string[,] map)
        {
            map[x, y] = "M";
        }
        public static void CreateHero(int x, int y, string[,] map)
        {
            map[x+1, y+1] = "H";
        }
        public static void ShowMap(string[,] map)
        {
            for (int i = 0; i < 35; i++)
            {
                for (int j = 0; j < 35; j++)
                {
                    if (j < 34)
                    {
                        Console.Write(map[i, j]);
                    }
                    else
                    {
                        Console.WriteLine(map[i, j]);
                    }

                }
            }
        }
    }
}
