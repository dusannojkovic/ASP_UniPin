using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.Commands.Category;
using Application.Commands.Picture;
using Application.Commands.Post;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UniPin_MVC.Controllers
{
    public class PostController : Controller
    {
        private readonly IGetPosts _getAll;
        private readonly IGetOnePostCommand _getOne;
        private readonly IAllCategory _allCategory;
        private readonly IAllUser _allUser;
        private readonly ICreatePostCommand _create;
        private readonly IUpdatePostCommand _update;
        private readonly IDeletePostCommand _delete;

        public PostController(IGetPosts getAll, IGetOnePostCommand getOne, IAllCategory allCategory, IAllUser allUser, ICreatePostCommand create, IUpdatePostCommand update, IDeletePostCommand delete)
        {
            _getAll = getAll;
            _getOne = getOne;
            _allCategory = allCategory;
            _allUser = allUser;
            _create = create;
            _update = update;
            _delete = delete;
        }






        // GET: Post
        public ActionResult<List<PostDTO>> Index([FromQuery] PostSearch search)
        {
            try
            {
                if (ModelState.IsValid)
            {
                var post = _getAll.Execute(search);
                return View(post);
            }
            }
            catch (EntityNotFoundException)
            {
                TempData["error"] = "Post nije pronadjen";
            }
            catch (Exception e)
            {
                TempData["error"] = "Error" + e.Message;
            }
            return View();
        }

        // GET: Post/Details/5
        public ActionResult<PostDTO> Details(int id)
        {
            try
            {
                var p = _getOne.Execute(id);
                return View(p);
            }
            catch (EntityNotFoundException)
            {
                TempData["error"] = "Ne postoji takav post";
                
            }
            catch(Exception e)
            {
                TempData["error"] = "Greska" + e.Message;
            }
            return View();
        }

        // GET: Post/Create
        public ActionResult Create(CategoryDTO dto, UserDTO user)
        {
            ViewBag.Categories = _allCategory.Execute(dto);
            ViewBag.Users = _allUser.Execute(user);
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostDTO dto)
        {
            try
            {

                _create.Execute(dto);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
          
                TempData["error"] = e.Message;
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id, CategoryDTO dto, UserDTO user)
        {
            ViewBag.Categories = _allCategory.Execute(dto);
            ViewBag.Users = _allUser.Execute(user);
            var one = _getOne.Execute(id);
            return View(one);
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PostDTO dto)
        {
            try
            {
                _update.Execute(dto);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                TempData["error"] = e.Message;
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id, PostDTO dto)
        {
            dto = _getOne.Execute(id);
            return View(dto);
        }

        // POST: Post/Delete/5
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