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

namespace Algolia.Search.Models.Analytics;

/// <summary>
/// TopHitsResponse
/// </summary>
public partial class TopHitsResponse
{
  /// <summary>
  /// Initializes a new instance of the TopHitsResponse class.
  /// </summary>
  [JsonConstructor]
  public TopHitsResponse() { }
  /// <summary>
  /// Initializes a new instance of the TopHitsResponse class.
  /// </summary>
  /// <param name="hits">Top hits. (required).</param>
  public TopHitsResponse(List<TopHit> hits)
  {
    Hits = hits ?? throw new ArgumentNullException(nameof(hits));
  }

  /// <summary>
  /// Top hits.
  /// </summary>
  /// <value>Top hits.</value>
  [JsonPropertyName("hits")]
  public List<TopHit> Hits { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class TopHitsResponse {\n");
    sb.Append("  Hits: ").Append(Hits).Append("\n");
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
    if (obj is not TopHitsResponse input)
    {
      return false;
    }

    return
        (Hits == input.Hits || Hits != null && input.Hits != null && Hits.SequenceEqual(input.Hits));
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
      if (Hits != null)
      {
        hashCode = (hashCode * 59) + Hits.GetHashCode();
      }
      return hashCode;
    }
  }

}

