using Infrastructures.Contexts;
using Infrastructures.Dto;
using Infrastructures.Migrations;
using Infrastructures.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.Services;

public class SubscribeManager(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<SubscribersModel> GetOneAsync(string email)
    {
        var subscriber = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
        return subscriber!;
    }

    public async Task<IEnumerable<SubscribersModel>> GetAll()
    {
        var subscribers = await _context.Subscribers.ToListAsync();
        return subscribers;
    }

    public async Task<SubscribersModel> CreateAsync(SubscribeDto dto)
    {
        var exists = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == dto.Email);
        if (exists == null)
        {
            var model = new SubscribersModel
            {
                Email = dto.Email,
                AdvertisingUpdates = dto.AdvertisingUpdates,
                DailyNewsletter = dto.DailyNewsletter,
                EventUpdates = dto.EventUpdates,
                Podcasts = dto.Podcasts,
                StartupsWeekly = dto.StartupsWeekly,
                WeekInReview = dto.WeekInReview
            };
            _context.Subscribers.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
        else
        {
            return exists;
        }
    }


    public async Task<bool> DeleteAsync(string email)
    {
        var exists = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);

        if (exists != null)
        {
            _context.Subscribers.Remove(exists);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}
