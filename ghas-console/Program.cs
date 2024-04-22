// See https://aka.ms/new-console-template for more information
using Azure.Core;
using Azure.Security.KeyVault.Secrets;

Console.WriteLine("Hello, World!");

const string secret="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"

SecretClientOptions options = new()
{
    Retry =
    {
        Delay = TimeSpan.FromSeconds(2),
        MaxRetries = 10,
        Mode = RetryMode.Fixed
    }
};
