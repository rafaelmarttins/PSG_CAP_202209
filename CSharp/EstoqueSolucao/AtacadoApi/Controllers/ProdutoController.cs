using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.DB.EF.Database;
using System;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoServico servico;
        /// <summary>
        /// 
        /// </summary>
        public ProdutoController() : base()
        {
            this.servico = new ProdutoServico();
        }

        /// <summary>
        /// Lista todos os registros do recurso.
        /// </summary>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public List<ProdutoPoco> GetAll()
        {
            return this.servico.Browse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet("{codigo:int}")]
        public ProdutoPoco GetByID(int codigo)
        {
            return this.servico.Read(codigo);
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de Categoria.
        /// </summary>
        /// <param name="catid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<ProdutoPoco> GetByCategoria(int catid)
        {
            return this.servico.Browse(prd => prd.CodigoCategoria == catid).ToList();
        }

        /// <summary>
        ///  Pesquisa o registro usando uma chave de SubCategoria.
        /// </summary>
        /// <param name="subid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorSubCategoria/{subid:int}")]
        public List<ProdutoPoco> GetBySubCategoria(int subid)
        {
            return this.servico.Browse(prd => prd.CodigoSubcategoria == subid).ToList();
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de Categoria e SubCategoria.
        /// </summary>
        /// <param name="catid"> Chave de pesquisa. </param>
        /// <param name="subid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorCategoria/{catid:int}/PorSubCategoria/{subid:int}")]
        public List<ProdutoPoco> GetBySubCategoria(int catid, int subid)
        {
            return this.servico.Browse(prd => (prd.CodigoCategoria == catid) && (prd.CodigoSubcategoria == subid)).ToList();
        }

        /// <summary>
        /// Inclui um novo dado na tabela.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ProdutoPoco Post([FromBody] ProdutoPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Altera um dado existente no recurso.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Dados alterado. </returns>
        [HttpPut]
        public ProdutoPoco Put([FromBody] ProdutoPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Exclui um registro existente no recurso, utilizando um id.
        /// </summary>
        /// <param name="codigo"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{codigo:int}")]
        public ProdutoPoco DeleteById(int codigo)
        {
            return this.servico.Delete(codigo);
        }

        /// <summary>
        /// Exclui um registro existente por instância.
        /// </summary>
        /// <param name="poco"> Dado que será deletado. </param>
        /// <returns> Exclui um dado. </returns>
        [HttpDelete]
        public ProdutoPoco DeleteByInstancia([FromBody] ProdutoPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
