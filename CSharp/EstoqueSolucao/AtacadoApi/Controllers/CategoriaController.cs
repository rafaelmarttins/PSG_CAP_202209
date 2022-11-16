using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.DB.EF.Database;
using System.Runtime.CompilerServices;
using System;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private CategoriaServico servico;
        /// <summary>
        /// 
        /// </summary>
        public CategoriaController() : base()
        {
            this.servico = new CategoriaServico();
        }

        /// <summary>
        /// Lista todos os registros do recurso.
        /// </summary>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<CategoriaPoco>> GetAll()
        {
            try
            {
                List<CategoriaPoco> lista = this.servico.Listar();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Pesquisa o registro usando a chave de Categoria.
        /// </summary>
        /// <param name="codigo"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<CategoriaPoco> GetByID(int codigo)
        {
            try
            {
                CategoriaPoco poco = this.servico.PesquisarPelaChave(codigo);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        /// <summary>
        /// Inclui um novo dado no registro.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<CategoriaPoco> Post([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<CategoriaPoco> Put([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco novoPoco = this.servico.Alterar(poco);
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
        /// <returns> Dado excluido por Id.</returns>
        [HttpDelete("{codigo:int}")]
        public ActionResult<CategoriaPoco> DeleteById(int codigo)
        {
            try
            {
                CategoriaPoco delPoco = this.servico.Excluir(codigo);
                return Ok(delPoco);
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
        public ActionResult<CategoriaPoco> DeleteByInstancia([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco delPoco = this.servico.Excluir(poco.Codigo);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
