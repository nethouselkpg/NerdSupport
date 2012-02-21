using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class Arende
    {
        /// <summary>
        /// Den person som har skickat in ett ärende
        /// </summary>
        public Avsandare Avsandare
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Den person som handlägger ärendet
        /// </summary>
        public Handlaggare Handlaggare
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Automatiskt beräknad prioritet
        /// </summary>
        public PrioriteringsKlassifikation BeraknadPrioritet
        {
            get
            {
                return null;
            }
        }
    }
}
