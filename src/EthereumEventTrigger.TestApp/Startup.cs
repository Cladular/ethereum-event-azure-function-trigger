using EthereumEventTrigger.Extension;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: WebJobsStartup(typeof(EthereumEventTrigger.TestApp.Startup))]

namespace EthereumEventTrigger.TestApp
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<EtheremEventConfigProvider>();
        }
    }
}
