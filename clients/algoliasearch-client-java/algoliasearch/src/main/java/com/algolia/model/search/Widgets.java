// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.search;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.Objects;

/** widgets returned from any rules that are applied to the current search. */
public class Widgets {

  @JsonProperty("banners")
  private Banners banners;

  public Widgets setBanners(Banners banners) {
    this.banners = banners;
    return this;
  }

  /** Get banners */
  @javax.annotation.Nullable
  public Banners getBanners() {
    return banners;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Widgets widgets = (Widgets) o;
    return Objects.equals(this.banners, widgets.banners);
  }

  @Override
  public int hashCode() {
    return Objects.hash(banners);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Widgets {\n");
    sb.append("    banners: ").append(toIndentedString(banners)).append("\n");
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
