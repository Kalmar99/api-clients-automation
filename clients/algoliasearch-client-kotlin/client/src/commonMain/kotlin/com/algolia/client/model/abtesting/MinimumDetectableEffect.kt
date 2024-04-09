/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.abtesting

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * Configuration for the smallest difference between test variants you want to detect.
 *
 * @param size Smallest difference in an observable metric between variants. For example, to detect a 10% difference between variants, set this value to 0.1.
 * @param effect
 */
@Serializable
public data class MinimumDetectableEffect(

  /** Smallest difference in an observable metric between variants. For example, to detect a 10% difference between variants, set this value to 0.1.  */
  @SerialName(value = "size") val size: Double? = null,

  @SerialName(value = "effect") val effect: Effect? = null,
)
