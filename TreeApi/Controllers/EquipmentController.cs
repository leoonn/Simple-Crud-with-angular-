using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreeApi.Models;

namespace TreeApi.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly ContextEquipment _ContextEquipment;

        public EquipmentController (ContextEquipment context)
        {
            _ContextEquipment = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipments>>> GetAllAsync()
        {
         return await _ContextEquipment.Equipment.ToListAsync();
        }

        [HttpGet("{EquipmentsID}")]
        public async Task<ActionResult<Equipments>> GetEquipmentAsync(int EquipmentsID)
        {
            Equipments equipment = await _ContextEquipment.Equipment.FindAsync(EquipmentsID);

            if(equipment == null)
            {
                return NotFound();
            }

            return equipment;
        }

        [HttpPost]
        public async Task<ActionResult<Equipments>> PostEquipmentAsync(Equipments equipments)
        {   
            await _ContextEquipment.Equipment.AddAsync(equipments);
            await _ContextEquipment.SaveChangesAsync();

            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> PutEquipmentAsync(Equipments equipments)
        {
            _ContextEquipment.Equipment.Update(equipments);
            await _ContextEquipment.SaveChangesAsync();

            return Ok();

        }

        [HttpDelete("{EquipmentsID}")]
        public async Task<ActionResult> DeleteEquipmentAsync(int EquipmentsID)
        {
           Equipments equipment = await _ContextEquipment.Equipment.FindAsync(EquipmentsID);
            _ContextEquipment.Remove(equipment);
            await _ContextEquipment.SaveChangesAsync();

            return Ok();
        }
    }
}