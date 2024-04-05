using Infrastructures.Contexts;
using Infrastructures.Dto;
using Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Services;

public class CourseManager(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<CourseModel> GetOneAsync(int id)
    {
        var course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
        if (course != null)
        {
            return course;
        }
        return null!;
    }

    public async Task<CourseModel> GetOneWithTitleAsync(string title)
    {
        var course = await _context.Courses.FirstOrDefaultAsync(x => x.Title == title);
        if (course != null)
        {
            return course;
        }
        return null!;
    }

    public async Task<IEnumerable<CourseModel>> GetAll()
    {
        var courses = await _context.Courses.ToListAsync();
        return courses;
    }

    public async Task<IEnumerable<CourseModel>> GetAll(int pageNumber, int pageSize)
    {
        int skipCount = (pageNumber - 1) * pageSize;

        var courses = await _context.Courses.Skip(skipCount).Take(pageSize).ToListAsync();
        return courses;
    }

    public async Task<CourseModel> CreateAsync(CourseDto dto)
    {
        var exists = await _context.Courses.FirstOrDefaultAsync(x => x.Title == dto.Title);
        if (exists == null)
        {
            var model = new CourseModel
            {
                CourseImgUrl = dto.CourseImgUrl,
                Author = dto.Author,
                AuthorFbFollowers = dto.AuthorFbFollowers,
                AuthorYtSubs = dto.AuthorYtSubs,
                CourseHours = dto.CourseHours,
                Price = dto.Price,
                DiscountPrice = dto.DiscountPrice,
                IsDigital = dto.IsDigital,
                IsBestSeller = dto.IsBestSeller,
                LikesNumber = dto.LikesNumber,
                LikesProcent = dto.LikesProcent,
                Title = dto.Title,
            };
            _context.Courses.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
        else
        {
            return exists;
        }
    }

    public async Task<bool> UpdateAsync(CourseDto dto, int existingId)
    {
        var existingCourse = await _context.Courses.FirstOrDefaultAsync(x => x.Id == existingId);
        if (existingCourse != null)
        {
            existingCourse.Author = dto.Author;
            existingCourse.AuthorFbFollowers = dto.AuthorFbFollowers;
            existingCourse.AuthorYtSubs = dto.AuthorYtSubs;
            existingCourse.CourseHours = dto.CourseHours;
            existingCourse.Price = dto.Price;
            existingCourse.DiscountPrice = dto.DiscountPrice;
            existingCourse.IsDigital = dto.IsDigital;
            existingCourse.IsBestSeller = dto.IsBestSeller;
            existingCourse.LikesNumber = dto.LikesNumber;
            existingCourse.LikesProcent = dto.LikesProcent;
            existingCourse.Title = dto.Title;

            _context.Courses.Update(existingCourse);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }


    public async Task<bool> DeleteAsync(int id)
    {
        var exists = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);

        if (exists != null)
        {
            _context.Courses.Remove(exists);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}
