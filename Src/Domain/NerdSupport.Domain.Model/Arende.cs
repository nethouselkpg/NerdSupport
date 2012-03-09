using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Shared;

namespace NerdSupport.Domain.Model
{
    public class Arende : IAggregateRoot
    {
        public long Id { get; set; }

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
        /// Datum då ärendet registrerades
        /// </summary>
        public DateTime Ankommet { get; set; }

        /// <summary>
        /// Automatiskt beräknad prioritet
        /// </summary>
        public PrioriteringsKlassifikation BeraknaPrioritet()
        {
            var serviceAvtal = Avsandare.ServiceAvtal;

            return serviceAvtal.KontrolleraAvtalsRegler(this);
        }

        /// <summary>
        /// Anger om ärendet är inskickat av en VIP
        /// </summary>
        /// <returns>True om ärendet är VIP</returns>
        public bool IsVipArende()
        {
            return Avsandare.IsVip;
        }


    }
}
