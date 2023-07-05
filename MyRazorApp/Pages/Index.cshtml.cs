using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Category> Categories { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            for (int i = 0; i <= 100; i++)
            {
                Categories.Add(new Category(i, "Categoria " + i + 1, i * 2.31M));
            }
        }

    }
}

public record Category(int Id, string Title, decimal Price);