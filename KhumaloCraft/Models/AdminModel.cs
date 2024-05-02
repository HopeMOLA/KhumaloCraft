using Microsoft.AspNetCore.Authorization;

namespace KhumaloCraft.Models
{
    
        [Authorize(Roles = "Admin")]
        public class AdminModel
        {

            public void OnGet()
            {

            }
        }
    
}
