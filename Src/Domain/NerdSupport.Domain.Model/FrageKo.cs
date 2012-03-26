using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdSupport.Domain.Model
{
    public class FrageKo : IAggregateRoot
    {
        private readonly List<Fraga> _frågor;


        public FrageKo(List<Fraga> frågor)
        {
            _frågor = frågor;
        }

        public List<Fraga> Frågor
        {
            get
            {
                return _frågor;
            }

        }

        public Fraga HamtaNastaFraga()
        {
            Frågor.Sort(new PrioritetComparer());
            return Frågor.FirstOrDefault();
        }
    }

    public class PrioritetComparer : IComparer<Fraga>
    {
        public int Compare(Fraga x, Fraga y)
        {
            if (x.Prioritet == y.Prioritet)
            {
                return x.Inskickad.CompareTo(y.Inskickad);
            }

            return y.Prioritet.CompareTo(x.Prioritet);
        }
    }
}
