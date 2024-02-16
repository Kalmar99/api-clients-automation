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

namespace Algolia.Search.Models.Search;

/// <summary>
/// HasPendingMappingsResponse
/// </summary>
public partial class HasPendingMappingsResponse
{
  /// <summary>
  /// Initializes a new instance of the HasPendingMappingsResponse class.
  /// </summary>
  [JsonConstructor]
  public HasPendingMappingsResponse() { }
  /// <summary>
  /// Initializes a new instance of the HasPendingMappingsResponse class.
  /// </summary>
  /// <param name="pending">Indicates whether there are clusters undergoing migration, creation, or deletion. (required).</param>
  public HasPendingMappingsResponse(bool pending)
  {
    Pending = pending;
  }

  /// <summary>
  /// Indicates whether there are clusters undergoing migration, creation, or deletion.
  /// </summary>
  /// <value>Indicates whether there are clusters undergoing migration, creation, or deletion.</value>
  [JsonPropertyName("pending")]
  public bool Pending { get; set; }

  /// <summary>
  /// Cluster pending mapping state: migrating, creating, deleting. 
  /// </summary>
  /// <value>Cluster pending mapping state: migrating, creating, deleting. </value>
  [JsonPropertyName("clusters")]
  public Dictionary<string, List<string>> Clusters { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class HasPendingMappingsResponse {\n");
    sb.Append("  Pending: ").Append(Pending).Append("\n");
    sb.Append("  Clusters: ").Append(Clusters).Append("\n");
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
    if (obj is not HasPendingMappingsResponse input)
    {
      return false;
    }

    return
        (Pending == input.Pending || Pending.Equals(input.Pending)) &&
        (Clusters == input.Clusters || Clusters != null && input.Clusters != null && Clusters.SequenceEqual(input.Clusters));
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
      hashCode = (hashCode * 59) + Pending.GetHashCode();
      if (Clusters != null)
      {
        hashCode = (hashCode * 59) + Clusters.GetHashCode();
      }
      return hashCode;
    }
  }

}

