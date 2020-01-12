using EthereumEventTrigger.Extension;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EthereumEventTrigger.TestApp
{
    public static class EthereumEventTriggeredFunction
    {
        private const string Abi = "";
        private const string ContractAddress = "";
        private const string EventName = "";

        [FunctionName(nameof(EthereumEventTriggeredFunction))]
        public static void Run([EthereumEventTrigger(abi: Abi, contractAddress: ContractAddress, eventName: EventName)]EthereumEventData eventData, ILogger logger)
        {
            string logMessage = $"Event data:\nBlock number: {eventData.BlockNumber}\n{string.Join('\n', eventData.Values.Select(value => $"{value.Key}: {value.Value}"))}";

            logger.LogInformation(logMessage);
        }
    }
}
