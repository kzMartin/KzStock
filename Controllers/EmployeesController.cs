using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KzStock.Core;
using KzStock.Models;
using KzStock.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KzStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IGenericRepository<Employee> _employeeRepo;
        private readonly IMapper _mapper;

        public EmployeesController(IMapper mapper, IGenericRepository<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            var employees = await _employeeRepo.FindAllAsync();
            return Ok(_mapper.Map<IEnumerable<Employee>, List<EmployeeViewModel>>(employees));
        }

        [HttpGet("get/{id?}")]
        public async Task<IActionResult> Get(int id)
        {
            var employee = await _employeeRepo.FindByConditionAsync(p => p.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Employee, EmployeeViewModel>(employee.SingleOrDefault()));
        }

        [HttpGet("getByEmail/{email?}")]
        public async Task<IActionResult> Get(string email)
        {
            var employee = await _employeeRepo.FindByConditionAsync(p => p.Email.ToLower() == email.ToLower());

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Employee, EmployeeViewModel>(employee.SingleOrDefault()));
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] EmployeeViewModel employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            var newEmployee = _mapper.Map<EmployeeViewModel, Employee>(employee);
            _employeeRepo.Create(newEmployee);
            await _employeeRepo.SaveAsync();


            return CreatedAtAction("Create", new { id = newEmployee.Id }, _mapper.Map<Employee, EmployeeViewModel>(newEmployee));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] EmployeeViewModel employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            var previousEmployee = _mapper.Map<EmployeeViewModel, Employee>(employee);
            _employeeRepo.Update(previousEmployee);
            await _employeeRepo.SaveAsync();

            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _employeeRepo.FindByConditionAsync(p => p.Id == id);
            if (employee == null)
            {
                return BadRequest();
            }

            _employeeRepo.Delete(employee.SingleOrDefault());
            await _employeeRepo.SaveAsync();

            return NoContent();
        }
    }
}