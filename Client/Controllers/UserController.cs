using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Client.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UserController(UserManager<IdentityUser> userManager) {
            _userManager = userManager;
        }

        public async Task<IActionResult> GetUserId()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var userId = user.Id;
              
                return Ok(userId);
                // Sử dụng userId ở đây
            }
            return null;
            // ...
        }
    }
}
