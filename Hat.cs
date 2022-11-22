using System;
using System.Collections.Generic;
namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription { get; set; }

        public Hat(int level)
        {
            ShininessLevel = level;
            if (ShininessLevel <= 2)
            {
                ShininessDescription = "dull";
            }
            else if (ShininessLevel > 2 && ShininessLevel <= 5)
            {
                ShininessDescription = "noticeable";
            }
            else if (ShininessLevel > 5 && ShininessLevel <= 9)
            {
                ShininessDescription = "bright";
            }
            else if (ShininessLevel > 9)
            {
                ShininessDescription = "blinding";
            }

        }


    }
}