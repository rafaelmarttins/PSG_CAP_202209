﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.FrotaAtacado
{
    public abstract class BasePesoCarga : BaseVeiculo
    {
        protected double pesoBruto;

        protected double pesoLiquido;

        protected double pesoTotal;

        public double PesoBruto { get => pesoBruto; set => pesoBruto = value; }
        public double PesoLiquido { get => pesoLiquido; set => pesoLiquido = value; }
        public double PesoTotal { get => pesoTotal; set => pesoTotal = value; }

        public BasePesoCarga() : base()
        { }
    }
}
