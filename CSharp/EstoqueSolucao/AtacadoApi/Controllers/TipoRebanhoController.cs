using Atacado.Poco.Pecuaria;
using Atacado.Servico.Pecuaria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/pecuaria/[controller]")]
    [ApiController]
    public class TipoRebanhoController : ControllerBase
    {
        private TipoRebanhoService servico;

        public TipoRebanhoController()
        {
            this.servico = new TipoRebanhoService();
        }

        /// <summary>
        /// Lista todos os registros do recurso.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa </param>
        /// <param name="skip"> Quantos registros serão retornados </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<TipoRebanhoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<TipoRebanhoPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Pesquisa o registro usando uma chave de TipoRebanho.
        /// </summary>
        /// <param name="codigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<TipoRebanhoPoco> GetByID(int codigo)
        {
            try
            {
                TipoRebanhoPoco lista = this.servico.PesquisarPelaChave(codigo);
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
        public ActionResult<TipoRebanhoPoco> Post([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<TipoRebanhoPoco> Put([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<TipoRebanhoPoco> DeleteById(int codigo)
        {
            try
            {
                TipoRebanhoPoco delnovo = this.servico.Excluir(codigo);
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
        public ActionResult<TipoRebanhoPoco> DeleteByInstancia([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco delnovo = this.servico.Excluir(poco.CodigoTipo);
                return Ok(delnovo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
