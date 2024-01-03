using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using OrderService.Function.Constant;
using System;
using System.Net.Http;


namespace OrderService.Function
{
    public class AutoRefreshOrdersFunction
    {
        //job fire every 30minutes 
        [FunctionName("AutoRefreshOrders")]
        public void Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger log)
        //public void Run([TimerTrigger("30 * * * *")] TimerInfo myTimer, ILogger log)
        {
            log.LogDebug($"Auto RefreshOrders trigger function executed at: {DateTime.Now}");

            var client = new HttpClient();

            var response = client.GetAsync(ApiConstant.autorefreshorders).Result;

            var content = response.Content.ReadAsStringAsync().Result;

            log.LogDebug($"Auto RefreshOrders trigger function completed at: {DateTime.Now} with the following message {content.ToString()} ");
        }
    }
}