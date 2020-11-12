using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotorcycleApi.Models;

namespace MotorcycleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleItemsController : ControllerBase
    {
        private readonly MotorcycleContext _context;

        public MotorcycleItemsController(MotorcycleContext context)
        {
            _context = context;
        }

        // GET: api/MotorcycleItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MotorcycleItemDTO>>> GetMotorcycleItems(long id)
        {
            return await _context.MotorcycleItems
                .Select(x => ItemToDTO(x))
                .ToListAsync();


        }

        // GET: api/MotorcycleItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MotorcycleItemDTO>> GetMotorcycleItem(long id)
        {
            var motorcycleItem = await _context.MotorcycleItems.FindAsync(id);

            if (motorcycleItem == null)
            {
                return NotFound();
            }

            return ItemToDTO(motorcycleItem);
        }

        // PUT: api/MotorcycleItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> UpgradeMotorcycleItem(long id, MotorcycleItemDTO motorcycleItemDTO)
        {
            if (id != motorcycleItemDTO.Id)
            {
                return BadRequest();
            }

            var motorcycleItem = await _context.MotorcycleItems.FindAsync(id);
            if (motorcycleItem == null)
            {
                return NotFound();
            }

            motorcycleItem.Name = motorcycleItemDTO.Name;
            motorcycleItem.firm = motorcycleItemDTO.firm;
            motorcycleItem.price = motorcycleItemDTO.price;
            motorcycleItem.Year = motorcycleItemDTO.Year;
            motorcycleItem.IsUsed = motorcycleItemDTO.IsUsed;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!MotorcycleItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/MotorcycleItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MotorcycleItemDTO>>CreateMotorcycleItem(MotorcycleItemDTO motorcycleItemDTO)
        {
            var MotorcycleItem = new MotorcycleItem
            {
                Name = MotorcycleItem.Name,


            };


        }

        // DELETE: api/MotorcycleItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MotorcycleItem>> DeleteMotorcycleItem(long id)
        {
            var motorcycleItem = await _context.MotorcycleItems.FindAsync(id);

            if (motorcycleItem == null)
            {
                return NotFound();
            }

            _context.MotorcycleItems.Remove(motorcycleItem);
            await _context.SaveChangesAsync();

            return motorcycleItem;
        }

        private bool TodoItemExists(long id) =>
         _context.MotorcycleItems.Any(e => e.Id == id);

        private static MotorcycleItemDTO ItemToDTO(MotorcycleItem motorcycleItem) =>
            new MotorcycleItemDTO
            {
                Id = motorcycleItem.Id,
                Name = motorcycleItem.Name,
                Year = motorcycleItem.Year,
                firm = motorcycleItem.firm,
                price = motorcycleItem.price,
                IsUsed = motorcycleItem.IsUsed
            };
    }
}