/** Ingestion API The Ingestion API lets you connect third-party services and platforms with Algolia and schedule tasks
  * to ingest your data. The Ingestion API powers the no-code [data
  * connectors](https://dashboard.algolia.com/connectors). # Base URLs The base URLs for making requests to the
  * Ingestion API are: - `https://data.us.algolia.com` - `https://data.eu.algolia.com` Use the URL that matches your
  * [analytics region](https://dashboard.algolia.com/account/infrastructure/analytics). **All requests must use HTTPS.**
  * # Authentication To authenticate your API requests, add these headers: <dl>
  * <dt><code>x-algolia-application-id</code></dt> <dd>Your Algolia application ID.</dd>
  * <dt><code>x-algolia-api-key</code></dt> <dd> An API key with the necessary permissions to make the request. The
  * required access control list (ACL) to make a request is listed in each endpoint's reference. </dd> </dl> You can
  * find your application ID and API key in the [Algolia dashboard](https://dashboard.algolia.com/account). # Request
  * format Request bodies must be JSON objects. # Response status and errors Response bodies are JSON objects. Deleting
  * a user token returns an empty response body with rate-limiting information as headers. Successful responses return a
  * `2xx` status. Client errors return a `4xx` status. Server errors are indicated by a `5xx` status. Error responses
  * have a `message` property with more information. The Insights API doesn't validate if the event parameters such as
  * `indexName`, `objectIDs`, or `userToken`, correspond to anything in the Search API. It justs checks if they're
  * formatted correctly. Check the [Events](https://dashboard.algolia.com/events/health) health section, whether your
  * events can be used for Algolia features such as Analytics, or Dynamic Re-Ranking. # Version The current version of
  * the Insights API is version 1, as indicated by the `/1/` in each endpoint's URL.
  *
  * The version of the OpenAPI document: 1.0.0
  *
  * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
  * https://openapi-generator.tech Do not edit the class manually.
  */
package algoliasearch.ingestion

import org.json4s._

sealed trait AuthenticationType

/** Type of authentication. This determines the type of credentials required in the `input` object.
  */
object AuthenticationType {
  case object GoogleServiceAccount extends AuthenticationType {
    override def toString = "googleServiceAccount"
  }
  case object Basic extends AuthenticationType {
    override def toString = "basic"
  }
  case object ApiKey extends AuthenticationType {
    override def toString = "apiKey"
  }
  case object Oauth extends AuthenticationType {
    override def toString = "oauth"
  }
  case object Algolia extends AuthenticationType {
    override def toString = "algolia"
  }
  case object AlgoliaInsights extends AuthenticationType {
    override def toString = "algoliaInsights"
  }
  val values: Seq[AuthenticationType] = Seq(GoogleServiceAccount, Basic, ApiKey, Oauth, Algolia, AlgoliaInsights)

  def withName(name: String): AuthenticationType = AuthenticationType.values
    .find(_.toString == name)
    .getOrElse(throw new MappingException(s"Unknown AuthenticationType value: $name"))
}

class AuthenticationTypeSerializer
    extends CustomSerializer[AuthenticationType](_ =>
      (
        {
          case JString(value) => AuthenticationType.withName(value)
          case JNull          => null
        },
        { case value: AuthenticationType =>
          JString(value.toString)
        }
      )
    )
