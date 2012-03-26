using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Factories;
using Nerdsupport.Presentation.ViewModels;

namespace Nerdsupport.Infrastructure.Configuration
{
    public class ShowArendeProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Fraga, ShowFraga>()
                .ForMember(view => view.Avsandare, options => options.MapFrom(domain => domain.Avsandare.Namn))
                .ForMember(view => view.Farg, options => options.Ignore());

            base.Configure();
        }
    }

    
}
