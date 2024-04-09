/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.abtesting

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * AddABTestsRequest
 *
 * @param name A/B test name.
 * @param variants A/B test variants.
 * @param endAt End date and time of the A/B test, in RFC 3339 format.
 */
@Serializable
public data class AddABTestsRequest(

  /** A/B test name. */
  @SerialName(value = "name") val name: String,

  /** A/B test variants. */
  @SerialName(value = "variants") val variants: List<AddABTestsVariant>,

  /** End date and time of the A/B test, in RFC 3339 format. */
  @SerialName(value = "endAt") val endAt: String,
)
