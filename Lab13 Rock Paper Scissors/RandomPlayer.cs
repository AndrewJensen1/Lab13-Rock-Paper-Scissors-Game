using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Rock_Paper_Scissors
{
    class RandomPlayer : Player
    {
        Random random = new Random();
        public override Roshambo GenerateRoshambo()
        {
            int r = random.Next(1, 4);
            Enum.TryParse(Enum.GetName(typeof(Roshambo), r), out Roshambo result);
            return result;
        }
    }
}
