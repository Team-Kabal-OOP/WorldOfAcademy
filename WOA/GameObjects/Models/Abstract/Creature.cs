﻿namespace GameObjects.Models.Abstract
{
    using Contracts;
    using Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Creature : ICreature
    {
        private string name;

        public Creature(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                this.name = value;
            }
        }
    }
}
