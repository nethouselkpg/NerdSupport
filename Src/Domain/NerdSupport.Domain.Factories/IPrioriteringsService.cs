using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Model;

namespace NerdSupport.Domain.Services
{
    public interface IPrioriteringsService
    {
        int Prioritera(Fraga fraga);
    }
}
