using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Web.Models.Team;

using Microsoft.AspNetCore.Mvc;

namespace Eldorado.TeamManager.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        private readonly ISkillService _skillService;

        public TeamController(ITeamService teamService, ISkillService skillService)
        {
            _teamService = teamService;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            var viewModel = new TeamListViewModel();
            viewModel.Teams = _teamService.ListAll();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = new TeamViewModel();
            viewModel.Team = await _teamService.GetById(id);
            LoadSkills(viewModel);

            return View("Form", viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = new TeamViewModel();
            viewModel.Team = new TeamDto();
            LoadSkills(viewModel);

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Save(TeamDto team)
        {



            if (team.Id == 0)
            {
                await _teamService.Create(team);
                TempData["teamSave"] = "Equipe cadastrada com sucesso.";
            }
            else
            {
                await _teamService.Update(team);
                TempData["teamSave"] = "Equipe editada com sucesso.";
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.Delete(id);

            TempData["teamDelete"] = "Equipe apagada com sucesso.";

            return RedirectToAction("Index");
        }

        private void LoadSkills(TeamViewModel model)
        {
            model.Skills = _skillService.ListAll().ToList();
        }

        public async Task<IActionResult> UploadFileAsync(IFormFile PathAvatar)
        {

            string fileName = PathAvatar.FileName;
            fileName = Path.GetFileName(fileName);
            //extension = Path.GetExtension(fileName);
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\uploadFiles", fileName);


            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await PathAvatar.CopyToAsync(fileStream);

            }
            //separar a extensão do arquivo do nome do arquivo ex: img.png
            //gerar um nome aleatório para o arquivo
            //salvar arquivo com nome aleatório mais a extensão








            return RedirectToAction("Index");

        }
    }
}