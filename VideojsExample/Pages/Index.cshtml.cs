using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VideojsExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public string ManifestUrlHidden { get; set; }

        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public string TokenHidden { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            // You can create a new token by following the this question https://docs.microsoft.com/en-us/answers/questions/858600/aes-token-not-working-on-ios-iphone-asked-to-add-p.html?childToView=984307#answer-984307
            // But basically hit this url https://www.ibeinni.is/Event/ViewEvent/8cf1dc7a-b7e3-4c2f-a709-4a9503f18dc6?couponCode=815563&drm=x9  and registering and I print out new token
            var token = "Bearer=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1cm46bWljcm9zb2Z0OmF6dXJlOm1lZGlhc2VydmljZXM6Y29udGVudGtleWlkZW50aWZpZXIiOiI1MjI5YjkzOC1kYWFlLTQwNWUtOGMzMy00YjViZTU0ZmRjZmEiLCJ1cm46bWljcm9zb2Z0OmF6dXJlOm1lZGlhc2VydmljZXM6bWF4dXNlcyI6IjUiLCJuYmYiOjE2NjM4MzIzNzYsImV4cCI6MTY2MzgzMzI3NiwiaXNzIjoiaUJlaW5uaUlzc3VlciIsImF1ZCI6ImlCZWlubmlBdWRpZW5jZSJ9.7MrNBEt7hJ5XmK5muBVN2yP7Hn1j3YUEQ52VYvr5LGQ";
            TokenHidden = $"{token}";


            //DASH
            ManifestUrlHidden = $"https://beinnip-euno.streaming.media.azure.net/4dd929ef-29dc-438b-9a84-ae5fe718322a/7324bef4-d61c-492b-a3a6-ad8470967ea5.ism/manifest(format=mpd-time-csf,encryption=cbc)?token={token}";

            //HLS (apple)
            // ManifestUrlHidden = $"https://beinnip-euno.streaming.media.azure.net/4dd929ef-29dc-438b-9a84-ae5fe718322a/7324bef4-d61c-492b-a3a6-ad8470967ea5.ism/manifest(format=m3u8-cmaf,encryption=cbc)?token={token}";
        }
    }
}