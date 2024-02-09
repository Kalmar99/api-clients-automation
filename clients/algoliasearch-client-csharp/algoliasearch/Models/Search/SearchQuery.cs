//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Algolia.Search.Models;
using Algolia.Search.Models.Common;
using Algolia.Search.Serializer;

namespace Algolia.Search.Models.Search;

/// <summary>
/// SearchQuery
/// </summary>
[JsonConverter(typeof(SearchQueryJsonConverter))]
[DataContract(Name = "SearchQuery")]
public partial class SearchQuery : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the SearchQuery class
  /// with a SearchForFacets
  /// </summary>
  /// <param name="actualInstance">An instance of SearchForFacets.</param>
  public SearchQuery(SearchForFacets actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the SearchQuery class
  /// with a SearchForHits
  /// </summary>
  /// <param name="actualInstance">An instance of SearchForHits.</param>
  public SearchQuery(SearchForHits actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }


  /// <summary>
  /// Gets or Sets ActualInstance
  /// </summary>
  public sealed override object ActualInstance { get; set; }

  /// <summary>
  /// Get the actual instance of `SearchForFacets`. If the actual instance is not `SearchForFacets`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of SearchForFacets</returns>
  public SearchForFacets AsSearchForFacets()
  {
    return (SearchForFacets)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `SearchForHits`. If the actual instance is not `SearchForHits`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of SearchForHits</returns>
  public SearchForHits AsSearchForHits()
  {
    return (SearchForHits)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `SearchForFacets` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsSearchForFacets()
  {
    return ActualInstance.GetType() == typeof(SearchForFacets);
  }

  /// <summary>
  /// Check if the actual instance is of `SearchForHits` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsSearchForHits()
  {
    return ActualInstance.GetType() == typeof(SearchForHits);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class SearchQuery {\n");
    sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public override string ToJson()
  {
    return JsonConvert.SerializeObject(ActualInstance, JsonConfig.AlgoliaJsonSerializerSettings);
  }

  /// <summary>
  /// Converts the JSON string into an instance of SearchQuery
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of SearchQuery</returns>
  public static SearchQuery FromJson(string jsonString)
  {
    var jToken = JToken.Parse(jsonString);
    if (jToken.Type == JTokenType.Object && jToken["facet"] != null && jToken["type"] != null)
    {
      try
      {
        return new SearchQuery(JsonConvert.DeserializeObject<SearchForFacets>(jsonString, JsonConfig.AlgoliaJsonSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into SearchForFacets: {exception}");
      }
    }
    if (jToken.Type == JTokenType.Object)
    {
      try
      {
        return new SearchQuery(JsonConvert.DeserializeObject<SearchForHits>(jsonString, JsonConfig.AlgoliaJsonSerializerSettings));
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into SearchForHits: {exception}");
      }
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for SearchQuery
/// </summary>
public class SearchQueryJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)value?.GetType().GetMethod("ToJson")?.Invoke(value, null));
  }

  /// <summary>
  /// To convert a JSON string into an object
  /// </summary>
  /// <param name="reader">JSON reader</param>
  /// <param name="objectType">Object type</param>
  /// <param name="existingValue">Existing value</param>
  /// <param name="serializer">JSON Serializer</param>
  /// <returns>The object converted from the JSON string</returns>
  public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
  {
    if (reader.TokenType != JsonToken.Null)
    {
      return objectType.GetMethod("FromJson")?.Invoke(null, new object[] { JToken.Load(reader).ToString(Formatting.None) });
    }
    return null;
  }

  /// <summary>
  /// Check if the object can be converted
  /// </summary>
  /// <param name="objectType">Object type</param>
  /// <returns>True if the object can be converted</returns>
  public override bool CanConvert(Type objectType)
  {
    return false;
  }
}

