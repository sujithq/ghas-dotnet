// See https://aka.ms/new-console-template for more information
using Azure.Core;
using Azure.Security.KeyVault.Secrets;

Console.WriteLine("Hello, World!");

SecretClientOptions options = new()
{
    Retry =
    {
        Delay = TimeSpan.FromSeconds(2),
        MaxRetries = 10,
        Mode = RetryMode.Fixed
    }
};


