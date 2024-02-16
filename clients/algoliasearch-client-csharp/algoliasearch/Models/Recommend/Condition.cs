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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// Condition
/// </summary>
public partial class Condition
{

  /// <summary>
  /// Gets or Sets Anchoring
  /// </summary>
  [JsonPropertyName("anchoring")]
  public Anchoring? Anchoring { get; set; }
  /// <summary>
  /// Initializes a new instance of the Condition class.
  /// </summary>
  public Condition()
  {
  }

  /// <summary>
  /// Query pattern syntax.
  /// </summary>
  /// <value>Query pattern syntax.</value>
  [JsonPropertyName("pattern")]
  public string Pattern { get; set; }

  /// <summary>
  /// Whether the pattern matches on plurals, synonyms, and typos.
  /// </summary>
  /// <value>Whether the pattern matches on plurals, synonyms, and typos.</value>
  [JsonPropertyName("alternatives")]
  public bool? Alternatives { get; set; }

  /// <summary>
  /// Rule context format: [A-Za-z0-9_-]+).
  /// </summary>
  /// <value>Rule context format: [A-Za-z0-9_-]+).</value>
  [JsonPropertyName("context")]
  public string Context { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class Condition {\n");
    sb.Append("  Pattern: ").Append(Pattern).Append("\n");
    sb.Append("  Anchoring: ").Append(Anchoring).Append("\n");
    sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
    sb.Append("  Context: ").Append(Context).Append("\n");
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
    if (obj is not Condition input)
    {
      return false;
    }

    return
        (Pattern == input.Pattern || (Pattern != null && Pattern.Equals(input.Pattern))) &&
        (Anchoring == input.Anchoring || Anchoring.Equals(input.Anchoring)) &&
        (Alternatives == input.Alternatives || Alternatives.Equals(input.Alternatives)) &&
        (Context == input.Context || (Context != null && Context.Equals(input.Context)));
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
      if (Pattern != null)
      {
        hashCode = (hashCode * 59) + Pattern.GetHashCode();
      }
      hashCode = (hashCode * 59) + Anchoring.GetHashCode();
      hashCode = (hashCode * 59) + Alternatives.GetHashCode();
      if (Context != null)
      {
        hashCode = (hashCode * 59) + Context.GetHashCode();
      }
      return hashCode;
    }
  }

}

