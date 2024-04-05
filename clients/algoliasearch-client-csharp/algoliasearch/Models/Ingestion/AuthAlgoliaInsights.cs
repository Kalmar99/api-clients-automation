//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Text;
using System.Linq;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Algolia.Search.Serializer;
using System.Text.Json;

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// Credentials for authenticating with the Algolia Insights API.
/// </summary>
public partial class AuthAlgoliaInsights
{
  /// <summary>
  /// Initializes a new instance of the AuthAlgoliaInsights class.
  /// </summary>
  [JsonConstructor]
  public AuthAlgoliaInsights() { }
  /// <summary>
  /// Initializes a new instance of the AuthAlgoliaInsights class.
  /// </summary>
  /// <param name="appID">Algolia application ID. (required).</param>
  /// <param name="apiKey">Algolia API key with the ACL: &#x60;search&#x60;. This field is &#x60;null&#x60; in the API response.  (required).</param>
  public AuthAlgoliaInsights(string appID, string apiKey)
  {
    AppID = appID ?? throw new ArgumentNullException(nameof(appID));
    ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
  }

  /// <summary>
  /// Algolia application ID.
  /// </summary>
  /// <value>Algolia application ID.</value>
  [JsonPropertyName("appID")]
  public string AppID { get; set; }

  /// <summary>
  /// Algolia API key with the ACL: `search`. This field is `null` in the API response. 
  /// </summary>
  /// <value>Algolia API key with the ACL: `search`. This field is `null` in the API response. </value>
  [JsonPropertyName("apiKey")]
  public string ApiKey { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class AuthAlgoliaInsights {\n");
    sb.Append("  AppID: ").Append(AppID).Append("\n");
    sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public virtual string ToJson()
  {
    return JsonSerializer.Serialize(this, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not AuthAlgoliaInsights input)
    {
      return false;
    }

    return
        (AppID == input.AppID || (AppID != null && AppID.Equals(input.AppID))) &&
        (ApiKey == input.ApiKey || (ApiKey != null && ApiKey.Equals(input.ApiKey)));
  }

  /// <summary>
  /// Gets the hash code
  /// </summary>
  /// <returns>Hash code</returns>
  public override int GetHashCode()
  {
    unchecked // Overflow is fine, just wrap
    {
      int hashCode = 41;
      if (AppID != null)
      {
        hashCode = (hashCode * 59) + AppID.GetHashCode();
      }
      if (ApiKey != null)
      {
        hashCode = (hashCode * 59) + ApiKey.GetHashCode();
      }
      return hashCode;
    }
  }

}

