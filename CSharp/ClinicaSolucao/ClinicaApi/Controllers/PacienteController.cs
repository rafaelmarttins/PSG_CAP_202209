using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Odonto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private PacienteServico servico;

        /// <summary>
        /// 
        /// </summary>
        public PacienteController(ClinicaContext context) : base()
        {
            this.servico = new PacienteServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Paciente.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<PacientePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PacientePoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Paciente por código de Profissão.
        /// </summary>
        /// <param name="procodigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorProfisao/{procodigo:int}")]
        public ActionResult<List<PacientePoco>> GetByProfissao(int procodigo)
        {
            try
            {
                List<PacientePoco> listaPoco = this.servico.Consultar(pac => pac.CodigoProfissao == procodigo).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Paciente.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<PacientePoco> GetById(int chave)
        {
            try
            {
                PacientePoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Paciente.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<PacientePoco> Post([FromBody] PacientePoco poco)
        {
            try
            {
                PacientePoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Paciente.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<PacientePoco> Put([FromBody] PacientePoco poco)
        {
            try
            {
                PacientePoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<PacientePoco> DeleteById(int chave)
        {
            try
            {
                PacientePoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
