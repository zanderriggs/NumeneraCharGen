using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeneraCharGen.Models
{
    public class Focus
    {
        int Id { set; get; }
        string Name { set; get; }
        int Might { set; get; }
        int Speed { set; get; }
        int Intellect { set; get; }

        // Add these once the other models are created
        //List<> Powers { set; get; }
        //List<> Abilities { set; get; }
        //List<> Equipment { set; get; }
        string Page { set; get; }
        string Description { set; get; }
    }
}
