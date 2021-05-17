using FirstApi.Data;
using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstApi.Controllers
{
    
    [ApiController]

    public class EquipamentoController : ControllerBase
    {
        private IEquipamentoData _equipamentoData;

        public EquipamentoController(IEquipamentoData equipamentoData)
        {
            _equipamentoData = equipamentoData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEquipamentos()
        {
            return Ok(_equipamentoData.GetEquipamentos());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEquipamento(Guid id)
        {
            var equipamento = _equipamentoData.GetEquipamento(id);

            if (equipamento != null)
            {
                return Ok(equipamento);
            }

            return NotFound($"Equipamento with Id: {id} was not found");
        }


        [HttpPost]
        [Route("api/[controller]/")]
        public IActionResult AddEquipamento(Equipamento equipamento)
        {
            _equipamentoData.AddEquipamento(equipamento);

            return Created(
                HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + 
                HttpContext.Request.Path+"/"+
                equipamento.Id, equipamento);
        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEquipamento(Guid id)
        {
            var equipamento = _equipamentoData.GetEquipamento(id);

            if (equipamento != null)
            {
                _equipamentoData.DeleteEquipamento(equipamento);
                return Ok();
            }

            return NotFound($"Equipamento with Id: {id} was not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEquipamento(Guid id, Equipamento equipamento)
        {
            var equipamentoExistente = _equipamentoData.GetEquipamento(id);

            if (equipamentoExistente != null)
            {
                equipamento.Id = equipamentoExistente.Id;
                _equipamentoData.EditEquipamento(equipamento);
            }
            return Ok(equipamento);
        }
    }   
}
