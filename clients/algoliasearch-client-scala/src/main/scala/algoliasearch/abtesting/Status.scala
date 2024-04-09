/** A/B Testing API The Algolia A/B Testing API lets you manage your Algolia A/B tests to optimize your search
  * experience. ## Base URLs The base URLs for requests to the A/B testing API are: - `https://analytics.us.algolia.com`
  * (alias: `https://analytics.algolia.com`) - `https://analytics.de.algolia.com` Use the URL that matches your
  * [analytics region](https://dashboard.algolia.com/account/infrastructure/analytics). **All requests must use HTTPS.**
  * ## Availability and authentication Access to the A/B testing API is available as part of the [Premium or Elevate
  * plans](https://www.algolia.com/pricing). To authenticate your API requests, add these headers: -
  * `x-algolia-application-id`. Your Algolia application ID. - `x-algolia-api-key`. An API key with the necessary
  * permissions to make the request. The required access control list (ACL) to make a request is listed in each
  * endpoint's reference. You can find your application ID and API key in the [Algolia
  * dashboard](https://dashboard.algolia.com/account). ## Rate limits You can make up to **100 requests per minute per
  * app** to the A/B testing API. The response includes headers with information about the limits. ## Parameters Query
  * parameters must be [URL-encoded](https://developer.mozilla.org/en-US/docs/Glossary/Percent-encoding). Non-ASCII
  * characters must be UTF-8 encoded. Plus characters (`+`) are interpreted as spaces. ## Response status and errors The
  * A/B testing API returns JSON responses. Since JSON doesn't guarantee any specific ordering, don't rely on the order
  * of attributes in the API response. Successful responses return a `2xx` status. Client errors return a `4xx` status.
  * Server errors are indicated by a `5xx` status. Error responses have a `message` property with more information. ##
  * Version The current version of the A/B Testing API is version 2, as indicated by the `/2/` in each endpoint's URL.
  *
  * The version of the OpenAPI document: 2.0.0
  *
  * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
  * https://openapi-generator.tech Do not edit the class manually.
  */
package algoliasearch.abtesting

import org.json4s._

sealed trait Status

/** A/B test status. - `active`. The A/B test is live and search traffic is split between the two variants. - `stopped`.
  * You stopped the A/B test. The A/B test data is still available for analysis. - `expired`. The A/B test was
  * automatically stopped after reaching its end date. - `failed`. Creating the A/B test failed.
  */
object Status {
  case object Active extends Status {
    override def toString = "active"
  }
  case object Stopped extends Status {
    override def toString = "stopped"
  }
  case object Expired extends Status {
    override def toString = "expired"
  }
  case object Failed extends Status {
    override def toString = "failed"
  }
  val values: Seq[Status] = Seq(Active, Stopped, Expired, Failed)

  def withName(name: String): Status = Status.values
    .find(_.toString == name)
    .getOrElse(throw new MappingException(s"Unknown Status value: $name"))
}

class StatusSerializer
    extends CustomSerializer[Status](_ =>
      (
        {
          case JString(value) => Status.withName(value)
          case JNull          => null
        },
        { case value: Status =>
          JString(value.toString)
        }
      )
    )
