using image_API.Data;
using image_API.Models.Domain;
using image_API.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace image_API.Controllers
{
    public class AdminController : Controller
    {
        private readonly HumanDbContext humanDbContext;

        public AdminController(HumanDbContext humanDbContext)
        {
            this.humanDbContext = humanDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddHumanViewModel addHumanViewModel)
        {
            if (ModelState.IsValid)
            {
                var addHuman = new Human
                {
                    Name = addHumanViewModel.Name,
                    Gender = addHumanViewModel.Gender
                };
                if (addHumanViewModel.ProfileImage != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        await addHumanViewModel.ProfileImage.CopyToAsync(ms);
                        addHuman.ProfilePicture = ms.ToArray();
                    }
                }
                await humanDbContext._Humans.AddAsync(addHuman);
                await humanDbContext.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(addHumanViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var humanList = await humanDbContext._Humans.AsNoTracking().ToListAsync();
            return View(humanList);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var humanEdit = await humanDbContext._Humans.FirstOrDefaultAsync(x => x.Id == id);
            if (humanEdit != null)
            {
                var editHumanRequest = new EditHumanViewModel
                {
                    Name = humanEdit.Name,
                    Gender = humanEdit.Gender,
                    ExistingProfilePicture = humanEdit.ProfilePicture
                };
                return View(editHumanRequest);
            }
            return View(null);
        }
        [HttpPost]
        public async Task<IActionResult> Edit (EditHumanViewModel editHumanViewModel)
        {
            if (ModelState.IsValid)
            {
                var existingHuman = await humanDbContext._Humans.FindAsync(editHumanViewModel.Id);
                if (existingHuman != null)
                {
                    existingHuman.Name = editHumanViewModel.Name;
                    existingHuman.Gender = editHumanViewModel.Gender;
                    if (editHumanViewModel.ProfileImage != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            await editHumanViewModel.ProfileImage.CopyToAsync(ms);
                            existingHuman.ProfilePicture = ms.ToArray();
                        }
                    }
                }
                await humanDbContext.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(editHumanViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Delete (int id)
        {
            var deletedHuman = await humanDbContext._Humans.FindAsync(id);
            if (deletedHuman != null)
            {
                humanDbContext._Humans.Remove(deletedHuman);
                await humanDbContext.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
    }
}
