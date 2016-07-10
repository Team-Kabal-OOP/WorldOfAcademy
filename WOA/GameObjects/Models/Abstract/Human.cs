﻿namespace GameObjects.Models.Abstract
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    using Common;
    using GameObjects.Contracts;

    public abstract class Human : Creature, IHuman
    {

        private int hp;

        public Human(string name, int hp) 
            : base(name)
        {
            this.HP = hp;
            this.IsAlive = true;
        }


        public int HP
        {
            get
            {
                return this.hp;
            }

            protected set
            {
                this.hp = value;
            }
        }

        public  bool IsAlive { get; protected set; }
    }
}
