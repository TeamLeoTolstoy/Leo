﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Tower : GameObject
    {
        private int damage;

        public override char Sign
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override Color Color
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override char[] ElementSize
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Damage
        {
            get { return.this.damage;}
            set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
