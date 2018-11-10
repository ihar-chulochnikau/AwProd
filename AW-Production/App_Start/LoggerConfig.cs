using Serilog;

namespace AW_Production
{
    public class LoggerConfig
    {
        public static void Register()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.ApplicationInsightsEvents("a4d623cc-5b6f-4568-933f-1d66a9ada932")
                .CreateLogger();
        }
    }
}