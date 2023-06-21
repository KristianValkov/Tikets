using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Model
{
    internal class Line
    {
        //...
        public ICollection<Line> Lines { get; set; }
    }
}
