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
        /// 
        /// </summary>
        /// <param name="tipoServico"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
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
        /// 
        /// </summary>
        /// <param name="tipoServico"></param>
        /// <param name="id"></param>
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
    }
}
