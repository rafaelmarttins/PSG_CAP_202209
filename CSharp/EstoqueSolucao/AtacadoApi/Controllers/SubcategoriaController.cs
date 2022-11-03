using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.DB.EF.Database;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public SubcategoriaController() : base()
        {
            this.servico = new SubcategoriaServico();
        }

        /// <summary>
        /// Lista todos os registros do recurso.
        /// </summary>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public List<SubcategoriaPoco> GetAll()
        {
            return this.servico.Browse();
        }

        /// <summary>
        ///  Lista os registro usando a chave.
        /// </summary>
        /// <param name="codigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{codigo:int}")]
        public SubcategoriaPoco GetByID(int codigo)
        {
            return this.servico.Read(codigo);
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave categoria.
        /// </summary>
        /// <param name="catid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<SubcategoriaPoco> GetByCategoria(int catid)
        {
            return this.servico.Browse(sub => sub.CodigoCategoria == catid).ToList();
        }

        /// <summary>
        /// Inclui um novo dado na tabela.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public SubcategoriaPoco Post([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Altera um dado existente no recurso.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Dados alterado. </returns>
        [HttpPut]
        public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Exclui um registro existente no recurso, utilizando um id.
        /// </summary>
        /// <param name="codigo"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{codigo:int}")]
        public SubcategoriaPoco DeleteById(int codigo)
        {
            return this.servico.Delete(codigo);
        }

        /// <summary>
        /// Exclui um registro existente por instância.
        /// </summary>
        /// <param name="poco"> Dado que será deletado. </param>
        /// <returns> Exclui um dado. </returns>
        [HttpDelete]
        public SubcategoriaPoco DeleteByInstancia([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
