using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeneraCharGen.Models
{
    public class Type
    {
        int Id { set; get; }
        string Name { set; get; }
        int Might { set; get; }
        int Speed { set; get; }
        int Intellect { set; get; }
        int MightEdge { set; get; }
        int SpeedEdge { set; get; }
        int IntellectEdge { set; get; }
        int Effort { set; get; }
        // Add these once the other models are created
        //List<> Traits { set; get; }
        //List<> Training { set; get; }
        //List<> Inability { set; get; }
        //List<> Equipment { set; get; }
        int Shins { set; get; }
        string Page { set; get; }
        string Description { set; get; }
    }
}
