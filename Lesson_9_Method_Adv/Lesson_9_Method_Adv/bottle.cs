using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Method_Adv
{
    class bottle
    {
        public string matirial;
        public bool isRecycled;

        public bottle(string matirial)
        {
            this.matirial = matirial;
        }

        public void Recycled(ref int howManyRecycled,ref int maxRecycled)
        {
            if (this.matirial == "plastic" || this.matirial == "glass")
            {
                if (howManyRecycled < maxRecycled)
                {
                    howManyRecycled++;
                    if (howManyRecycled == maxRecycled)
                    {
                        isRecycled = true;
                    }
                }
            }
            
        }

    }
}
