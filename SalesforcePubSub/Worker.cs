using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace SalesforcePubSub;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
     
        ServiceProvider serviceProvider = new ServiceCollection()
        .AddLogging((loggingBuilder) => loggingBuilder
                .SetMinimumLevel(LogLevel.Trace)
                .AddConsole()
        )
       .BuildServiceProvider();

        var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger< Worker> ();

        logger.LogInformation("Testing Salesforce Pub/Sub API with .NET");


        Metadata metadata = new Metadata{
            { "accesstoken", "00D1a000000L72z!ASAAQBGiUBf1TnKfTrkvDL1RCqiUxQ733IoknJc0_m4KK2JKXC.GxsP3LcqGuZSJmr83sD7sIO2yTPhfecfzS_dbkcCfTT2W"},
            { "instanceurl", "https://ramkisol-dev-ed.my.salesforce.com"},
            { "tenantid", "00D1a000000L72z"}
        };

        string pubSubEndpoint = "https://api.pubsub.salesforce.com:443";
        string platformEventName = "/data/AccountChangeEvent";
        SalesforcePubSubClient salesforcePubSubClient = new SalesforcePubSubClient(pubSubEndpoint, metadata, logger);

        var topic = salesforcePubSubClient.GetTopicByName(platformEventName);
        var schema = salesforcePubSubClient.GetSchemaById(topic.SchemaId);

        while (true)
        {
            await salesforcePubSubClient.Subscribe(platformEventName, schema.SchemaJson);
        }
    }
}