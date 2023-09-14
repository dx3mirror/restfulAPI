using Microsoft.AspNetCore.Mvc;
using RestFulApiHHRU.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace RestFulApiHHRU.Controllers
{
    public class DeveloperController
    {
        [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
        [ApiController]
        public class DrillBlocksController : Microsoft.AspNetCore.Mvc.ControllerBase
        {
            private readonly HHRUEntities _context;

            public DrillBlocksController(HHRUEntities context)
            {
                _context = context;
            }
            
            // Создать блок
            [HttpPost]
            public async Task<DrillBlock> CreateDrillBlock(DrillBlock drillBlock)
            {
                _context.DrillBlock.Add(drillBlock);
                await _context.SaveChangesAsync();
                return drillBlock;
            }

            // Обновить блок
            [HttpPut("{id}")]
            public async Task<DrillBlock> UpdateDrillBlock(int id, DrillBlock drillBlock)
            {
                var toUpdate = _context.DrillBlock.Find(id);
                if (toUpdate == null)
                {
                    return null; // Or some sort of 'Not Found' error
                }
                toUpdate.UpdateTime = drillBlock.UpdateTime;
                toUpdate.Name = drillBlock.Name;
                await _context.SaveChangesAsync();
                return toUpdate;
            }

            // Удалить блок
            [HttpDelete("{id}")]
            public async Task DeleteDrillBlock(int id)
            {
                var toRemove = _context.DrillBlock.Find(id);
                _context.DrillBlock.Remove(toRemove);
                await _context.SaveChangesAsync();
            }

            [HttpPost]
            public async Task<DrillBlockPoint> CreateDrillPoint(DrillBlockPoint drillBlockPoint)
            {
                _context.DrillBlockPoint.Add(drillBlockPoint);
                await _context.SaveChangesAsync();
                return drillBlockPoint;
            }

            [HttpPut("{id}")]
            public async Task<DrillBlockPoint> UpdateDrillBlockPoint(int id, DrillBlockPoint drillBlockPoint)
            {
                var toUpdate = _context.DrillBlockPoint.Find(id);
                if (toUpdate == null)
                {
                    return null; // Or some sort of 'Not Found' error
                }
                toUpdate.Sequence = drillBlockPoint.Sequence;
                toUpdate.DrillBlockId = drillBlockPoint.DrillBlockId;
                await _context.SaveChangesAsync();
                return toUpdate;
            }

            // Удалить блок
            [HttpDelete("{id}")]
            public async Task DeleteDrillBlockPoint(int id)
            {
                var toRemove = _context.DrillBlockPoint.Find(id);
                _context.DrillBlockPoint.Remove(toRemove);
                await _context.SaveChangesAsync();
            }
        }
    }
}