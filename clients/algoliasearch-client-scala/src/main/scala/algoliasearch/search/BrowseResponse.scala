/** Search API The Algolia Search API lets you search, configure, and mange your indices and records. ## Client
  * libraries Use Algolia's API clients and libraries to reliably integrate Algolia's APIs with your apps. The official
  * API clients are covered by Algolia's [Service Level Agreement](https://www.algolia.com/policies/sla/). See:
  * [Algolia's ecosystem](https://www.algolia.com/doc/guides/getting-started/how-algolia-works/in-depth/ecosystem/) ##
  * Base URLs The base URLs for requests to the Search API are: - `https://{APPLICATION_ID}.algolia.net` -
  * `https://{APPLICATION_ID}-dsn.algolia.net`. If your subscription includes a [Distributed Search
  * Network](https://dashboard.algolia.com/infra), this ensures that requests are sent to servers closest to users. Both
  * URLs provide high availability by distributing requests with load balancing. **All requests must use HTTPS.** ##
  * Retry strategy To guarantee a high availability, implement a retry strategy for all API requests using the URLs of
  * your servers as fallbacks: - `https://{APPLICATION_ID}-1.algolianet.com` -
  * `https://{APPLICATION_ID}-2.algolianet.com` - `https://{APPLICATION_ID}-3.algolianet.com` These URLs use a different
  * DNS provider than the primary URLs. You should randomize this list to ensure an even load across the three servers.
  * All Algolia API clients implement this retry strategy. ## Authentication To authenticate your API requests, add
  * these headers: - `x-algolia-application-id`. Your Algolia application ID. - `x-algolia-api-key`. An API key with the
  * necessary permissions to make the request. The required access control list (ACL) to make a request is listed in
  * each endpoint's reference. You can find your application ID and API key in the [Algolia
  * dashboard](https://dashboard.algolia.com/account). ## Request format Depending on the endpoint, request bodies are
  * either JSON objects or arrays of JSON objects, ## Parameters Parameters are passed as query parameters for GET and
  * DELETE requests, and in the request body for POST and PUT requests. Query parameters must be
  * [URL-encoded](https://developer.mozilla.org/en-US/docs/Glossary/Percent-encoding). Non-ASCII characters must be
  * UTF-8 encoded. Plus characters (`+`) are interpreted as spaces. Arrays as query parameters must be one of: - A
  * comma-separated string: `attributesToRetrieve=title,description` - A URL-encoded JSON array:
  * `attributesToRetrieve=%5B%22title%22,%22description%22%D` ## Response status and errors The Search API returns JSON
  * responses. Since JSON doesn't guarantee any specific ordering, don't rely on the order of attributes in the API
  * response. Successful responses return a `2xx` status. Client errors return a `4xx` status. Server errors are
  * indicated by a `5xx` status. Error responses have a `message` property with more information. ## Version The current
  * version of the Search API is version 1, as indicated by the `/1/` in each endpoint's URL.
  *
  * The version of the OpenAPI document: 1.0.0
  *
  * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
  * https://openapi-generator.tech Do not edit the class manually.
  */
package algoliasearch.search

/** BrowseResponse
  *
  * @param abTestID
  *   A/B test ID. This is only included in the response for indices that are part of an A/B test.
  * @param abTestVariantID
  *   Variant ID. This is only included in the response for indices that are part of an A/B test.
  * @param aroundLatLng
  *   Computed geographical location.
  * @param automaticRadius
  *   Distance from a central coordinate provided by `aroundLatLng`.
  * @param exhaustiveFacetsCount
  *   See the `facetsCount` field of the `exhaustive` object in the response.
  * @param exhaustiveNbHits
  *   See the `nbHits` field of the `exhaustive` object in the response.
  * @param exhaustiveTypo
  *   See the `typo` field of the `exhaustive` object in the response.
  * @param facets
  *   Facet counts.
  * @param facetsStats
  *   Statistics for numerical facets.
  * @param index
  *   Index name used for the query.
  * @param indexUsed
  *   Index name used for the query. During A/B testing, the targeted index isn't always the index used by the query.
  * @param message
  *   Warnings about the query.
  * @param nbSortedHits
  *   Number of hits selected and sorted by the relevant sort algorithm.
  * @param parsedQuery
  *   Post-[normalization](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/#what-does-normalization-mean)
  *   query string that will be searched.
  * @param processingTimeMS
  *   Time the server took to process the request, in milliseconds.
  * @param processingTimingsMS
  *   Experimental. List of processing steps and their times, in milliseconds. You can use this list to investigate
  *   performance issues.
  * @param queryAfterRemoval
  *   Markup text indicating which parts of the original query have been removed to retrieve a non-empty result set.
  * @param serverTimeMS
  *   Time the server took to process the request, in milliseconds.
  * @param serverUsed
  *   Host name of the server that processed the request.
  * @param userData
  *   An object with custom data. You can store up to 32kB as custom data.
  * @param queryID
  *   Unique identifier for the query. This is used for [click
  *   analytics](https://www.algolia.com/doc/guides/analytics/click-analytics/).
  * @param page
  *   Page of search results to retrieve.
  * @param nbHits
  *   Number of results (hits).
  * @param nbPages
  *   Number of pages of results.
  * @param hitsPerPage
  *   Number of hits per page.
  * @param hits
  *   Search results (hits). Hits are records from your index that match the search criteria, augmented with additional
  *   attributes, such as, for highlighting.
  * @param query
  *   Search query.
  * @param params
  *   URL-encoded string of all search parameters.
  * @param cursor
  *   Cursor to get the next page of the response. The parameter must match the value returned in the response of a
  *   previous request. The last page of the response does not return a `cursor` attribute.
  */
case class BrowseResponse(
    abTestID: Option[Int] = scala.None,
    abTestVariantID: Option[Int] = scala.None,
    aroundLatLng: Option[String] = scala.None,
    automaticRadius: Option[String] = scala.None,
    exhaustive: Option[Exhaustive] = scala.None,
    exhaustiveFacetsCount: Option[Boolean] = scala.None,
    exhaustiveNbHits: Option[Boolean] = scala.None,
    exhaustiveTypo: Option[Boolean] = scala.None,
    facets: Option[Map[String, Map[String, Int]]] = scala.None,
    facetsStats: Option[Map[String, FacetsStats]] = scala.None,
    index: Option[String] = scala.None,
    indexUsed: Option[String] = scala.None,
    message: Option[String] = scala.None,
    nbSortedHits: Option[Int] = scala.None,
    parsedQuery: Option[String] = scala.None,
    processingTimeMS: Int,
    processingTimingsMS: Option[Any] = scala.None,
    queryAfterRemoval: Option[String] = scala.None,
    redirect: Option[Redirect] = scala.None,
    renderingContent: Option[RenderingContent] = scala.None,
    serverTimeMS: Option[Int] = scala.None,
    serverUsed: Option[String] = scala.None,
    userData: Option[Any] = scala.None,
    queryID: Option[String] = scala.None,
    page: Option[Int] = scala.None,
    nbHits: Option[Int] = scala.None,
    nbPages: Option[Int] = scala.None,
    hitsPerPage: Option[Int] = scala.None,
    hits: Seq[Hit],
    query: String,
    params: String,
    cursor: Option[String] = scala.None
)
