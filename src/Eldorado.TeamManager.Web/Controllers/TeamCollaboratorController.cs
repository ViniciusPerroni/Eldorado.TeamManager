using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Web.Models.TeamCollaborator;

using Microsoft.AspNetCore.Mvc;

namespace Eldorado.TeamManager.Web.Controllers
{
    public class TeamCollaboratorController : Controller
    {
        private readonly ITeamCollaboratorService _teamCollaboratorService;
        private readonly ISkillService _skillService;

        public TeamCollaboratorController(ITeamCollaboratorService teamCollaboratorService, ISkillService skillService)
        {
            _teamCollaboratorService = _teamCollaboratorService;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var viewModel = new TeamCollaboratorListViewModel();
            viewModel.TeamCollaborators = _teamCollaboratorService.ListAll();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = new TeamCollaboratorViewModel();
            viewModel.TeamCollaborator = await _teamCollaboratorService.GetById(id);
            LoadSkills(viewModel);

            return View("Form", viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = new TeamCollaboratorViewModel();
            viewModel.TeamCollaborator = new TeamCollaboratorDto();
            LoadSkills(viewModel);

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Save(TeamCollaboratorDto teamCollaborator)
        {
            if (teamCollaborator.Id == 0)
            {
                await _teamCollaboratorService.Create(teamCollaborator);
                TempData["teamCollaboratorSave"] = "Integrante adicionado com sucesso."; 
            }
            else
            {
                await _teamCollaboratorService.Update(teamCollaborator);
                TempData["teamCollaboratorSave"] = "Integrante editado com sucesso.";
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _teamCollaboratorService.Delete(id);

            TempData["teamCollaboratorDelete"] = "Integrante apagado com sucesso.";

            return RedirectToAction("Index");
        }

        private void LoadSkills(TeamCollaboratorViewModel model)
        {
            model.Skills = _skillService.ListAll().ToList();
        }
    }
    
}