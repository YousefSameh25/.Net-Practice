using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Post : MarketingMaterial
    {
        public Post(string Content, string layout, string Color) : base(Content, layout, Color)
        {
        }

        public override object Clone()
        {
            return new Post(this.Content, this.Layout, this.Color);
        }
    }
}
