using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace KomdekaAPI.CustomTokenProviders
{
    public class AccountActivationTokenProvider<TUser> : DataProtectorTokenProvider<TUser> where TUser : class
    {
        public AccountActivationTokenProvider(IDataProtectionProvider dataProtectionProvider,
            IOptions<AccountActivationTokenProviderOptions> options,
            ILogger<DataProtectorTokenProvider<TUser>> logger)
            : base(dataProtectionProvider, options, logger)
        {

        }
    }

    public class AccountActivationTokenProviderOptions : DataProtectionTokenProviderOptions
    {

    }
}
