using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KenticoCloud.Delivery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmaranthvilleWeb.Pages
{
    public class DogModel : PageModel
    {
        public PrezentacePsa Pes { get; set; }
        public async Task OnGetAsync(string slimacik)
        {
            var client = new KenticoCloudClient();
            var dogs = await client.LanguageDeliveryClient.GetItemsAsync<PrezentacePsa>(new EqualsFilter("elements.url_slimacik", slimacik));
            Pes = dogs.Items.First();
        }
    }
}
