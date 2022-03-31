using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Threading.Tasks;
using E_commerce1.ViewModels;
using System.Linq;
using System.Collections.Generic;
using E_commerce1.Models;

namespace E_commerce1.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleController( RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task< IActionResult> Index()
        {
         
            
      
            return View(await _roleManager.Roles.ToListAsync());
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel role )
        {
            //check if the role exists
          
            if (ModelState.IsValid) { 
            await _roleManager.CreateAsync(new IdentityRole(role.RoleName.Trim()));
            return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(nameof(Index), await _roleManager.Roles.ToListAsync());
            }
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id != null)
            {
                await _roleManager.DeleteAsync(_roleManager.FindByIdAsync(id).Result);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ErrorViewModel errorViewModel = new ErrorViewModel()
                {
                    RequestId="no role found"
                    
                };
                return View("Error", errorViewModel);
            }
        }
        public async Task< bool> RoleExsist(string RoleName)
        {

            return (! await _roleManager.RoleExistsAsync(RoleName));
        }
    }
}
