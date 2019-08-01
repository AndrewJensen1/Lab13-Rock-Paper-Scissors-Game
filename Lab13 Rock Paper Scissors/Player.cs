using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_Rock_Paper_Scissors
{
    
    abstract class Player
    {
        private string name;
        private Roshambo roshambo;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Roshambo Roshambo
        {
            get
            {
                return roshambo;
            }
            set
            {
                roshambo = value;
            }
        }

        public abstract Roshambo GenerateRoshambo();
    }
}
