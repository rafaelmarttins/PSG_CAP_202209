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
        public ProdutoController(ProjetoAcademiaContext context) : base()
        {
            this.servico = new ProdutoServico(context);
        }

        /// <summary>
        /// Lista todos os registros do recurso.
        /// </summary>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<ProdutoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ProdutoPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Pesquisa o registro usando uma chave de Produto.
        /// </summary>
        /// <param name="codigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<ProdutoPoco> GetByID(int codigo)
        {
            try
            {
                ProdutoPoco lista = this.servico.PesquisarPelaChave(codigo);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de Categoria.
        /// </summary>
        /// <param name="catid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public ActionResult<List<ProdutoPoco>> GetByCategoria(int catid)
        {
            try
            {
                List<ProdutoPoco> lista = this.servico.Consultar(sub => sub.CodigoCategoria == catid).ToList();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Pesquisa o registro usando uma chave de SubCategoria.
        /// </summary>
        /// <param name="subid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorSubCategoria/{subid:int}")]
        public ActionResult<List<ProdutoPoco>> GetBySubCategoria(int subid)
        {
            try
            {
                List<ProdutoPoco> lista = this.servico.Consultar(sub => sub.CodigoSubcategoria == subid).ToList();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de Categoria e SubCategoria.
        /// </summary>
        /// <param name="catid"> Chave de pesquisa. </param>
        /// <param name="subid"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorCategoria/{catid:int}/PorSubCategoria/{subid:int}")]
        public ActionResult<List<ProdutoPoco>> GetByCategoriaBySubCategoria(int catid, int subid)
        {
            try
            {
                List<ProdutoPoco> lista = this.servico.Consultar(pro => (pro.CodigoCategoria == catid) && (pro.CodigoSubcategoria == subid)).ToList();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<ProdutoPoco> Post([FromBody] ProdutoPoco poco)
        {
            try
            {
                ProdutoPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente no recurso.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Dados alterado. </returns>
        [HttpPut]
        public ActionResult<ProdutoPoco> Put([FromBody] ProdutoPoco poco)
        {
            try
            {
                ProdutoPoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente no recurso, utilizando um id.
        /// </summary>
        /// <param name="codigo"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{codigo:int}")]
        public ActionResult<ProdutoPoco> DeleteById(int codigo)
        {
            try
            {
                ProdutoPoco delnovo = this.servico.Excluir(codigo);
                return Ok(delnovo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente por instância.
        /// </summary>
        /// <param name="poco"> Dado que será deletado. </param>
        /// <returns> Exclui um dado. </returns>
        [HttpDelete]
        public ActionResult<ProdutoPoco> DeleteByInstancia([FromBody] ProdutoPoco poco)
        {
            try
            {
                ProdutoPoco delnovo = this.servico.Excluir(poco.Codigo);
                return Ok(delnovo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
