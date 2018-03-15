using KenticoCloud.Delivery;

namespace AmaranthvilleWeb
{
    public class KenticoCloudClient
    {
        public const string PROJECT_ID = "20630705-3b47-4951-b2fb-6d86b5457c13";

        public IDeliveryClient LanguageDeliveryClient { get; }

        public KenticoCloudClient()
        {
            var client = new DeliveryClient(PROJECT_ID);
            
            LanguageDeliveryClient = new LanguageClient(client, "en-us");
        }
    }
}