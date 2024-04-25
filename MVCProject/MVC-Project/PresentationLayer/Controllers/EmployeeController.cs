using AutoMapper;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Repositories;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PresentationLayer.Helpers;
using PresentationLayer.Models;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper mapper;

        public EmployeeController(IUnitOfWork UnitOfWork, IMapper mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index(string Name)
        {
            IEnumerable<Employee> employees;
            if (Name is null)
                employees = await UnitOfWork.EmployeeRepository.GetAllAsync();
            else
                employees = UnitOfWork.EmployeeRepository.GetEmployeesByName(Name);

            IEnumerable<EmployeeViewModel> employeesViewModel = mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);

            ViewData["Message"] = "Hello from view data"; // Dictionary<string, object>
            ViewBag.Message = "Hello from view bag"; // Dynamic, Will override the message value.
            return View(employeesViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = new SelectList(await UnitOfWork.DepartmentRepository.GetAllAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeViewModel)
        {
            if (!ModelState.IsValid) // Server Side Validation
                return View(employeeViewModel); // return the same view but with the error messages

            // Here we need mapping from Employee to EmployeeViewModel with many ways such as:
            // 1- Manual mapping.
            // 2- Explicit casting (which will need operator overloading) and inside it we will use manual mapping
            // 3- AutoMapper Package.

            employeeViewModel.ImageName = DocumentSettings.UploadFile(employeeViewModel.Image, "Images");
            Employee employee = mapper.Map<EmployeeViewModel, Employee>(employeeViewModel);
            await UnitOfWork.EmployeeRepository.AddAsync(employee);
            await UnitOfWork.CompleteAsync();
            return RedirectToAction(nameof(Index));
        }

        /*
         Details is the same as Edit but one is read only and the other can be edited
         */
        public async Task<IActionResult> Details(int? id, bool Writable = false)
        {
            if (id is null)
                return BadRequest();

            var employee = UnitOfWork.EmployeeRepository.GetByEntryIdAsync(id.Value).Result;

            if (employee is null)
                return NotFound();
            var employeeViewModel = mapper.Map<Employee, EmployeeViewModel>(employee);

            ViewBag.Departments = new SelectList(await UnitOfWork.DepartmentRepository.GetAllAsync(), "Id", "Name");

            if (Writable)
                return View("Edit", employeeViewModel);

            return View("Details", employeeViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
                return BadRequest();

            return await Details(id.Value, true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeViewModel employeeViewModel, [FromRoute] int id)
        {
            // Useless
            if (id != employeeViewModel.Id)
                return BadRequest();


            if (!ModelState.IsValid)
                return View(employeeViewModel);

            try
            {
                if (employeeViewModel.Image is not null)
                {
                    DocumentSettings.DeleteFile(employeeViewModel.ImageName, "Images");
                    employeeViewModel.ImageName = DocumentSettings.UploadFile(employeeViewModel.Image, "Images");
                }
                var employee = mapper.Map<EmployeeViewModel, Employee>(employeeViewModel);
                UnitOfWork.EmployeeRepository.Update(employee);
                await UnitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception ex)
            {
                // Log exceptions 
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(employeeViewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return BadRequest();

            var employee = await UnitOfWork.EmployeeRepository.GetByEntryIdAsync(id.Value);

            if (employee is null) return NotFound();

            var employeeViewModel = mapper.Map<Employee, EmployeeViewModel>(employee);

            return View(employeeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EmployeeViewModel employeeViewModel)
        {
            if (employeeViewModel is null) return NotFound();
            var employee = mapper.Map<EmployeeViewModel, Employee>(employeeViewModel);
            try
            {
                UnitOfWork.EmployeeRepository.Delete(employee);
                await UnitOfWork.CompleteAsync();
                if (employeeViewModel.ImageName is not null)
                    DocumentSettings.DeleteFile(employeeViewModel.ImageName, "Images");
            }
            catch
            {
                return View(employeeViewModel);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
