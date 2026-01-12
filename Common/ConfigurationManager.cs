using System.Configuration;

namespace Common;

public static class ConfigurationManager
{
    public static string GetConnectionString(string name)
    {
        var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[name]?.ConnectionString;
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ConfigurationErrorsException($"Connection string '{name}' not found in App.config.");
        }

        return connectionString;
    }
}