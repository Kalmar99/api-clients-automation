// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
// ignore_for_file: unused_element
import 'package:algolia_client_search/src/model/mode.dart';
import 'package:algolia_client_search/src/model/rendering_content.dart';
import 'package:algolia_client_search/src/model/index_settings_as_search_params_semantic_search.dart';
import 'package:algolia_client_search/src/model/alternatives_as_exact.dart';
import 'package:algolia_client_search/src/model/exact_on_single_word_query.dart';
import 'package:algolia_client_search/src/model/search_type_default.dart';
import 'package:algolia_client_search/src/model/remove_words_if_no_results.dart';
import 'package:algolia_client_search/src/model/advanced_syntax_features.dart';
import 'package:algolia_client_search/src/model/query_type.dart';

import 'package:json_annotation/json_annotation.dart';

part 'search_for_hits.g.dart';

@JsonSerializable()
final class SearchForHits {
  /// Returns a new [SearchForHits] instance.
  const SearchForHits({
    this.params,
    this.query,
    this.similarQuery,
    this.filters,
    this.facetFilters,
    this.optionalFilters,
    this.numericFilters,
    this.tagFilters,
    this.sumOrFiltersScores,
    this.facets,
    this.maxValuesPerFacet,
    this.facetingAfterDistinct,
    this.sortFacetValuesBy,
    this.page,
    this.offset,
    this.length,
    this.aroundLatLng,
    this.aroundLatLngViaIP,
    this.aroundRadius,
    this.aroundPrecision,
    this.minimumAroundRadius,
    this.insideBoundingBox,
    this.insidePolygon,
    this.naturalLanguages,
    this.ruleContexts,
    this.personalizationImpact,
    this.userToken,
    this.getRankingInfo,
    this.clickAnalytics,
    this.analytics,
    this.analyticsTags,
    this.percentileComputation,
    this.enableABTest,
    this.enableReRanking,
    this.reRankingApplyFilter,
    this.attributesForFaceting,
    this.attributesToRetrieve,
    this.restrictSearchableAttributes,
    this.ranking,
    this.customRanking,
    this.relevancyStrictness,
    this.attributesToHighlight,
    this.attributesToSnippet,
    this.highlightPreTag,
    this.highlightPostTag,
    this.snippetEllipsisText,
    this.restrictHighlightAndSnippetArrays,
    this.hitsPerPage,
    this.minWordSizefor1Typo,
    this.minWordSizefor2Typos,
    this.typoTolerance,
    this.allowTyposOnNumericTokens,
    this.disableTypoToleranceOnAttributes,
    this.ignorePlurals,
    this.removeStopWords,
    this.keepDiacriticsOnCharacters,
    this.queryLanguages,
    this.decompoundQuery,
    this.enableRules,
    this.enablePersonalization,
    this.queryType,
    this.removeWordsIfNoResults,
    this.mode,
    this.semanticSearch,
    this.advancedSyntax,
    this.optionalWords,
    this.disableExactOnAttributes,
    this.exactOnSingleWordQuery,
    this.alternativesAsExact,
    this.advancedSyntaxFeatures,
    this.explain,
    this.distinct,
    this.attributeForDistinct,
    this.synonyms,
    this.replaceSynonymsInHighlight,
    this.minProximity,
    this.responseFields,
    this.maxFacetHits,
    this.attributeCriteriaComputedByMinProximity,
    this.renderingContent,
    required this.indexName,
    this.type,
  });

  /// Search parameters as a URL-encoded query string.
  @JsonKey(name: r'params')
  final String? params;

  /// Text to search for in an index.
  @JsonKey(name: r'query')
  final String? query;

  /// Overrides the query parameter and performs a more generic search.
  @JsonKey(name: r'similarQuery')
  final String? similarQuery;

  /// [Filter](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/) the query with numeric, facet, or tag filters.
  @JsonKey(name: r'filters')
  final String? filters;

  @JsonKey(name: r'facetFilters')
  final dynamic facetFilters;

  @JsonKey(name: r'optionalFilters')
  final dynamic optionalFilters;

  @JsonKey(name: r'numericFilters')
  final dynamic numericFilters;

  @JsonKey(name: r'tagFilters')
  final dynamic tagFilters;

  /// Determines how to calculate [filter scores](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/in-depth/filter-scoring/#accumulating-scores-with-sumorfiltersscores). If `false`, maximum score is kept. If `true`, score is summed.
  @JsonKey(name: r'sumOrFiltersScores')
  final bool? sumOrFiltersScores;

  /// Returns [facets](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#contextual-facet-values-and-counts), their facet values, and the number of matching facet values.
  @JsonKey(name: r'facets')
  final List<String>? facets;

  /// Maximum number of facet values to return for each facet.
  @JsonKey(name: r'maxValuesPerFacet')
  final int? maxValuesPerFacet;

  /// Forces faceting to be applied after [de-duplication](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/) (with the distinct feature). Alternatively, the `afterDistinct` [modifier](https://www.algolia.com/doc/api-reference/api-parameters/attributesForFaceting/#modifiers) of `attributesForFaceting` allows for more granular control.
  @JsonKey(name: r'facetingAfterDistinct')
  final bool? facetingAfterDistinct;

  /// Controls how facet values are fetched.
  @JsonKey(name: r'sortFacetValuesBy')
  final String? sortFacetValuesBy;

  /// Page to retrieve (the first page is `0`, not `1`).
  @JsonKey(name: r'page')
  final int? page;

  /// Specifies the offset of the first hit to return. > **Note**: Using `page` and `hitsPerPage` is the recommended method for [paging results](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/). However, you can use `offset` and `length` to implement [an alternative approach to paging](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/#retrieving-a-subset-of-records-with-offset-and-length).
  @JsonKey(name: r'offset')
  final int? offset;

  /// Sets the number of hits to retrieve (for use with `offset`). > **Note**: Using `page` and `hitsPerPage` is the recommended method for [paging results](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/). However, you can use `offset` and `length` to implement [an alternative approach to paging](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js/#retrieving-a-subset-of-records-with-offset-and-length).
  // minimum: 1
  // maximum: 1000
  @JsonKey(name: r'length')
  final int? length;

  /// Search for entries [around a central location](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filter-around-a-central-point), enabling a geographical search within a circular area.
  @JsonKey(name: r'aroundLatLng')
  final String? aroundLatLng;

  /// Search for entries around a location. The location is automatically computed from the requester's IP address.
  @JsonKey(name: r'aroundLatLngViaIP')
  final bool? aroundLatLngViaIP;

  @JsonKey(name: r'aroundRadius')
  final dynamic aroundRadius;

  /// Precision of a geographical search (in meters), to [group results that are more or less the same distance from a central point](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/in-depth/geo-ranking-precision/).
  @JsonKey(name: r'aroundPrecision')
  final int? aroundPrecision;

  /// Minimum radius (in meters) used for a geographical search when `aroundRadius` isn't set.
  // minimum: 1
  @JsonKey(name: r'minimumAroundRadius')
  final int? minimumAroundRadius;

  /// Search inside a [rectangular area](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).
  @JsonKey(name: r'insideBoundingBox')
  final List<double>? insideBoundingBox;

  /// Search inside a [polygon](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).
  @JsonKey(name: r'insidePolygon')
  final List<double>? insidePolygon;

  /// Changes the default values of parameters that work best for a natural language query, such as `ignorePlurals`, `removeStopWords`, `removeWordsIfNoResults`, `analyticsTags`, and `ruleContexts`. These parameters work well together when the query consists of fuller natural language strings instead of keywords, for example when processing voice search queries.
  @JsonKey(name: r'naturalLanguages')
  final List<String>? naturalLanguages;

  /// Assigns [rule contexts](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#whats-a-context) to search queries.
  @JsonKey(name: r'ruleContexts')
  final List<String>? ruleContexts;

  /// Defines how much [Personalization affects results](https://www.algolia.com/doc/guides/personalization/personalizing-results/in-depth/configuring-personalization/#understanding-personalization-impact).
  @JsonKey(name: r'personalizationImpact')
  final int? personalizationImpact;

  /// Associates a [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/) with the current search.
  @JsonKey(name: r'userToken')
  final String? userToken;

  /// Incidates whether the search response includes [detailed ranking information](https://www.algolia.com/doc/guides/building-search-ui/going-further/backend-search/in-depth/understanding-the-api-response/#ranking-information).
  @JsonKey(name: r'getRankingInfo')
  final bool? getRankingInfo;

  /// Indicates whether a query ID parameter is included in the search response. This is required for [tracking click and conversion events](https://www.algolia.com/doc/guides/sending-events/concepts/event-types/#events-related-to-algolia-requests).
  @JsonKey(name: r'clickAnalytics')
  final bool? clickAnalytics;

  /// Indicates whether this query will be included in [analytics](https://www.algolia.com/doc/guides/search-analytics/guides/exclude-queries/).
  @JsonKey(name: r'analytics')
  final bool? analytics;

  /// Tags to apply to the query for [segmenting analytics data](https://www.algolia.com/doc/guides/search-analytics/guides/segments/).
  @JsonKey(name: r'analyticsTags')
  final List<String>? analyticsTags;

  /// Whether to include or exclude a query from the processing-time percentile computation.
  @JsonKey(name: r'percentileComputation')
  final bool? percentileComputation;

  /// Incidates whether this search will be considered in A/B testing.
  @JsonKey(name: r'enableABTest')
  final bool? enableABTest;

  /// Indicates whether this search will use [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking/).
  @JsonKey(name: r'enableReRanking')
  final bool? enableReRanking;

  @JsonKey(name: r'reRankingApplyFilter')
  final dynamic reRankingApplyFilter;

  /// Attributes used for [faceting](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/) and the [modifiers](https://www.algolia.com/doc/api-reference/api-parameters/attributesForFaceting/#modifiers) that can be applied: `filterOnly`, `searchable`, and `afterDistinct`.
  @JsonKey(name: r'attributesForFaceting')
  final List<String>? attributesForFaceting;

  /// Attributes to include in the API response. To reduce the size of your response, you can retrieve only some of the attributes. By default, the response includes all attributes.
  @JsonKey(name: r'attributesToRetrieve')
  final List<String>? attributesToRetrieve;

  /// Restricts a query to only look at a subset of your [searchable attributes](https://www.algolia.com/doc/guides/managing-results/must-do/searchable-attributes/).
  @JsonKey(name: r'restrictSearchableAttributes')
  final List<String>? restrictSearchableAttributes;

  /// Determines the order in which Algolia [returns your results](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/).
  @JsonKey(name: r'ranking')
  final List<String>? ranking;

  /// Specifies the [Custom ranking criterion](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking/). Use the `asc` and `desc` modifiers to specify the ranking order: ascending or descending.
  @JsonKey(name: r'customRanking')
  final List<String>? customRanking;

  /// Relevancy threshold below which less relevant results aren't included in the results.
  @JsonKey(name: r'relevancyStrictness')
  final int? relevancyStrictness;

  /// Attributes to highlight. Strings that match the search query in the attributes are highlighted by surrounding them with HTML tags (`highlightPreTag` and `highlightPostTag`).
  @JsonKey(name: r'attributesToHighlight')
  final List<String>? attributesToHighlight;

  /// Attributes to _snippet_. 'Snippeting' is shortening the attribute to a certain number of words. If not specified, the attribute is shortened to the 10 words around the matching string but you can specify the number. For example: `body:20`.
  @JsonKey(name: r'attributesToSnippet')
  final List<String>? attributesToSnippet;

  /// HTML string to insert before the highlighted parts in all highlight and snippet results.
  @JsonKey(name: r'highlightPreTag')
  final String? highlightPreTag;

  /// HTML string to insert after the highlighted parts in all highlight and snippet results.
  @JsonKey(name: r'highlightPostTag')
  final String? highlightPostTag;

  /// String used as an ellipsis indicator when a snippet is truncated.
  @JsonKey(name: r'snippetEllipsisText')
  final String? snippetEllipsisText;

  /// Restrict highlighting and snippeting to items that matched the query.
  @JsonKey(name: r'restrictHighlightAndSnippetArrays')
  final bool? restrictHighlightAndSnippetArrays;

  /// Number of hits per page.
  // minimum: 1
  // maximum: 1000
  @JsonKey(name: r'hitsPerPage')
  final int? hitsPerPage;

  /// Minimum number of characters a word in the query string must contain to accept matches with [one typo](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).
  @JsonKey(name: r'minWordSizefor1Typo')
  final int? minWordSizefor1Typo;

  /// Minimum number of characters a word in the query string must contain to accept matches with [two typos](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).
  @JsonKey(name: r'minWordSizefor2Typos')
  final int? minWordSizefor2Typos;

  @JsonKey(name: r'typoTolerance')
  final dynamic typoTolerance;

  /// Whether to allow typos on numbers (\"numeric tokens\") in the query string.
  @JsonKey(name: r'allowTyposOnNumericTokens')
  final bool? allowTyposOnNumericTokens;

  /// Attributes for which you want to turn off [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/).
  @JsonKey(name: r'disableTypoToleranceOnAttributes')
  final List<String>? disableTypoToleranceOnAttributes;

  @JsonKey(name: r'ignorePlurals')
  final dynamic ignorePlurals;

  @JsonKey(name: r'removeStopWords')
  final dynamic removeStopWords;

  /// Characters that the engine shouldn't automatically [normalize](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization/).
  @JsonKey(name: r'keepDiacriticsOnCharacters')
  final String? keepDiacriticsOnCharacters;

  /// Sets your user's search language. This adjusts language-specific settings and features such as `ignorePlurals`, `removeStopWords`, and [CJK](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization/#normalization-for-logogram-based-languages-cjk) word detection.
  @JsonKey(name: r'queryLanguages')
  final List<String>? queryLanguages;

  /// [Splits compound words](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#splitting-compound-words) into their component word parts in the query.
  @JsonKey(name: r'decompoundQuery')
  final bool? decompoundQuery;

  /// Incidates whether [Rules](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/) are enabled.
  @JsonKey(name: r'enableRules')
  final bool? enableRules;

  /// Incidates whether [Personalization](https://www.algolia.com/doc/guides/personalization/what-is-personalization/) is enabled.
  @JsonKey(name: r'enablePersonalization')
  final bool? enablePersonalization;

  @JsonKey(name: r'queryType')
  final QueryType? queryType;

  @JsonKey(name: r'removeWordsIfNoResults')
  final RemoveWordsIfNoResults? removeWordsIfNoResults;

  @JsonKey(name: r'mode')
  final Mode? mode;

  @JsonKey(name: r'semanticSearch')
  final IndexSettingsAsSearchParamsSemanticSearch? semanticSearch;

  /// Enables the [advanced query syntax](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/#advanced-syntax).
  @JsonKey(name: r'advancedSyntax')
  final bool? advancedSyntax;

  /// Words which should be considered [optional](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/#creating-a-list-of-optional-words) when found in a query.
  @JsonKey(name: r'optionalWords')
  final List<String>? optionalWords;

  /// Attributes for which you want to [turn off the exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes).
  @JsonKey(name: r'disableExactOnAttributes')
  final List<String>? disableExactOnAttributes;

  @JsonKey(name: r'exactOnSingleWordQuery')
  final ExactOnSingleWordQuery? exactOnSingleWordQuery;

  /// Alternatives that should be considered an exact match by [the exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes).
  @JsonKey(name: r'alternativesAsExact')
  final List<AlternativesAsExact>? alternativesAsExact;

  /// Allows you to specify which advanced syntax features are active when `advancedSyntax` is enabled.
  @JsonKey(name: r'advancedSyntaxFeatures')
  final List<AdvancedSyntaxFeatures>? advancedSyntaxFeatures;

  /// Enriches the API's response with information about how the query was processed.
  @JsonKey(name: r'explain')
  final List<String>? explain;

  @JsonKey(name: r'distinct')
  final dynamic distinct;

  /// Name of the deduplication attribute to be used with Algolia's [_distinct_ feature](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/#introducing-algolias-distinct-feature).
  @JsonKey(name: r'attributeForDistinct')
  final String? attributeForDistinct;

  /// Whether to take into account an index's synonyms for a particular search.
  @JsonKey(name: r'synonyms')
  final bool? synonyms;

  /// Whether to highlight and snippet the original word that matches the synonym or the synonym itself.
  @JsonKey(name: r'replaceSynonymsInHighlight')
  final bool? replaceSynonymsInHighlight;

  /// Precision of the [proximity ranking criterion](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#proximity).
  // minimum: 1
  // maximum: 7
  @JsonKey(name: r'minProximity')
  final int? minProximity;

  /// Attributes to include in the API response for search and browse queries.
  @JsonKey(name: r'responseFields')
  final List<String>? responseFields;

  /// Maximum number of facet hits to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).
  // maximum: 100
  @JsonKey(name: r'maxFacetHits')
  final int? maxFacetHits;

  /// When the [Attribute criterion is ranked above Proximity](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#attribute-and-proximity-combinations) in your ranking formula, Proximity is used to select which searchable attribute is matched in the Attribute ranking stage.
  @JsonKey(name: r'attributeCriteriaComputedByMinProximity')
  final bool? attributeCriteriaComputedByMinProximity;

  @JsonKey(name: r'renderingContent')
  final RenderingContent? renderingContent;

  /// Algolia index name.
  @JsonKey(name: r'indexName')
  final String indexName;

  @JsonKey(name: r'type')
  final SearchTypeDefault? type;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is SearchForHits &&
          other.params == params &&
          other.query == query &&
          other.similarQuery == similarQuery &&
          other.filters == filters &&
          other.facetFilters == facetFilters &&
          other.optionalFilters == optionalFilters &&
          other.numericFilters == numericFilters &&
          other.tagFilters == tagFilters &&
          other.sumOrFiltersScores == sumOrFiltersScores &&
          other.facets == facets &&
          other.maxValuesPerFacet == maxValuesPerFacet &&
          other.facetingAfterDistinct == facetingAfterDistinct &&
          other.sortFacetValuesBy == sortFacetValuesBy &&
          other.page == page &&
          other.offset == offset &&
          other.length == length &&
          other.aroundLatLng == aroundLatLng &&
          other.aroundLatLngViaIP == aroundLatLngViaIP &&
          other.aroundRadius == aroundRadius &&
          other.aroundPrecision == aroundPrecision &&
          other.minimumAroundRadius == minimumAroundRadius &&
          other.insideBoundingBox == insideBoundingBox &&
          other.insidePolygon == insidePolygon &&
          other.naturalLanguages == naturalLanguages &&
          other.ruleContexts == ruleContexts &&
          other.personalizationImpact == personalizationImpact &&
          other.userToken == userToken &&
          other.getRankingInfo == getRankingInfo &&
          other.clickAnalytics == clickAnalytics &&
          other.analytics == analytics &&
          other.analyticsTags == analyticsTags &&
          other.percentileComputation == percentileComputation &&
          other.enableABTest == enableABTest &&
          other.enableReRanking == enableReRanking &&
          other.reRankingApplyFilter == reRankingApplyFilter &&
          other.attributesForFaceting == attributesForFaceting &&
          other.attributesToRetrieve == attributesToRetrieve &&
          other.restrictSearchableAttributes == restrictSearchableAttributes &&
          other.ranking == ranking &&
          other.customRanking == customRanking &&
          other.relevancyStrictness == relevancyStrictness &&
          other.attributesToHighlight == attributesToHighlight &&
          other.attributesToSnippet == attributesToSnippet &&
          other.highlightPreTag == highlightPreTag &&
          other.highlightPostTag == highlightPostTag &&
          other.snippetEllipsisText == snippetEllipsisText &&
          other.restrictHighlightAndSnippetArrays ==
              restrictHighlightAndSnippetArrays &&
          other.hitsPerPage == hitsPerPage &&
          other.minWordSizefor1Typo == minWordSizefor1Typo &&
          other.minWordSizefor2Typos == minWordSizefor2Typos &&
          other.typoTolerance == typoTolerance &&
          other.allowTyposOnNumericTokens == allowTyposOnNumericTokens &&
          other.disableTypoToleranceOnAttributes ==
              disableTypoToleranceOnAttributes &&
          other.ignorePlurals == ignorePlurals &&
          other.removeStopWords == removeStopWords &&
          other.keepDiacriticsOnCharacters == keepDiacriticsOnCharacters &&
          other.queryLanguages == queryLanguages &&
          other.decompoundQuery == decompoundQuery &&
          other.enableRules == enableRules &&
          other.enablePersonalization == enablePersonalization &&
          other.queryType == queryType &&
          other.removeWordsIfNoResults == removeWordsIfNoResults &&
          other.mode == mode &&
          other.semanticSearch == semanticSearch &&
          other.advancedSyntax == advancedSyntax &&
          other.optionalWords == optionalWords &&
          other.disableExactOnAttributes == disableExactOnAttributes &&
          other.exactOnSingleWordQuery == exactOnSingleWordQuery &&
          other.alternativesAsExact == alternativesAsExact &&
          other.advancedSyntaxFeatures == advancedSyntaxFeatures &&
          other.explain == explain &&
          other.distinct == distinct &&
          other.attributeForDistinct == attributeForDistinct &&
          other.synonyms == synonyms &&
          other.replaceSynonymsInHighlight == replaceSynonymsInHighlight &&
          other.minProximity == minProximity &&
          other.responseFields == responseFields &&
          other.maxFacetHits == maxFacetHits &&
          other.attributeCriteriaComputedByMinProximity ==
              attributeCriteriaComputedByMinProximity &&
          other.renderingContent == renderingContent &&
          other.indexName == indexName &&
          other.type == type;

  @override
  int get hashCode =>
      params.hashCode +
      query.hashCode +
      similarQuery.hashCode +
      filters.hashCode +
      facetFilters.hashCode +
      optionalFilters.hashCode +
      numericFilters.hashCode +
      tagFilters.hashCode +
      sumOrFiltersScores.hashCode +
      facets.hashCode +
      maxValuesPerFacet.hashCode +
      facetingAfterDistinct.hashCode +
      sortFacetValuesBy.hashCode +
      page.hashCode +
      offset.hashCode +
      length.hashCode +
      aroundLatLng.hashCode +
      aroundLatLngViaIP.hashCode +
      aroundRadius.hashCode +
      aroundPrecision.hashCode +
      minimumAroundRadius.hashCode +
      insideBoundingBox.hashCode +
      insidePolygon.hashCode +
      naturalLanguages.hashCode +
      ruleContexts.hashCode +
      personalizationImpact.hashCode +
      userToken.hashCode +
      getRankingInfo.hashCode +
      clickAnalytics.hashCode +
      analytics.hashCode +
      analyticsTags.hashCode +
      percentileComputation.hashCode +
      enableABTest.hashCode +
      enableReRanking.hashCode +
      (reRankingApplyFilter == null ? 0 : reRankingApplyFilter.hashCode) +
      attributesForFaceting.hashCode +
      attributesToRetrieve.hashCode +
      restrictSearchableAttributes.hashCode +
      ranking.hashCode +
      customRanking.hashCode +
      relevancyStrictness.hashCode +
      attributesToHighlight.hashCode +
      attributesToSnippet.hashCode +
      highlightPreTag.hashCode +
      highlightPostTag.hashCode +
      snippetEllipsisText.hashCode +
      restrictHighlightAndSnippetArrays.hashCode +
      hitsPerPage.hashCode +
      minWordSizefor1Typo.hashCode +
      minWordSizefor2Typos.hashCode +
      typoTolerance.hashCode +
      allowTyposOnNumericTokens.hashCode +
      disableTypoToleranceOnAttributes.hashCode +
      ignorePlurals.hashCode +
      removeStopWords.hashCode +
      keepDiacriticsOnCharacters.hashCode +
      queryLanguages.hashCode +
      decompoundQuery.hashCode +
      enableRules.hashCode +
      enablePersonalization.hashCode +
      queryType.hashCode +
      removeWordsIfNoResults.hashCode +
      mode.hashCode +
      semanticSearch.hashCode +
      advancedSyntax.hashCode +
      optionalWords.hashCode +
      disableExactOnAttributes.hashCode +
      exactOnSingleWordQuery.hashCode +
      alternativesAsExact.hashCode +
      advancedSyntaxFeatures.hashCode +
      explain.hashCode +
      distinct.hashCode +
      attributeForDistinct.hashCode +
      synonyms.hashCode +
      replaceSynonymsInHighlight.hashCode +
      minProximity.hashCode +
      responseFields.hashCode +
      maxFacetHits.hashCode +
      attributeCriteriaComputedByMinProximity.hashCode +
      renderingContent.hashCode +
      indexName.hashCode +
      type.hashCode;

  factory SearchForHits.fromJson(Map<String, dynamic> json) =>
      _$SearchForHitsFromJson(json);

  Map<String, dynamic> toJson() => _$SearchForHitsToJson(this);

  @override
  String toString() {
    return toJson().toString();
  }
}
