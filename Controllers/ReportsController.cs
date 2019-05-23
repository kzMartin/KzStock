using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KzStock.Core;
using KzStock.Models;
using KzStock.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KzStock.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IGenericRepository<Report> _reportRepo;
        private readonly IMapper _mapper;

        public ReportsController(IMapper mapper, IGenericRepository<Report> reportRepo)
        {
            _reportRepo = reportRepo;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            var report = await _reportRepo.FindAllAsync();
            return Ok(_mapper.Map<IEnumerable<Report>, List<ReportViewModel>>(report));
        }

        [HttpGet("get/{id?}")]
        public async Task<IActionResult> Get(int id)
        {
            var report = await _reportRepo.FindByConditionAsync(p => p.Id == id);

            if (report == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Report, ReportViewModel>(report.SingleOrDefault()));
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] ReportViewModel report)
        {
            if (report == null)
            {
                return BadRequest();
            }

            var newReport = _mapper.Map<ReportViewModel, Report>(report);
            _reportRepo.Create(newReport);
            await _reportRepo.SaveAsync();


            return CreatedAtAction("Create", new { id = report.Id }, _mapper.Map<Report, ReportViewModel>(newReport));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] ReportViewModel report)
        {
            if (report == null)
            {
                return BadRequest();
            }

            var previousReport = _mapper.Map<ReportViewModel, Report>(report);
            _reportRepo.Update(previousReport);
            await _reportRepo.SaveAsync();

            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var report = await _reportRepo.FindByConditionAsync(p => p.Id == id);
            if (report == null)
            {
                return BadRequest();
            }

            _reportRepo.Delete(report.SingleOrDefault());
            await _reportRepo.SaveAsync();

            return NoContent();
        }
    }
}
