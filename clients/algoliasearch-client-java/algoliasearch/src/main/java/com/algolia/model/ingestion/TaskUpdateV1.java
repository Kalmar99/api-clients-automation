// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.Objects;

/**
 * API request body for updating a task using the V1 shape, please use methods and types that don't
 * contain the V1 suffix.
 *
 * @deprecated
 */
@Deprecated
public class TaskUpdateV1 {

  @JsonProperty("destinationID")
  private String destinationID;

  @JsonProperty("trigger")
  private TriggerUpdateInput trigger;

  @JsonProperty("input")
  private TaskInput input;

  @JsonProperty("enabled")
  private Boolean enabled;

  @JsonProperty("failureThreshold")
  private Integer failureThreshold;

  public TaskUpdateV1 setDestinationID(String destinationID) {
    this.destinationID = destinationID;
    return this;
  }

  /** Universally unique identifier (UUID) of a destination resource. */
  @javax.annotation.Nullable
  public String getDestinationID() {
    return destinationID;
  }

  public TaskUpdateV1 setTrigger(TriggerUpdateInput trigger) {
    this.trigger = trigger;
    return this;
  }

  /** Get trigger */
  @javax.annotation.Nullable
  public TriggerUpdateInput getTrigger() {
    return trigger;
  }

  public TaskUpdateV1 setInput(TaskInput input) {
    this.input = input;
    return this;
  }

  /** Get input */
  @javax.annotation.Nullable
  public TaskInput getInput() {
    return input;
  }

  public TaskUpdateV1 setEnabled(Boolean enabled) {
    this.enabled = enabled;
    return this;
  }

  /** Whether the task is enabled. */
  @javax.annotation.Nullable
  public Boolean getEnabled() {
    return enabled;
  }

  public TaskUpdateV1 setFailureThreshold(Integer failureThreshold) {
    this.failureThreshold = failureThreshold;
    return this;
  }

  /**
   * Maximum accepted percentage of failures for a task run to finish successfully. minimum: 0
   * maximum: 100
   */
  @javax.annotation.Nullable
  public Integer getFailureThreshold() {
    return failureThreshold;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TaskUpdateV1 taskUpdateV1 = (TaskUpdateV1) o;
    return (
      Objects.equals(this.destinationID, taskUpdateV1.destinationID) &&
      Objects.equals(this.trigger, taskUpdateV1.trigger) &&
      Objects.equals(this.input, taskUpdateV1.input) &&
      Objects.equals(this.enabled, taskUpdateV1.enabled) &&
      Objects.equals(this.failureThreshold, taskUpdateV1.failureThreshold)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(destinationID, trigger, input, enabled, failureThreshold);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TaskUpdateV1 {\n");
    sb.append("    destinationID: ").append(toIndentedString(destinationID)).append("\n");
    sb.append("    trigger: ").append(toIndentedString(trigger)).append("\n");
    sb.append("    input: ").append(toIndentedString(input)).append("\n");
    sb.append("    enabled: ").append(toIndentedString(enabled)).append("\n");
    sb.append("    failureThreshold: ").append(toIndentedString(failureThreshold)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}
