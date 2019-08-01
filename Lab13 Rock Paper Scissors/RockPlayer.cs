using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Rock_Paper_Scissors
{
    class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
