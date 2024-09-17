using System.Collections.Generic;

namespace Volo.Abp.BlobStoring.Google;

public class GoogleBlobProviderConfiguration
{
    private readonly BlobContainerConfiguration _containerConfiguration;

    public GoogleBlobProviderConfiguration(BlobContainerConfiguration containerConfiguration)
    {
        _containerConfiguration = containerConfiguration;
    }
    
    /// <summary>
    /// Unique identifier for your project.
    /// For more info see: https://cloud.google.com/resource-manager/docs/creating-managing-projects
    /// </summary>
    public string? ProjectId {
        get => _containerConfiguration.GetConfigurationOrDefault<string>(GoogleBlobProviderConfigurationNames.ProjectId);
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.ProjectId, value);
    }
    
    /// <summary>
    /// Email address that generated by the Google Cloud.
    /// </summary>
    public string? ClientEmail {
        get => _containerConfiguration.GetConfigurationOrDefault<string>(GoogleBlobProviderConfigurationNames.ClientEmail);
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.ClientEmail, value);
    }
    
    /// <summary>
    /// Private key that generated by Google Cloud.
    /// Starts with '-----BEGIN PRIVATE KEY-----'
    /// and ends with '-----END PRIVATE KEY-----'
    /// </summary>
    public string? PrivateKey {
        get => _containerConfiguration.GetConfigurationOrDefault<string>(GoogleBlobProviderConfigurationNames.PrivateKey);
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.PrivateKey, value);
    }
    
    /// <summary>
    /// Available OAuth 2.0 scopes.
    /// </summary>
    public List<string>? Scopes {
        get => _containerConfiguration.GetConfigurationOrDefault(GoogleBlobProviderConfigurationNames.Scopes, new List<string>());
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.Scopes, value);
    }
    
    /// <summary>
    /// Use the application default credentials. https://cloud.google.com/docs/authentication/provide-credentials-adc
    /// Default value: false.
    /// </summary>
    public bool UseApplicationDefaultCredentials {
        get => _containerConfiguration.GetConfigurationOrDefault(GoogleBlobProviderConfigurationNames.UseApplicationDefaultCredentials, false);
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.UseApplicationDefaultCredentials, value);
    }
    
    /// <summary>
    /// The name can only contain lowercase letters, numeric characters, dashes (-), underscores (_), and dots (.). Spaces are not allowed. Names containing dots require verification.
    /// Must start and end with a number or letter.
    /// Must contain 3-63 characters. Names containing dots can contain up to 222 characters, but each dot-separated component can be no longer than 63 characters.
    /// Cannot be represented as an IP address in dotted-decimal notation (for example, 192.168.5.4).
    /// Cannot begin with the "goog" prefix.
    /// Cannot contain "google" or close misspellings, such as "g00gle".
    /// If this parameter is not specified, the ContainerName of the <see cref="BlobProviderArgs"/> will be used.
    /// </summary>
    public string? ContainerName {
        get => _containerConfiguration.GetConfigurationOrDefault<string>(GoogleBlobProviderConfigurationNames.ContainerName);
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.ContainerName, value);
    }

    /// <summary>
    /// Default value: false.
    /// </summary>
    public bool CreateContainerIfNotExists {
        get => _containerConfiguration.GetConfigurationOrDefault(GoogleBlobProviderConfigurationNames.CreateContainerIfNotExists, false);
        set => _containerConfiguration.SetConfiguration(GoogleBlobProviderConfigurationNames.CreateContainerIfNotExists, value);
    }
}