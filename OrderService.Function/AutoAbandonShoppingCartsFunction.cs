using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using OrderService.Function.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace OrderService.Function
{
    public class AutoAbandonShoppingCartsFunction
    {
        //job fire every week on Sunday @ 8:05
        [FunctionName("AutoAbandonShoppingCarts")]
        public void Run([TimerTrigger("5 8 * * 0")] TimerInfo myTimer, ILogger log)
        //public void Run([TimerTrigger("*/1 * * * *")] TimerInfo myTimer, ILogger log)
        {
            log.LogDebug($"Auto AbandonShoppingCarts trigger function executed at: {DateTime.Now}");

            var client = new HttpClient();

            var response = client.GetAsync(ApiConstant.autoabandonshoppingcarts).Result;

            var content = response.Content.ReadAsStringAsync().Result;

            log.LogDebug($"Auto AbandonShoppingCarts trigger function completed at: {DateTime.Now} with the following message {content.ToString()} ");
        }
    }
}