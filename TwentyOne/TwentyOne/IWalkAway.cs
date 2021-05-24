using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // A player always has the right to walk away with his chips at any point!
    interface IWalkAway
    {
        void WalkAway(Player Player);
    }
}
