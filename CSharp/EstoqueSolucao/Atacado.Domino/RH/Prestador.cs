﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Domino.RH
{
    public class Prestador : BaseJuridica
    {
        private DateOnly dataContratoInicial;

        private DateOnly dataContratoFinal;
        public DateOnly DataContratoInicial { get => dataContratoInicial; set => dataContratoInicial = value; }
        public DateOnly DataContratoFinal { get => dataContratoFinal; set => dataContratoFinal = value; }

        public Prestador()
        { }

        public Prestador(int id, string nome, string nomeFantasia, string razaoSocial, string cpnj, string inscricaoEstadual, DateTime fundacao, string emailCorporativo, DateOnly dataContratoInicial, DateOnly dataContratoFinal) 
            : base(id, nome, nomeFantasia, razaoSocial, cpnj, inscricaoEstadual, fundacao, emailCorporativo)
        {
            this.dataContratoInicial = dataContratoInicial;
            this.dataContratoFinal = dataContratoFinal;
        }
    }
}
