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
/// Defines the ordering of facets (widgets).
/// </summary>
public partial class FacetOrdering
{
  /// <summary>
  /// Initializes a new instance of the FacetOrdering class.
  /// </summary>
  public FacetOrdering()
  {
  }

  /// <summary>
  /// Gets or Sets Facets
  /// </summary>
  [JsonPropertyName("facets")]
  public Facets Facets { get; set; }

  /// <summary>
  /// Ordering of facet values within an individual facet.
  /// </summary>
  /// <value>Ordering of facet values within an individual facet.</value>
  [JsonPropertyName("values")]
  public Dictionary<string, Value> Values { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class FacetOrdering {\n");
    sb.Append("  Facets: ").Append(Facets).Append("\n");
    sb.Append("  Values: ").Append(Values).Append("\n");
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
    if (obj is not FacetOrdering input)
    {
      return false;
    }

    return
        (Facets == input.Facets || (Facets != null && Facets.Equals(input.Facets))) &&
        (Values == input.Values || Values != null && input.Values != null && Values.SequenceEqual(input.Values));
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
      if (Facets != null)
      {
        hashCode = (hashCode * 59) + Facets.GetHashCode();
      }
      if (Values != null)
      {
        hashCode = (hashCode * 59) + Values.GetHashCode();
      }
      return hashCode;
    }
  }

}

