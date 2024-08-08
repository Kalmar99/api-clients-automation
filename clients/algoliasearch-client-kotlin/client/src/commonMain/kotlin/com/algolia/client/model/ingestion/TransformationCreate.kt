/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * API request body for creating a transformation.
 *
 * @param code The source code of the transformation.
 * @param name The uniquely identified name of your transformation.
 * @param description A descriptive name for your transformation of what it does.
 * @param authenticationIDs The authentications associated for the current transformation.
 */
@Serializable
public data class TransformationCreate(

  /** The source code of the transformation. */
  @SerialName(value = "code") val code: String,

  /** The uniquely identified name of your transformation. */
  @SerialName(value = "name") val name: String,

  /** A descriptive name for your transformation of what it does. */
  @SerialName(value = "description") val description: String? = null,

  /** The authentications associated for the current transformation. */
  @SerialName(value = "authenticationIDs") val authenticationIDs: List<String>? = null,
)
