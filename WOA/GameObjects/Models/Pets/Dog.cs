﻿namespace GameObjects.Models.Pets
{
    using Contracts;
    using Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Pet, IPet
    {
        private const int KnowledgeBoost = -10;

        public Dog(string name) : base(name)
        {
        }

        public override string HelpMe(IKnowledge knowledge)
        {
            knowledge.AddKnowledge(KnowledgeBoost);
            return $"{this.ToString()} needs to go for a walk!!! The student time to study has been decreased! You receive {Dog.KnowledgeBoost} knowledge!!";
        }
    }
}
