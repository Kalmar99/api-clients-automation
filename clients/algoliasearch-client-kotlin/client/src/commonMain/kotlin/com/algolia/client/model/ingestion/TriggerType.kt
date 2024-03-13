/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*

/**
 * The type of the task reflect how it can be used:   - onDemand: a task that runs manually   - schedule: a task that runs regularly, following a given cron expression   - subscription: a task that runs after a subscription event is received from an integration (e.g. Webhook).   - streaming: a task that runs continuously.
 */
@Serializable
public enum class TriggerType(public val value: kotlin.String) {

  @SerialName(value = "onDemand")
  OnDemand("onDemand"),

  @SerialName(value = "schedule")
  Schedule("schedule"),

  @SerialName(value = "subscription")
  Subscription("subscription"),

  @SerialName(value = "streaming")
  Streaming("streaming");

  override fun toString(): kotlin.String = value
}
