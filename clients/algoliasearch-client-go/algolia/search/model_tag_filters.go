// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package search

import (
	"encoding/json"
	"fmt"
)

// TagFilters - [Filter hits by tags](https://www.algolia.com/doc/api-reference/api-parameters/tagFilters/).
type TagFilters struct {
	ArrayOfMixedSearchFilters *[]MixedSearchFilters
	String                    *string
}

// []MixedSearchFiltersAsTagFilters is a convenience function that returns []MixedSearchFilters wrapped in TagFilters
func ArrayOfMixedSearchFiltersAsTagFilters(v *[]MixedSearchFilters) TagFilters {
	return TagFilters{
		ArrayOfMixedSearchFilters: v,
	}
}

// stringAsTagFilters is a convenience function that returns string wrapped in TagFilters
func StringAsTagFilters(v *string) TagFilters {
	return TagFilters{
		String: v,
	}
}

// Unmarshal JSON data into one of the pointers in the struct
func (dst *TagFilters) UnmarshalJSON(data []byte) error {
	var err error
	// try to unmarshal data into ArrayOfMixedSearchFilters
	err = newStrictDecoder(data).Decode(&dst.ArrayOfMixedSearchFilters)
	if err == nil && validateStruct(dst.ArrayOfMixedSearchFilters) == nil {
		jsonArrayOfMixedSearchFilters, _ := json.Marshal(dst.ArrayOfMixedSearchFilters)
		if string(jsonArrayOfMixedSearchFilters) == "{}" { // empty struct
			dst.ArrayOfMixedSearchFilters = nil
		} else {
			return nil
		}
	} else {
		dst.ArrayOfMixedSearchFilters = nil
	}

	// try to unmarshal data into String
	err = newStrictDecoder(data).Decode(&dst.String)
	if err == nil && validateStruct(dst.String) == nil {
		jsonString, _ := json.Marshal(dst.String)
		if string(jsonString) == "{}" { // empty struct
			dst.String = nil
		} else {
			return nil
		}
	} else {
		dst.String = nil
	}

	return fmt.Errorf("Data failed to match schemas in oneOf(TagFilters)")
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src TagFilters) MarshalJSON() ([]byte, error) {
	if src.ArrayOfMixedSearchFilters != nil {
		return json.Marshal(&src.ArrayOfMixedSearchFilters)
	}

	if src.String != nil {
		return json.Marshal(&src.String)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *TagFilters) GetActualInstance() any {
	if obj == nil {
		return nil
	}
	if obj.ArrayOfMixedSearchFilters != nil {
		return obj.ArrayOfMixedSearchFilters
	}

	if obj.String != nil {
		return obj.String
	}

	// all schemas are nil
	return nil
}

type NullableTagFilters struct {
	value *TagFilters
	isSet bool
}

func (v NullableTagFilters) Get() *TagFilters {
	return v.value
}

func (v *NullableTagFilters) Set(val *TagFilters) {
	v.value = val
	v.isSet = true
}

func (v NullableTagFilters) IsSet() bool {
	return v.isSet
}

func (v *NullableTagFilters) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableTagFilters(val *TagFilters) *NullableTagFilters {
	return &NullableTagFilters{value: val, isSet: true}
}

func (v NullableTagFilters) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableTagFilters) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
