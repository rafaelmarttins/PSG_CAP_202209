using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Odonto;
using LinqKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class ProcedimentosController : ControllerBase
    {
        private ProcedimentosServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ProcedimentosController(ClinicaContext context) : base()
        {
            this.servico = new ProcedimentosServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Procedimentos por Paginação e Tipo Serviço.
        /// </summary>
        /// <param name="tipoServico"> Informar o tipo de Serviço. </param>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns></returns>
        [HttpGet("{tipoServico}")]
        public ActionResult<List<ServicoPoco>> GetAll(string tipoServico, int? take = null, int? skip = null)
        {
            try
            {
                List<ServicoPoco> listPoco;
                var predicate = PredicateBuilder.New<Clinica.Dominio.EF.Servico>(true);
                if (take == null) //OPCIONAL
                {
                    if (skip != null) //OPCIONAL
                    {
                        return BadRequest("Informe o parâmetro Take e Skip.");
                    }
                    else
                    {
                        predicate = predicate.And(s => s.TipoServico == tipoServico);
                        listPoco = this.servico.Consultar(predicate);
                        return Ok(listPoco);
                    }
                }
                else
                {
                    if (skip == null) //OPCIONAL
                    {
                        return BadRequest("Informe o parâmetro Take e Skip.");
                    }
                    else
                    {
                        predicate = predicate.And(s => s.TipoServico == "EX");
                        listPoco = this.servico.Vasculhar(take, skip, predicate);
                        return Ok(listPoco);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista os registro por Id e Tipo Serviço.
        /// </summary>
        /// <param name="tipoServico"> Informar o tipo de Serviço. </param>
        /// <param name="id"> Chave de pesquisa. </param>
        /// <returns></returns>
        [HttpGet("{tipoServico}/{id:int}")]
        public ActionResult<ServicoPoco> Get(string tipoServico, int id)
        {
            try
            {
                List<ServicoPoco> listPoco = this.servico.Consultar(s => (s.TipoServico == tipoServico) && (s.CodigoServico == id));
                return Ok(listPoco);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Procedimentos.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<ServicoPoco> Post([FromBody] ServicoPoco poco)
        {
            try
            {
                ServicoPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Exame.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<ServicoPoco> Put([FromBody] ServicoPoco poco)
        {
            try
            {
                ServicoPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<ServicoPoco> DeleteById(int chave)
        {
            try
            {
                ServicoPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
