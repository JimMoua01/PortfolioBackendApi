using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using PortfolioApi.Models;

namespace PortfolioApi.Services
{
    public class PortfolioService
    {
        private readonly DataContext _dataContext;

        public PortfolioService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _dataContext.Projects.ToListAsync();
        }

        public async Task<Project> GetProjectById(int id)
        {
            return await _dataContext.Projects.FindAsync(id);
        }

        public async Task<Project> AddProject(Project project)
        {
            _dataContext.Projects.Add(project);
            await _dataContext.SaveChangesAsync();
            return project;
        }

        public async Task<Project> UpdateProject(Project project)
        {
            _dataContext.Projects.Update(project);
            await _dataContext.SaveChangesAsync();
            return project;
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _dataContext.Contacts.ToListAsync();
        } 

        public async Task<Contact> GetContactById(int id)
        {
            return await _dataContext.Contacts.FindAsync(id);
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            _dataContext.Contacts.Add(contact);
            await _dataContext.SaveChangesAsync();
            return contact;
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
            _dataContext.Contacts.Update(contact);
            await _dataContext.SaveChangesAsync();
            return contact;
        }
    }
}
