﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    public abstract class Creator
    {
        private int _creativityLevel = 100;
        private int _energy = 100;
        

        public int CreativityLevel
        {
            get {
                return _creativityLevel;
            
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _creativityLevel = value;
                }
                else
                {
                    throw new Exception("Creativity level can only be a value between 0 and 100");
                }
            }
                
                
               
        }

    }
}
