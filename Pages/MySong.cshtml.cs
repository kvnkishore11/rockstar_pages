using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rockstar_pages.Pages;

public class MySongModel : PageModel
{
    private readonly ILogger<MySongModel> _logger;

    public MySongModel(ILogger<MySongModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

