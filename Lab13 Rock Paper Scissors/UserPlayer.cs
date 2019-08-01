using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Rock_Paper_Scissors
{
    class UserPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        return Roshambo.Rock;
                    }
                case 2:
                    {
                        return Roshambo.Paper;
                    }
                case 3:
                    {
                        return Roshambo.Scissors;
                    }
                default:
                    Console.WriteLine("You dun messed up Son!");
                    return GenerateRoshambo();
                   

            }
        }
    }
}
