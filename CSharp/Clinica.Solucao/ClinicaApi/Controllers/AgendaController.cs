using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Clinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/odonto/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private AgendaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public AgendaController(ClinicaContext context) : base()
        {
            this.servico = new AgendaServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Agenda.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<AgendaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<AgendaPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Agenda por código de Paciente.
        /// </summary>
        /// <param name="paccodigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorPaciente/{paccodigo:int}")]
        public ActionResult<List<AgendaPoco>> GetByPaciente(int paccodigo)
        {
            try
            {
                List<AgendaPoco> listaPoco = this.servico.Consultar(age => age.CodigoPaciente == paccodigo).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Listar todos os registros da tabela Agenda por código de Consulta e Ano.
        /// </summary>
        /// <param name="concodigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorConsulta/{concodigo:int}/PorAno/{ano:int}")]
        public ActionResult<List<AgendaPoco>> GetByConsultaByAno(int concodigo, int ano)
        {
            try
            {
                List<AgendaPoco> listaPoco = this.servico.Consultar(age => (age.CodigoConsulta == concodigo) && (age.Ano == ano)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave da Agenda.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<AgendaPoco> GetById(int chave)
        {
            try
            {
                AgendaPoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<AgendaPoco> Post([FromBody] AgendaPoco poco)
        {
            try
            {
                AgendaPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<AgendaPoco> Put([FromBody] AgendaPoco poco)
        {
            try
            {
                AgendaPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<AgendaPoco> DeleteById(int chave)
        {
            try
            {
                AgendaPoco poco = this.servico.Excluir(chave);
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
        public ActionResult<AgendaPoco> Delete([FromBody] AgendaPoco poco)
        {
            try
            {
                AgendaPoco novoPoco = this.servico.Excluir(poco.CodigoAgenda);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
