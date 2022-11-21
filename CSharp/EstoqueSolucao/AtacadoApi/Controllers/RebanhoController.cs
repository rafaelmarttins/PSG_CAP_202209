using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atacado.Poco.Pecuaria;
using Atacado.Servico.Pecuaria;
using Atacado.Poco.Estoque;
using Atacado.DB.EF.Database;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/pecuaria/[controller]")]
    [ApiController]
    public class RebanhoController : ControllerBase
    {
        private RebanhoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public RebanhoController(ProjetoAcademiaContext context) : base()
        {
            this.servico = new RebanhoServico(context);
        }

        /// <summary>
        /// Lista todos os registros do recurso.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<RebanhoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<RebanhoPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de Rebanho.
        /// </summary>
        /// <param name="codigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<RebanhoPoco> GetByID(int codigo)
        {
            try
            {
                RebanhoPoco lista = this.servico.PesquisarPelaChave(codigo);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista todos os registros de Rebanho por Municipio.
        /// </summary>
        /// <param name="muncodigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorMunicipio/{muncodigo:int}")]
        public ActionResult<List<RebanhoPoco>> GetPorMunicipio(int muncodigo)
        {
            try
            {
                List<RebanhoPoco> lista = this.servico.Consultar(mun => mun.CodigoMunicipio == muncodigo).ToList();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Rebanho por Tipo Rebanho.
        /// </summary>
        /// <param name="tipcodigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorTipoRebanho/{tipcodigo:int}")]
        public ActionResult<List<RebanhoPoco>> GetPorTipoRebanho(int tipcodigo)
        {
            try
            {
                List<RebanhoPoco> lista = this.servico.Consultar(tip => tip.CodigoTipoRebanho == tipcodigo).ToList();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de Tipo Rebanho e Municipio.
        /// </summary>
        /// <param name="tipcodigo"> Chave de pesquisa. </param>
        /// <param name="muncodigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorTipoRebanho/{tipcodigo:int}/PorMunicipio/{muncodigo:int}")]
        public ActionResult<List<RebanhoPoco>> GetByTipoRebanhoByMunicipio(int tipcodigo, int muncodigo)
        {
            try
            {
                List<RebanhoPoco> lista = this.servico.Consultar(reb => (reb.CodigoTipoRebanho == tipcodigo) && (reb.CodigoMunicipio == muncodigo)).ToList();
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
        public ActionResult<RebanhoPoco> Post([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<RebanhoPoco> Put([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<RebanhoPoco> DeleteById(int codigo)
        {
            try
            {
                RebanhoPoco delnovo = this.servico.Excluir(codigo);
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
        public ActionResult<RebanhoPoco> DeleteByInstancia([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco delnovo = this.servico.Excluir(poco.CodigoRebanho);
                return Ok(delnovo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
