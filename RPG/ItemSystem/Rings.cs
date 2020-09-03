using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Rings : Equipment
    {
        public Rings(string name, int iLevel) : base(name, iLevel)
        {

        }

        public override void Randomize()
        {
            throw new NotImplementedException();
        }
    }
}
