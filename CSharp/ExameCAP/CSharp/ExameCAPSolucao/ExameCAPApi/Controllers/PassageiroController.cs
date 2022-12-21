using ExameCAP.Dominio.EF;
using ExameCAP.Poco;
using ExameCAP.Service.Exame;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExameCapApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/exame/[controller]")]
    [ApiController]
    public class PassageiroController : ControllerBase
    {
        private PassageiroService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public PassageiroController(ExameCAPContext contexto) : base()
        {
            this.servico = new PassageiroService(contexto);
        }

        /// <summary>
        /// Lista todos os registros da tabela Passageiro por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<PassageiroPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PassageiroPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Passageiro.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<PassageiroPoco> GetByFuncionarioId(int chave)
        {
            try
            {
                PassageiroPoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Passageiro.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<PassageiroPoco> Post([FromBody] PassageiroPoco poco)
        {
            try
            {
                PassageiroPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Passageiro.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<PassageiroPoco> Put([FromBody] PassageiroPoco poco)
        {
            try
            {
                PassageiroPoco novoPoco = this.servico.Alterar(poco);
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
        /// <param name="chave"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<PassageiroPoco> DeleteById(int chave)
        {
            try
            {
                PassageiroPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}