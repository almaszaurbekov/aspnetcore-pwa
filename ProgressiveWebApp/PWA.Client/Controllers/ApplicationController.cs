using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using PWA.Infrastructure.Identity;
using System;
using System.Threading.Tasks;

namespace PWA.Client.Controllers
{
    [Authorize]
    public class ApplicationController : Controller
    {
        private readonly IMemoryCache _cache;
        private readonly IHttpContextAccessor _accessor;
        private readonly ILogger<ApplicationController> _logger;
        private readonly UserManager<User> _userManager;

        public ApplicationController(IMemoryCache cache, IHttpContextAccessor accessor,
            ILogger<ApplicationController> logger, UserManager<User> userManager)
        {
            _cache = cache;
            _accessor = accessor;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
