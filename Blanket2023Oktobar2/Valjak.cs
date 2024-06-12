using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blanket2023Oktobar2
{
    internal class Valjak : Krug
    {
        float h;
        public Valjak(float r, float h)
            :base(r)
        {
            Console.Out.WriteLine("Valjak poluprecnika onsove " + r + " i visine " + h);
            this.h = h;
        }
        public float Povrsina
        {
            get
            {
                { return 2 * 3.14f * r * (r + h); }
            }
        }
        public float Zapremina
        {

        }
    }
}
