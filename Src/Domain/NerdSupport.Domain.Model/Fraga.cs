using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    [Serializable]
    public class Fraga : IAggregateRoot
    {
        public long Id { get; set; }

        /// <summary>
        /// Den person som har skickat in ett ärende
        /// </summary>
        public Avsandar Avsandare { get; set; }

        /// <summary>
        /// Den person som handlägger ärendet
        /// </summary>
        public Nord Handlaggare
        {
            get;
            set;
        }

        /// <summary>
        /// Datum då ärendet registrerades
        /// </summary>
        public DateTime Inskickad { get; set; }

        /// <summary>
        /// Fråga på problem
        /// </summary>
        public string Fråga { get; set; }

        public int Prioritet { get; set; }

    }
}
