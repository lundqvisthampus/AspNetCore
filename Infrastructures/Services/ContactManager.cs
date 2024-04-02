using Infrastructures.Contexts;
using Infrastructures.Dto;
using Infrastructures.Migrations;
using Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Services;

public class ContactManager(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<ContactModel> GetOneAsync(int id)
    {
        var sender = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
        if (sender != null)
        {
            return sender;
        }
        return null!;
    }

    public async Task<IEnumerable<ContactModel>> GetOneAsync(string email)
    {
        var sender = await _context.Contacts.Where(x => x.Email == email).ToListAsync();
        if (sender != null)
        {
            return sender;
        }
        return null!;
    }

    public async Task<IEnumerable<ContactModel>> GetAll()
    {
        var senders = await _context.Contacts.ToListAsync();
        return senders;
    }

    public async Task<ContactModel> CreateAsync(ContactDto dto)
    {
        try
        {
            var model = new ContactModel
            {
                Email = dto.Email,
                FullName = dto.FullName,
                Service = dto.Service,
                Message = dto.Message
            };

            _context.Contacts.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
        catch
        {
            return null!;
        }
    }


    public async Task<bool> DeleteAsync(int id)
    {
        var exists = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);

        if (exists != null)
        {
            _context.Contacts.Remove(exists);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}
