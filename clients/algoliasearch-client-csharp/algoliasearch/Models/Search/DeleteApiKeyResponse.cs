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
/// DeleteApiKeyResponse
/// </summary>
public partial class DeleteApiKeyResponse
{
  /// <summary>
  /// Initializes a new instance of the DeleteApiKeyResponse class.
  /// </summary>
  [JsonConstructor]
  public DeleteApiKeyResponse() { }
  /// <summary>
  /// Initializes a new instance of the DeleteApiKeyResponse class.
  /// </summary>
  /// <param name="deletedAt">Timestamp of deletion in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. (required).</param>
  public DeleteApiKeyResponse(string deletedAt)
  {
    DeletedAt = deletedAt ?? throw new ArgumentNullException(nameof(deletedAt));
  }

  /// <summary>
  /// Timestamp of deletion in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
  /// </summary>
  /// <value>Timestamp of deletion in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
  [JsonPropertyName("deletedAt")]
  public string DeletedAt { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class DeleteApiKeyResponse {\n");
    sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
    if (obj is not DeleteApiKeyResponse input)
    {
      return false;
    }

    return
        (DeletedAt == input.DeletedAt || (DeletedAt != null && DeletedAt.Equals(input.DeletedAt)));
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
      if (DeletedAt != null)
      {
        hashCode = (hashCode * 59) + DeletedAt.GetHashCode();
      }
      return hashCode;
    }
  }

}

