using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Translator : Player
    {
        private ForeignCenter foreign = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            foreign.Name = name;
        }

        public override void Attack()
        {
            foreign.進攻();
        }

        public override void Defense()
        {
            foreign.防守();
        }
    }
}
