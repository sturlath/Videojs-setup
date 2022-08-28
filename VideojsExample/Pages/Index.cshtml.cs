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
            //DASH
            //ManifestUrlHidden = "https://beinnip-euno.streaming.media.azure.net/f76256b1-d120-406d-af06-4eea119c509b/dd6f798e-3e73-4e8b-96fe-789548854387.ism/manifest(format=mpd-time-cmaf,encryption=cbc)";

            //HLS
            ManifestUrlHidden = "https://beinnip-euno.streaming.media.azure.net/f76256b1-d120-406d-af06-4eea119c509b/dd6f798e-3e73-4e8b-96fe-789548854387.ism/manifest(format=m3u8-cmaf,encryption=cbc)";

            // You can create a new token by following the this question https://docs.microsoft.com/en-us/answers/questions/858600/aes-token-not-working-on-ios-iphone-asked-to-add-p.html?childToView=984307#answer-984307
            // But basically hit this url https://www.ibeinni.is/Event/ViewEvent/8cf1dc7a-b7e3-4c2f-a709-4a9503f18dc6?couponCode=815563&drm=x9  and registering and I print out new token
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1cm46bWljcm9zb2Z0OmF6dXJlOm1lZGlhc2VydmljZXM6Y29udGVudGtleWlkZW50aWZpZXIiOiI1MjI5YjkzOC1kYWFlLTQwNWUtOGMzMy00YjViZTU0ZmRjZmEiLCJ1cm46bWljcm9zb2Z0OmF6dXJlOm1lZGlhc2VydmljZXM6bWF4dXNlcyI6IjUiLCJuYmYiOjE2NjE2OTA3MjMsImV4cCI6MTY2MTY5MTYyMywiaXNzIjoiaUJlaW5uaUlzc3VlciIsImF1ZCI6ImlCZWlubmlBdWRpZW5jZSJ9.IQ1hplAANtdGtC7scL6zzRzh7UBQPHr37qkCrQOuiTw";
            TokenHidden = $"Bearer={token}";
        }
    }
}