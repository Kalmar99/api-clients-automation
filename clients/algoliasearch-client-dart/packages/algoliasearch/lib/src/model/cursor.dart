// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
// ignore_for_file: unused_element

import 'package:json_annotation/json_annotation.dart';

part 'cursor.g.dart';

@JsonSerializable()
final class Cursor {
  /// Returns a new [Cursor] instance.
  const Cursor({
    this.cursor,
  });

  /// Cursor indicating the location to resume browsing from. Must match the value returned by the previous call. Pass this value to the subsequent browse call to get the next page of results. When the end of the index has been reached, `cursor` is absent from the response.
  @JsonKey(name: r'cursor')
  final String? cursor;

  @override
  bool operator ==(Object other) =>
      identical(this, other) || other is Cursor && other.cursor == cursor;

  @override
  int get hashCode => cursor.hashCode;

  factory Cursor.fromJson(Map<String, dynamic> json) => _$CursorFromJson(json);

  Map<String, dynamic> toJson() => _$CursorToJson(this);

  @override
  String toString() {
    return toJson().toString();
  }
}
