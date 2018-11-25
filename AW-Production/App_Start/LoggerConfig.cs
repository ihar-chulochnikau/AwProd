using Serilog;
using System.Configuration;

namespace AW_Production
{
    public class LoggerConfig
    {
        public static void Register()
        {
            var aureStorageCOnnectionString = ConfigurationManager.AppSettings["serilog:write-to:AzureTableStorage.connectionString"];

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.ApplicationInsightsEvents("a4d623cc-5b6f-4568-933f-1d66a9ada932")
                .WriteTo.AzureTableStorage(aureStorageCOnnectionString, Serilog.Events.LogEventLevel.Information, storageTableName: "serilog")
                .ReadFrom.AppSettings()
                .CreateLogger();
        }
    }
}