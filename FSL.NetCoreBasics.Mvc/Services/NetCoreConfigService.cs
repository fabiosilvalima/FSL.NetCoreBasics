using Microsoft.Extensions.Options;

namespace FSL.NetCoreBasics.Mvc.Services
{
    public sealed class NetCoreConfigService :
        IConfigService
    {
        private readonly IOptions<FslConfiguration> _config;

        public NetCoreConfigService(
            IOptions<FslConfiguration> config)
        {
            _config = config;
        }

        public FslConfiguration GetConfig()
        {
            return _config?.Value;
        }
    }
}
