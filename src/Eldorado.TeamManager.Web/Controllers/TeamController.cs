using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Application.Services;
using Eldorado.TeamManager.Web.Models.Team;
using Eldorado.TeamManager.Web.Models.TeamCollaborator;

using Microsoft.AspNetCore.Mvc;

namespace Eldorado.TeamManager.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        private readonly ISkillService _skillService;
        private readonly ICollaboratorService _collaboratorService;

        public TeamController(ITeamService teamService, ISkillService skillService, ICollaboratorService collaboratorService)
        {
            _teamService = teamService;
            _skillService = skillService;
            _collaboratorService = collaboratorService;
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
                team.PathAvatar = this.UploadFileAvatar(team.AvatarFile);
                await _teamService.Create(team);
                TempData["teamSave"] = "Equipe cadastrada com sucesso.";
            }
            else
            {
                team.PathAvatar = this.UploadFileAvatar(team.AvatarFile) ?? team.PathAvatar;
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
        private string UploadFileAvatar(IFormFile avatarFile)
        {
            if(avatarFile == null)
                return null;

            var fileName = avatarFile.FileName;
            fileName = Path.GetFileName(fileName);
            var imageExtension = Path.GetExtension(fileName);

            var randomName = Path.GetRandomFileName();
            var randomNameWithoutExtension = Path.GetFileNameWithoutExtension(randomName);
            var randomNameWithExtension = randomNameWithoutExtension + imageExtension;

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\assets\\uploadFiles", randomNameWithExtension);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                avatarFile.CopyTo(fileStream);
            }

            return randomNameWithExtension;
        }
        public async Task<IActionResult> Collaborators(int teamId)
        {
            var viewModel = new TeamCollaboratorListViewModel();
            var team = await _teamService.GetById(teamId);

            viewModel.TeamId = teamId;
            if (team.TeamCollaborators != null && team.TeamCollaborators.Count > 0)
                viewModel.TeamCollaborators.AddRange(team.TeamCollaborators);

            return View(viewModel);
        }
        public async Task<IActionResult> AddCollaborator(int teamId)
        {
            var viewModel = new TeamCollaboratorListViewModel();
            var team = await _teamService.GetById(teamId);
            var collaborators = _collaboratorService.ListBySkillId(team.TeamSkills.Select(ts => ts.SkillId).ToArray()).ToList();
            
            viewModel.TeamId = teamId;
            if (collaborators != null && collaborators.Count > 0)
                viewModel.Collaborators.AddRange(collaborators);

            return View(viewModel);
        }

        public async Task<IActionResult> SaveCollaborator(long teamId, long collaboratorId)
        {
            await _teamService.AddCollaborator(teamId, collaboratorId);

            TempData["collaboratorSave"] = "Colaborador adicionado com sucesso";

            return RedirectToAction("Collaborators", new { teamId });
        }

        public async Task<IActionResult> DeleteCollaborator(long teamId, long teamCollaboratorId)
        {
            await _teamService.DeleteCollaborator(teamId, teamCollaboratorId);

            TempData["collaboratorSave"] = "Colaborador removido com sucesso";

            return RedirectToAction("Collaborators", new { teamId });
        }
    }
}