using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blanket2023Oktobar2
{
    internal class Krug
    {
        protected float r;
        public Krug(float r)
        {
            Console.Out.WriteLine("Krug poluprecnika " +r);
            this.r = r;
        }
        public virtual float Povrsina
        {
            get { return r * r * 3.14f; }
        }
    }
}
