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
/// BaseSearchParams
/// </summary>
public partial class BaseSearchParams
{
  /// <summary>
  /// Initializes a new instance of the BaseSearchParams class.
  /// </summary>
  public BaseSearchParams()
  {
  }

  /// <summary>
  /// Text to search for in an index.
  /// </summary>
  /// <value>Text to search for in an index.</value>
  [JsonPropertyName("query")]
  public string Query { get; set; }

  /// <summary>
  /// Overrides the query parameter and performs a more generic search.
  /// </summary>
  /// <value>Overrides the query parameter and performs a more generic search.</value>
  [JsonPropertyName("similarQuery")]
  public string SimilarQuery { get; set; }

  /// <summary>
  /// [Filter](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/) the query with numeric, facet, or tag filters. 
  /// </summary>
  /// <value>[Filter](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/) the query with numeric, facet, or tag filters. </value>
  [JsonPropertyName("filters")]
  public string Filters { get; set; }

  /// <summary>
  /// Gets or Sets FacetFilters
  /// </summary>
  [JsonPropertyName("facetFilters")]
  public FacetFilters FacetFilters { get; set; }

  /// <summary>
  /// Gets or Sets OptionalFilters
  /// </summary>
  [JsonPropertyName("optionalFilters")]
  public OptionalFilters OptionalFilters { get; set; }

  /// <summary>
  /// Gets or Sets NumericFilters
  /// </summary>
  [JsonPropertyName("numericFilters")]
  public NumericFilters NumericFilters { get; set; }

  /// <summary>
  /// Gets or Sets TagFilters
  /// </summary>
  [JsonPropertyName("tagFilters")]
  public TagFilters TagFilters { get; set; }

  /// <summary>
  /// Determines how to calculate [filter scores](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/in-depth/filter-scoring/#accumulating-scores-with-sumorfiltersscores). If `false`, maximum score is kept. If `true`, score is summed. 
  /// </summary>
  /// <value>Determines how to calculate [filter scores](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/in-depth/filter-scoring/#accumulating-scores-with-sumorfiltersscores). If `false`, maximum score is kept. If `true`, score is summed. </value>
  [JsonPropertyName("sumOrFiltersScores")]
  public bool? SumOrFiltersScores { get; set; }

  /// <summary>
  /// Restricts a query to only look at a subset of your [searchable attributes](https://www.algolia.com/doc/guides/managing-results/must-do/searchable-attributes/).
  /// </summary>
  /// <value>Restricts a query to only look at a subset of your [searchable attributes](https://www.algolia.com/doc/guides/managing-results/must-do/searchable-attributes/).</value>
  [JsonPropertyName("restrictSearchableAttributes")]
  public List<string> RestrictSearchableAttributes { get; set; }

  /// <summary>
  /// Returns [facets](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#contextual-facet-values-and-counts), their facet values, and the number of matching facet values.
  /// </summary>
  /// <value>Returns [facets](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#contextual-facet-values-and-counts), their facet values, and the number of matching facet values.</value>
  [JsonPropertyName("facets")]
  public List<string> Facets { get; set; }

  /// <summary>
  /// Forces faceting to be applied after [de-duplication](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/) (with the distinct feature). Alternatively, the `afterDistinct` [modifier](https://www.algolia.com/doc/api-reference/api-parameters/attributesForFaceting/#modifiers) of `attributesForFaceting` allows for more granular control. 
  /// </summary>
  /// <value>Forces faceting to be applied after [de-duplication](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/) (with the distinct feature). Alternatively, the `afterDistinct` [modifier](https://www.algolia.com/doc/api-reference/api-parameters/attributesForFaceting/#modifiers) of `attributesForFaceting` allows for more granular control. </value>
  [JsonPropertyName("facetingAfterDistinct")]
  public bool? FacetingAfterDistinct { get; set; }

  /// <summary>
  /// Page to retrieve (the first page is `0`, not `1`).
  /// </summary>
  /// <value>Page to retrieve (the first page is `0`, not `1`).</value>
  [JsonPropertyName("page")]
  public int? Page { get; set; }

  /// <summary>
  /// Specifies the offset of the first hit to return. > **Note**: Using `page` and `hitsPerPage` is the recommended method for [paging results](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/). However, you can use `offset` and `length` to implement [an alternative approach to paging](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/#retrieving-a-subset-of-records-with-offset-and-length). 
  /// </summary>
  /// <value>Specifies the offset of the first hit to return. > **Note**: Using `page` and `hitsPerPage` is the recommended method for [paging results](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/). However, you can use `offset` and `length` to implement [an alternative approach to paging](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/#retrieving-a-subset-of-records-with-offset-and-length). </value>
  [JsonPropertyName("offset")]
  public int? Offset { get; set; }

  /// <summary>
  /// Sets the number of hits to retrieve (for use with `offset`). > **Note**: Using `page` and `hitsPerPage` is the recommended method for [paging results](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/). However, you can use `offset` and `length` to implement [an alternative approach to paging](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/#retrieving-a-subset-of-records-with-offset-and-length). 
  /// </summary>
  /// <value>Sets the number of hits to retrieve (for use with `offset`). > **Note**: Using `page` and `hitsPerPage` is the recommended method for [paging results](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/). However, you can use `offset` and `length` to implement [an alternative approach to paging](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/#retrieving-a-subset-of-records-with-offset-and-length). </value>
  [JsonPropertyName("length")]
  public int? Length { get; set; }

  /// <summary>
  /// Search for entries [around a central location](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filter-around-a-central-point), enabling a geographical search within a circular area.
  /// </summary>
  /// <value>Search for entries [around a central location](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filter-around-a-central-point), enabling a geographical search within a circular area.</value>
  [JsonPropertyName("aroundLatLng")]
  public string AroundLatLng { get; set; }

  /// <summary>
  /// Search for entries around a location. The location is automatically computed from the requester's IP address.
  /// </summary>
  /// <value>Search for entries around a location. The location is automatically computed from the requester's IP address.</value>
  [JsonPropertyName("aroundLatLngViaIP")]
  public bool? AroundLatLngViaIP { get; set; }

  /// <summary>
  /// Gets or Sets AroundRadius
  /// </summary>
  [JsonPropertyName("aroundRadius")]
  public AroundRadius AroundRadius { get; set; }

  /// <summary>
  /// Gets or Sets AroundPrecision
  /// </summary>
  [JsonPropertyName("aroundPrecision")]
  public AroundPrecision AroundPrecision { get; set; }

  /// <summary>
  /// Minimum radius (in meters) used for a geographical search when `aroundRadius` isn't set.
  /// </summary>
  /// <value>Minimum radius (in meters) used for a geographical search when `aroundRadius` isn't set.</value>
  [JsonPropertyName("minimumAroundRadius")]
  public int? MinimumAroundRadius { get; set; }

  /// <summary>
  /// Search inside a [rectangular area](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).
  /// </summary>
  /// <value>Search inside a [rectangular area](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).</value>
  [JsonPropertyName("insideBoundingBox")]
  public List<List<double>> InsideBoundingBox { get; set; }

  /// <summary>
  /// Search inside a [polygon](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).
  /// </summary>
  /// <value>Search inside a [polygon](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).</value>
  [JsonPropertyName("insidePolygon")]
  public List<List<double>> InsidePolygon { get; set; }

  /// <summary>
  /// Changes the default values of parameters that work best for a natural language query, such as `ignorePlurals`, `removeStopWords`, `removeWordsIfNoResults`, `analyticsTags`, and `ruleContexts`. These parameters work well together when the query consists of fuller natural language strings instead of keywords, for example when processing voice search queries.
  /// </summary>
  /// <value>Changes the default values of parameters that work best for a natural language query, such as `ignorePlurals`, `removeStopWords`, `removeWordsIfNoResults`, `analyticsTags`, and `ruleContexts`. These parameters work well together when the query consists of fuller natural language strings instead of keywords, for example when processing voice search queries.</value>
  [JsonPropertyName("naturalLanguages")]
  public List<string> NaturalLanguages { get; set; }

  /// <summary>
  /// Assigns [rule contexts](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#whats-a-context) to search queries.
  /// </summary>
  /// <value>Assigns [rule contexts](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#whats-a-context) to search queries.</value>
  [JsonPropertyName("ruleContexts")]
  public List<string> RuleContexts { get; set; }

  /// <summary>
  /// Defines how much [Personalization affects results](https://www.algolia.com/doc/guides/personalization/personalizing-results/in-depth/configuring-personalization/#understanding-personalization-impact).
  /// </summary>
  /// <value>Defines how much [Personalization affects results](https://www.algolia.com/doc/guides/personalization/personalizing-results/in-depth/configuring-personalization/#understanding-personalization-impact).</value>
  [JsonPropertyName("personalizationImpact")]
  public int? PersonalizationImpact { get; set; }

  /// <summary>
  /// Associates a [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/) with the current search.
  /// </summary>
  /// <value>Associates a [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/) with the current search.</value>
  [JsonPropertyName("userToken")]
  public string UserToken { get; set; }

  /// <summary>
  /// Incidates whether the search response includes [detailed ranking information](https://www.algolia.com/doc/guides/building-search-ui/going-further/backend-search/in-depth/understanding-the-api-response/#ranking-information).
  /// </summary>
  /// <value>Incidates whether the search response includes [detailed ranking information](https://www.algolia.com/doc/guides/building-search-ui/going-further/backend-search/in-depth/understanding-the-api-response/#ranking-information).</value>
  [JsonPropertyName("getRankingInfo")]
  public bool? GetRankingInfo { get; set; }

  /// <summary>
  /// Enriches the API's response with information about how the query was processed.
  /// </summary>
  /// <value>Enriches the API's response with information about how the query was processed.</value>
  [JsonPropertyName("explain")]
  public List<string> Explain { get; set; }

  /// <summary>
  /// Whether to take into account an index's synonyms for a particular search.
  /// </summary>
  /// <value>Whether to take into account an index's synonyms for a particular search.</value>
  [JsonPropertyName("synonyms")]
  public bool? Synonyms { get; set; }

  /// <summary>
  /// Indicates whether a query ID parameter is included in the search response. This is required for [tracking click and conversion events](https://www.algolia.com/doc/guides/sending-events/concepts/event-types/#events-related-to-algolia-requests).
  /// </summary>
  /// <value>Indicates whether a query ID parameter is included in the search response. This is required for [tracking click and conversion events](https://www.algolia.com/doc/guides/sending-events/concepts/event-types/#events-related-to-algolia-requests).</value>
  [JsonPropertyName("clickAnalytics")]
  public bool? ClickAnalytics { get; set; }

  /// <summary>
  /// Indicates whether this query will be included in [analytics](https://www.algolia.com/doc/guides/search-analytics/guides/exclude-queries/).
  /// </summary>
  /// <value>Indicates whether this query will be included in [analytics](https://www.algolia.com/doc/guides/search-analytics/guides/exclude-queries/).</value>
  [JsonPropertyName("analytics")]
  public bool? Analytics { get; set; }

  /// <summary>
  /// Tags to apply to the query for [segmenting analytics data](https://www.algolia.com/doc/guides/search-analytics/guides/segments/).
  /// </summary>
  /// <value>Tags to apply to the query for [segmenting analytics data](https://www.algolia.com/doc/guides/search-analytics/guides/segments/).</value>
  [JsonPropertyName("analyticsTags")]
  public List<string> AnalyticsTags { get; set; }

  /// <summary>
  /// Whether to include or exclude a query from the processing-time percentile computation.
  /// </summary>
  /// <value>Whether to include or exclude a query from the processing-time percentile computation.</value>
  [JsonPropertyName("percentileComputation")]
  public bool? PercentileComputation { get; set; }

  /// <summary>
  /// Incidates whether this search will be considered in A/B testing.
  /// </summary>
  /// <value>Incidates whether this search will be considered in A/B testing.</value>
  [JsonPropertyName("enableABTest")]
  public bool? EnableABTest { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class BaseSearchParams {\n");
    sb.Append("  Query: ").Append(Query).Append("\n");
    sb.Append("  SimilarQuery: ").Append(SimilarQuery).Append("\n");
    sb.Append("  Filters: ").Append(Filters).Append("\n");
    sb.Append("  FacetFilters: ").Append(FacetFilters).Append("\n");
    sb.Append("  OptionalFilters: ").Append(OptionalFilters).Append("\n");
    sb.Append("  NumericFilters: ").Append(NumericFilters).Append("\n");
    sb.Append("  TagFilters: ").Append(TagFilters).Append("\n");
    sb.Append("  SumOrFiltersScores: ").Append(SumOrFiltersScores).Append("\n");
    sb.Append("  RestrictSearchableAttributes: ").Append(RestrictSearchableAttributes).Append("\n");
    sb.Append("  Facets: ").Append(Facets).Append("\n");
    sb.Append("  FacetingAfterDistinct: ").Append(FacetingAfterDistinct).Append("\n");
    sb.Append("  Page: ").Append(Page).Append("\n");
    sb.Append("  Offset: ").Append(Offset).Append("\n");
    sb.Append("  Length: ").Append(Length).Append("\n");
    sb.Append("  AroundLatLng: ").Append(AroundLatLng).Append("\n");
    sb.Append("  AroundLatLngViaIP: ").Append(AroundLatLngViaIP).Append("\n");
    sb.Append("  AroundRadius: ").Append(AroundRadius).Append("\n");
    sb.Append("  AroundPrecision: ").Append(AroundPrecision).Append("\n");
    sb.Append("  MinimumAroundRadius: ").Append(MinimumAroundRadius).Append("\n");
    sb.Append("  InsideBoundingBox: ").Append(InsideBoundingBox).Append("\n");
    sb.Append("  InsidePolygon: ").Append(InsidePolygon).Append("\n");
    sb.Append("  NaturalLanguages: ").Append(NaturalLanguages).Append("\n");
    sb.Append("  RuleContexts: ").Append(RuleContexts).Append("\n");
    sb.Append("  PersonalizationImpact: ").Append(PersonalizationImpact).Append("\n");
    sb.Append("  UserToken: ").Append(UserToken).Append("\n");
    sb.Append("  GetRankingInfo: ").Append(GetRankingInfo).Append("\n");
    sb.Append("  Explain: ").Append(Explain).Append("\n");
    sb.Append("  Synonyms: ").Append(Synonyms).Append("\n");
    sb.Append("  ClickAnalytics: ").Append(ClickAnalytics).Append("\n");
    sb.Append("  Analytics: ").Append(Analytics).Append("\n");
    sb.Append("  AnalyticsTags: ").Append(AnalyticsTags).Append("\n");
    sb.Append("  PercentileComputation: ").Append(PercentileComputation).Append("\n");
    sb.Append("  EnableABTest: ").Append(EnableABTest).Append("\n");
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
    if (obj is not BaseSearchParams input)
    {
      return false;
    }

    return
        (Query == input.Query || (Query != null && Query.Equals(input.Query))) &&
        (SimilarQuery == input.SimilarQuery || (SimilarQuery != null && SimilarQuery.Equals(input.SimilarQuery))) &&
        (Filters == input.Filters || (Filters != null && Filters.Equals(input.Filters))) &&
        (FacetFilters == input.FacetFilters || (FacetFilters != null && FacetFilters.Equals(input.FacetFilters))) &&
        (OptionalFilters == input.OptionalFilters || (OptionalFilters != null && OptionalFilters.Equals(input.OptionalFilters))) &&
        (NumericFilters == input.NumericFilters || (NumericFilters != null && NumericFilters.Equals(input.NumericFilters))) &&
        (TagFilters == input.TagFilters || (TagFilters != null && TagFilters.Equals(input.TagFilters))) &&
        (SumOrFiltersScores == input.SumOrFiltersScores || SumOrFiltersScores.Equals(input.SumOrFiltersScores)) &&
        (RestrictSearchableAttributes == input.RestrictSearchableAttributes || RestrictSearchableAttributes != null && input.RestrictSearchableAttributes != null && RestrictSearchableAttributes.SequenceEqual(input.RestrictSearchableAttributes)) &&
        (Facets == input.Facets || Facets != null && input.Facets != null && Facets.SequenceEqual(input.Facets)) &&
        (FacetingAfterDistinct == input.FacetingAfterDistinct || FacetingAfterDistinct.Equals(input.FacetingAfterDistinct)) &&
        (Page == input.Page || Page.Equals(input.Page)) &&
        (Offset == input.Offset || Offset.Equals(input.Offset)) &&
        (Length == input.Length || Length.Equals(input.Length)) &&
        (AroundLatLng == input.AroundLatLng || (AroundLatLng != null && AroundLatLng.Equals(input.AroundLatLng))) &&
        (AroundLatLngViaIP == input.AroundLatLngViaIP || AroundLatLngViaIP.Equals(input.AroundLatLngViaIP)) &&
        (AroundRadius == input.AroundRadius || (AroundRadius != null && AroundRadius.Equals(input.AroundRadius))) &&
        (AroundPrecision == input.AroundPrecision || (AroundPrecision != null && AroundPrecision.Equals(input.AroundPrecision))) &&
        (MinimumAroundRadius == input.MinimumAroundRadius || MinimumAroundRadius.Equals(input.MinimumAroundRadius)) &&
        (InsideBoundingBox == input.InsideBoundingBox || InsideBoundingBox != null && input.InsideBoundingBox != null && InsideBoundingBox.SequenceEqual(input.InsideBoundingBox)) &&
        (InsidePolygon == input.InsidePolygon || InsidePolygon != null && input.InsidePolygon != null && InsidePolygon.SequenceEqual(input.InsidePolygon)) &&
        (NaturalLanguages == input.NaturalLanguages || NaturalLanguages != null && input.NaturalLanguages != null && NaturalLanguages.SequenceEqual(input.NaturalLanguages)) &&
        (RuleContexts == input.RuleContexts || RuleContexts != null && input.RuleContexts != null && RuleContexts.SequenceEqual(input.RuleContexts)) &&
        (PersonalizationImpact == input.PersonalizationImpact || PersonalizationImpact.Equals(input.PersonalizationImpact)) &&
        (UserToken == input.UserToken || (UserToken != null && UserToken.Equals(input.UserToken))) &&
        (GetRankingInfo == input.GetRankingInfo || GetRankingInfo.Equals(input.GetRankingInfo)) &&
        (Explain == input.Explain || Explain != null && input.Explain != null && Explain.SequenceEqual(input.Explain)) &&
        (Synonyms == input.Synonyms || Synonyms.Equals(input.Synonyms)) &&
        (ClickAnalytics == input.ClickAnalytics || ClickAnalytics.Equals(input.ClickAnalytics)) &&
        (Analytics == input.Analytics || Analytics.Equals(input.Analytics)) &&
        (AnalyticsTags == input.AnalyticsTags || AnalyticsTags != null && input.AnalyticsTags != null && AnalyticsTags.SequenceEqual(input.AnalyticsTags)) &&
        (PercentileComputation == input.PercentileComputation || PercentileComputation.Equals(input.PercentileComputation)) &&
        (EnableABTest == input.EnableABTest || EnableABTest.Equals(input.EnableABTest));
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
      if (Query != null)
      {
        hashCode = (hashCode * 59) + Query.GetHashCode();
      }
      if (SimilarQuery != null)
      {
        hashCode = (hashCode * 59) + SimilarQuery.GetHashCode();
      }
      if (Filters != null)
      {
        hashCode = (hashCode * 59) + Filters.GetHashCode();
      }
      if (FacetFilters != null)
      {
        hashCode = (hashCode * 59) + FacetFilters.GetHashCode();
      }
      if (OptionalFilters != null)
      {
        hashCode = (hashCode * 59) + OptionalFilters.GetHashCode();
      }
      if (NumericFilters != null)
      {
        hashCode = (hashCode * 59) + NumericFilters.GetHashCode();
      }
      if (TagFilters != null)
      {
        hashCode = (hashCode * 59) + TagFilters.GetHashCode();
      }
      hashCode = (hashCode * 59) + SumOrFiltersScores.GetHashCode();
      if (RestrictSearchableAttributes != null)
      {
        hashCode = (hashCode * 59) + RestrictSearchableAttributes.GetHashCode();
      }
      if (Facets != null)
      {
        hashCode = (hashCode * 59) + Facets.GetHashCode();
      }
      hashCode = (hashCode * 59) + FacetingAfterDistinct.GetHashCode();
      hashCode = (hashCode * 59) + Page.GetHashCode();
      hashCode = (hashCode * 59) + Offset.GetHashCode();
      hashCode = (hashCode * 59) + Length.GetHashCode();
      if (AroundLatLng != null)
      {
        hashCode = (hashCode * 59) + AroundLatLng.GetHashCode();
      }
      hashCode = (hashCode * 59) + AroundLatLngViaIP.GetHashCode();
      if (AroundRadius != null)
      {
        hashCode = (hashCode * 59) + AroundRadius.GetHashCode();
      }
      if (AroundPrecision != null)
      {
        hashCode = (hashCode * 59) + AroundPrecision.GetHashCode();
      }
      hashCode = (hashCode * 59) + MinimumAroundRadius.GetHashCode();
      if (InsideBoundingBox != null)
      {
        hashCode = (hashCode * 59) + InsideBoundingBox.GetHashCode();
      }
      if (InsidePolygon != null)
      {
        hashCode = (hashCode * 59) + InsidePolygon.GetHashCode();
      }
      if (NaturalLanguages != null)
      {
        hashCode = (hashCode * 59) + NaturalLanguages.GetHashCode();
      }
      if (RuleContexts != null)
      {
        hashCode = (hashCode * 59) + RuleContexts.GetHashCode();
      }
      hashCode = (hashCode * 59) + PersonalizationImpact.GetHashCode();
      if (UserToken != null)
      {
        hashCode = (hashCode * 59) + UserToken.GetHashCode();
      }
      hashCode = (hashCode * 59) + GetRankingInfo.GetHashCode();
      if (Explain != null)
      {
        hashCode = (hashCode * 59) + Explain.GetHashCode();
      }
      hashCode = (hashCode * 59) + Synonyms.GetHashCode();
      hashCode = (hashCode * 59) + ClickAnalytics.GetHashCode();
      hashCode = (hashCode * 59) + Analytics.GetHashCode();
      if (AnalyticsTags != null)
      {
        hashCode = (hashCode * 59) + AnalyticsTags.GetHashCode();
      }
      hashCode = (hashCode * 59) + PercentileComputation.GetHashCode();
      hashCode = (hashCode * 59) + EnableABTest.GetHashCode();
      return hashCode;
    }
  }

}

