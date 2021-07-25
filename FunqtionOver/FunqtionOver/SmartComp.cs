using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunqtionOver
{
    class SmartComp : Computer
    {
        public string[] filesInCache;
        public void TurnOff(bool force, bool saveFiles)
        {
            if (force)
            {
                if (AllOpenFiles == null)
                {
                    TurnOff();
                }
                else
                {
                    if (saveFiles)
                    {
                        filesInCache = AllOpenFiles;
                        TurnOff();
                    }
                }
            }
            else
            {
                if (saveFiles)
                {
                    filesInCache = AllOpenFiles;
                    TurnOff();
                }
            }
        }
    }
}
