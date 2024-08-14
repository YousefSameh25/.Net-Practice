using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class MarketingMaterial : ICloneable
    {
        public string Content { get; set; }
        public string Layout { get; set; }
        public string Color { get; set; }


        public MarketingMaterial(string Content, string layout, string Color)
        {
            this.Content = Content;
            this.Layout = layout;
            this.Color = Color;
        }

        public abstract object Clone();
    }
}
