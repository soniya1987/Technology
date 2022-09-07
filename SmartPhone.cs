using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public double Weight { get; set; }
        public int NumberOfSelfies { get; set; }

        public SmartPhone(double ram, double storage, bool hasKeyboard, double weight) : base(ram, storage, hasKeyboard)
        {
            Weight = weight;
            NumberOfSelfies = 801;
        }

        public bool IsClunky()
        {
            if (Weight > 1.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeSelfie()
        {
            
        }
    }
}
