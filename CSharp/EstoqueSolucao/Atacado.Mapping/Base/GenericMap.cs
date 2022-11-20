﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapping.Base
{
    public class GenericMap<TDominio, TPoco>
        where TDominio : class
        where TPoco : class
    {
        public IMapper Mapping { get; }

        public GenericMap()
        {
            MapperConfiguration? configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TDominio, TPoco>();
                cfg.CreateMap<TPoco, TDominio>();
            });

            this.Mapping = configuration.CreateMapper();
        }
    }
}
