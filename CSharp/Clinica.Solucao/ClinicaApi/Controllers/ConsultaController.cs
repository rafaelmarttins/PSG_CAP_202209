using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Clinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/odonto/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private ConsultaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ConsultaController(ClinicaContext context) : base()
        {
            this.servico = new ConsultaServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Consulta.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<ConsultaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ConsultaPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Consulta.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<ConsultaPoco> GetById(int chave)
        {
            try
            {
                ConsultaPoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
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
        public ActionResult<ConsultaPoco> Post([FromBody] ConsultaPoco poco)
        {
            try
            {
                ConsultaPoco novoPoco = this.servico.Inserir(poco);
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
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<ConsultaPoco> Put([FromBody] ConsultaPoco poco)
        {
            try
            {
                ConsultaPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<ConsultaPoco> DeleteById(int chave)
        {
            try
            {
                ConsultaPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusão de um registro através de uma instância.
        /// </summary>
        /// <param name="poco"> Instancia a ser informada. </param>
        /// <returns> Dado excluido por Instancia. </returns>
        [HttpDelete]
        public ActionResult<ConsultaPoco> Delete([FromBody] ConsultaPoco poco)
        {
            try
            {
                ConsultaPoco novoPoco = this.servico.Excluir(poco.CodigoConsulta);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
