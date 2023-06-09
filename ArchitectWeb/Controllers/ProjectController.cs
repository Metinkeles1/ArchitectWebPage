﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectWeb.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Project";
            ViewBag.v3 = "Project List";
            var values = projectManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Project";
            ViewBag.v3 = "Add Project";
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Project p)
        {           
            ProjectValidator validationRules = new ProjectValidator();
            ValidationResult validationResult = validationRules.Validate(p);
            if (validationResult.IsValid)
            {
                projectManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteProject(int id)
        {
            var values = projectManager.TGetByID(id);
            projectManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditProject(int id)
        {
            ViewBag.v1 = "Project Edit";
            ViewBag.v2 = "Project";
            ViewBag.v3 = "Edit Project";
            var values = projectManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditProject(Project project)
        {
            ProjectValidator validationRules = new ProjectValidator();
            ValidationResult results = validationRules.Validate(project);
            if(results.IsValid)
            {
                projectManager.TUpdate(project);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
