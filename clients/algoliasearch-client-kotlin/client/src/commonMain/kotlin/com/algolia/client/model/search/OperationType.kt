/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.search

import kotlinx.serialization.*

/**
 * Operation to perform (_move_ or _copy_).
 */
@Serializable
public enum class OperationType(public val value: kotlin.String) {

  @SerialName(value = "move")
  Move("move"),

  @SerialName(value = "copy")
  Copy("copy");

  override fun toString(): kotlin.String = value
}
