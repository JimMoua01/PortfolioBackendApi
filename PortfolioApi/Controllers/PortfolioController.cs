using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Data;
using PortfolioApi.DTOs;
using PortfolioApi.Models;
using PortfolioApi.Services;

namespace PortfolioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly PortfolioService _portfolioService;

        public PortfolioController(DataContext dataContext)
        {
            this._portfolioService = new PortfolioService(dataContext);
        }

        [HttpGet("projectData")]
        public async Task<IActionResult> GetProjects()
        {
            return Ok(await _portfolioService.GetProjects());
        }

        [HttpPost("projectData")]
        public async Task<IActionResult> AddProject([FromBody] NewProjectDTO newProjectDto)
        {
            Project project = new Project
            {
                Title = newProjectDto.Title,
                Description = newProjectDto.Description,
                Type = newProjectDto.Type,
                Link = newProjectDto.Link,
                Image = newProjectDto.Image,
            };

            await _portfolioService.AddProject(project);

            return Ok(project);
        }

        [HttpGet("contactData")]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await _portfolioService.GetContacts());
        }

        [HttpPost("contactData")]
        public async Task<IActionResult> AddContact([FromBody] NewContactDTO newContactDto)
        {
            Contact contact = new Contact
            {
                Company = newContactDto.Company,
                FirstName = newContactDto.FirstName,
                LastName = newContactDto.LastName,
                City = newContactDto.City,
                State = newContactDto.State,
                Zip = newContactDto.Zip,
                Email = newContactDto.Email,
                PhoneNumber = newContactDto.PhoneNumber,
                Comment = newContactDto.Comment
            };

            await _portfolioService.AddContact(contact);

            return Ok(contact);
        }
    }
}
