﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.Dominio.FrotaAtacado;
using Atacado.Poco.FrotaAtacado;
using Atacado.Repositorio.FrotaAtacado;
using System.Runtime.ConstrainedExecution;

namespace Atacado.Servico.FrotaAtacado
{
    public class CarroServico : BaseServico<CarroPoco, Carro>
    {
        private CarroRepo repo;

        public CarroServico() : base()
        {
            this.repo = new CarroRepo();
        }

        public override CarroPoco Add(CarroPoco poco)
        {
            Carro nova = this.ConvertTo(poco);
            Carro criada = this.repo.Create(nova);
            CarroPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }
        public override List<CarroPoco> Browse()
        {
            List<CarroPoco> listaPoco = this.repo.Read()
                .Select(car =>
                    new CarroPoco()
                    {
                        Codigo = car.Codigo,
                        Ativo = car.Ativo,
                        DataInclusao = car.DataInclusao,
                        Chassi = car.Chassi,
                        Cor = car.Cor,
                        Marca = car.Marca,
                        Modelo = car.Modelo,
                        Placa = car.Placa,
                        PesoBruto = car.PesoBruto,
                        PesoLiquido = car.PesoLiquido,
                        PesoTotal = car.PesoTotal,
                        NumPassageiros = car.NumPassageiros,
                    }
                 )
                .ToList();
            return listaPoco;
        }
        public override CarroPoco ConvertTo(Carro dominio)
        {
            return new CarroPoco()
            {
                Codigo = dominio.Codigo,
                Ativo = dominio.Ativo,
                DataInclusao = dominio.DataInclusao,
                Chassi = dominio.Chassi,
                Cor = dominio.Cor,
                Marca = dominio.Marca,
                Modelo = dominio.Modelo,
                Placa = dominio.Placa,
                PesoBruto = dominio.PesoBruto,
                PesoLiquido = dominio.PesoLiquido,
                PesoTotal = dominio.PesoTotal,
                NumPassageiros = dominio.NumPassageiros,
            };
        }
        public override Carro ConvertTo(CarroPoco poco)
        {
            return new Carro(poco.Codigo, poco.Ativo, poco.DataInclusao, poco.Chassi, poco.Cor, poco.Marca,
                poco.Modelo, poco.Placa, poco.PesoBruto, poco.PesoLiquido, poco.PesoTotal, poco.NumPassageiros);
        }

        public override CarroPoco Delete(int chave)
        {
            Carro del = this.repo.Delete(chave);
            CarroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CarroPoco Delete(CarroPoco poco)
        {
            Carro del = this.repo.Delete(ConvertTo(poco));
            CarroPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CarroPoco Edit(CarroPoco poco)
        {
            Carro editada = this.ConvertTo(poco);
            Carro alterada = this.repo.Update(editada);
            CarroPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override CarroPoco Read(int chave)
        {
            Carro lida = this.repo.Read(chave);
            CarroPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
