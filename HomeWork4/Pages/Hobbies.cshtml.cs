using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork4.Pages
{
    public class HobbiesModel : PageModel
    {
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
        public async Task OnGetAsync()
        {
            Hobbies.Add(new Hobby() { Name = "Swimming", Duration = 5 });
            Hobbies.Add(new Hobby() { Name = "Dancing", Duration = 2 });
            Hobbies.Add(new Hobby() { Name = "Running", Duration = 7 });
            Hobbies.Add(new Hobby() { Name = "Traveling", Duration = 15 });
        }
    }
}
