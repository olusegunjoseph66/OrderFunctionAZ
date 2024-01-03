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
    public class AutoRefreshPlant
    {
        //job fire every week on Sunday @ 8:05 5 8 * * 0"
        [FunctionName("AutoRefreshPlant")]
        public void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
        //public void Run([TimerTrigger("0 0 9 * * MON")] TimerInfo myTimer, ILogger log)
        {
            log.LogDebug($"Auto Refresh Plant trigger function executed at: {DateTime.Now}");

            var client = new HttpClient();

            var response = client.GetAsync(ApiConstant.autorefreshplant).Result;

            var content = response.Content.ReadAsStringAsync().Result;

            log.LogDebug($"Auto Refresh Plant trigger function completed at: {DateTime.Now} with the following message {content.ToString()} ");
        }
    }
}
