using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using OrderService.Function.Constant;
using System;
using System.Net.Http;


namespace OrderService.Function
{
    public class AutoSubmitOrdersFunction
    {
        [FunctionName("AutoSubmitOrders")]
        public void Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger log)
        {
            log.LogDebug($"Auto SubmitOrders trigger function executed at: {DateTime.Now}");

            var client = new HttpClient();

            var response = client.GetAsync(ApiConstant.autosubmitorders).Result;

            var content = response.Content.ReadAsStringAsync().Result;

            log.LogDebug($"Auto SubmitOrders trigger function completed at: {DateTime.Now} with the following message {content.ToString()} ");
        }
    }
}