using Infrastructures.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Infrastructures.Services;

public class CourseJsonManager
{
    public async Task<IEnumerable<CourseModel>> TakeFew(int pageNumber = 1, int pageSize = 9, string? token = null)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await client.GetAsync($"https://localhost:7023/api/Course/take?key=44ee639f-12d8-4847-a560-0604cc38cd57&pageNumber={pageNumber}&pageSize={pageSize}");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var coursesList = JsonConvert.DeserializeObject<IEnumerable<CourseModel>>(json);
            return coursesList!;
        }
        return null!;
    }

    public async Task<IEnumerable<CourseModel>> TakeAll(string? token = null)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await client.GetAsync($"https://localhost:7023/api/Course/all?key=44ee639f-12d8-4847-a560-0604cc38cd57");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var allCoursesList = JsonConvert.DeserializeObject<IEnumerable<CourseModel>>(json);
            return allCoursesList!;
        }
        return null!;
    }
}

