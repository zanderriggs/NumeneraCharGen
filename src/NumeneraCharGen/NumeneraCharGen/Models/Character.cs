using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeneraCharGen.Models
{
    public class Character
    {
        string Name { get; set; }
        Descriptor Descriptor { get; set; }
        Type Type { get; set; }
        Focus Focus { get; set; }
    }
}
