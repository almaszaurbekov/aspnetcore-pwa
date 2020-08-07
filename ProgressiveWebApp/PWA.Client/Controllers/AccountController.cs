using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PWA.Client.Models;
using PWA.Common.Configurations;
using PWA.Infrastructure.Identity;
using System.Threading.Tasks;

namespace PWA.Client.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILogger<AccountController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AccountConfiguration _configuration;

        public AccountController(ILogger<AccountController> logger, AccountConfiguration configuration,
             UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _logger = logger;
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                AddModelError(_configuration.NullUserMessage);
                return View(model);
            }
            //if (!user.EmailConfirmed)
            //{
            //    AddModelError(_configuration.EmailNotConfirmedMessage);
            //    return View(model);
            //}

            var result = await _signInManager
                .PasswordSignInAsync(user, model.Password, model.RememberMe, true);

            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in");
                return RedirectToAction("Index", "Application");
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning($"User with id:{user.Id} is locked out");
                AddModelError(_configuration.UserBlockedMessage);
                return View(model);
            }
            else
            {
                AddModelError(_configuration.IncorrectPasswordMessage);
                return View(model);
            }
        }

        private void AddModelError(string errorMessage) => ModelState.AddModelError(string.Empty, errorMessage);
    }
}
