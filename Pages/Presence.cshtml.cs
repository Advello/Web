using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
namespace Web.Pages
{
    public class PresenceModel : PageModel
    {
        
        private readonly ILogger<PresenceModel> _logger;

        public PresenceModel(ILogger<PresenceModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {  
            
            
            
        }
        
        
    }
    
}
