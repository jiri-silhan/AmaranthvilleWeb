using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmaranthvilleWeb.Pages
{
    public class DogModel : PageModel
    {
        public PrezentacePsa Pes { get; set; }
        public async Task OnGetAsync()
        {
            var client = new KenticoCloudClient();
            var goofy = await client.LanguageDeliveryClient.GetItemAsync<PrezentacePsa>("goofy");
            Pes = goofy.Item;
        }
    }
}
