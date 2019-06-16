using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Category;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniPin_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICreateCategoryCommand _create;
        private readonly IGetAllCategoryCommand _getAll;
        private readonly IGetOneCategoryCommand _getOne;
        private readonly IUpdateCategoryCommand _update;
        private readonly IDeleteCategoryCommand _delete;

        public CategoryController(ICreateCategoryCommand create, IGetAllCategoryCommand getAll, IGetOneCategoryCommand getOne, IUpdateCategoryCommand update, IDeleteCategoryCommand delete)
        {
            _create = create;
            _getAll = getAll;
            _getOne = getOne;
            _update = update;
            _delete = delete;
        }








        // GET: Category
        public ActionResult<List<CategoryDTO>> Index([FromQuery] CategorySearch search)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var category = _getAll.Execute(search);
                    return View(category);
                }


            }
            catch (Exception e)
            {
                TempData["error"] = "Greska" + e.Message;
            }
            return View();
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var category = _getOne.Execute(id);
                return View(category);
            }
            catch (Exception e)
            {
                TempData["error"] = "Greska" + e.Message;
            }
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryDTO collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _create.Execute(collection);
                    return RedirectToAction(nameof(Index));
                }

                
            }
            catch(EntityAlreadyExistsException)
            {
                TempData["error"] = "Ova kategorija vec postoji";
            }
            catch (Exception e)
            {
                TempData["error"] = "Greska" + e.Message;
            }
            return View();
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var category = _getOne.Execute(id);
                return View(category);
            }
            catch (Exception e)
            {
                TempData["error"] = "Greska" + e.Message;

            }
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryDTO dto)
        {
            try
            {
                // TODO: Add update logic here
                _update.Execute(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(dto);
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id, CategoryDTO dto)
        {
            dto = _getOne.Execute(id);
            return View(dto);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _delete.Execute(id);
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
         
        }
    }
}