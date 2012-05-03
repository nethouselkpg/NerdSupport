using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

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
        /// Den person som besvarat frågan.
        /// </summary>
        public Nord Nord
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

        /// <summary>
        /// Svar på frågan
        /// </summary>
        public string Svar { get; set; }

        public int Prioritet { get; set; }

      

        public bool IsBesvarad { get; set; }
    }
}
