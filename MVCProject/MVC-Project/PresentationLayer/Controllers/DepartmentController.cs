using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Repositories;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;

        public DepartmentController(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await UnitOfWork.DepartmentRepository.GetAllAsync();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            if (!ModelState.IsValid) // Server Side Validation
                return View(department); // return the same view but with the error messages

            await UnitOfWork.DepartmentRepository.AddAsync(department);
            await UnitOfWork.CompleteAsync();
            TempData["Message"] = "Department is created"; // transfer data from action to action.
            return RedirectToAction(nameof(Index));
        }

        /*
         Details is the same as Edit but one is read only and the other can be edited
         */
        public async Task<IActionResult> Details(int? id, bool Writable = false)
        {
            if (id is null)
                return BadRequest();

            var department = await UnitOfWork.DepartmentRepository.GetByEntryIdAsync(id.Value);

            if (department is null)
                return NotFound();

            if (Writable)
                return View("Edit", department);

            return View("Details", department);
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
        public async Task<IActionResult> Edit(Department department, [FromRoute] int id)
        {
            // Useless
            if (id != department.Id)
                return BadRequest();


            if (!ModelState.IsValid)
                return View(department);

            try
            {
                UnitOfWork.DepartmentRepository.Update(department);
                await UnitOfWork.CompleteAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception ex)
            {
                // Log exceptions 
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(department);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return BadRequest();

            var depatment = await UnitOfWork.DepartmentRepository.GetByEntryIdAsync(id.Value);

            if (depatment is null) return NotFound();

            return View(depatment);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Department department)
        {
            if (department is null) return NotFound();

            try
            {
                UnitOfWork.DepartmentRepository.Delete(department);
                await UnitOfWork.CompleteAsync();
            }
            catch
            {
                return View(department);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
