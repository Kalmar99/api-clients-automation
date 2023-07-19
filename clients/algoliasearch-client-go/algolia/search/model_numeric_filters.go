// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package search

import (
	"encoding/json"
	"fmt"
)

// NumericFilters - [Filter on numeric attributes](https://www.algolia.com/doc/api-reference/api-parameters/numericFilters/).
type NumericFilters struct {
	ArrayOfMixedSearchFilters *[]MixedSearchFilters
	String                    *string
}

// []MixedSearchFiltersAsNumericFilters is a convenience function that returns []MixedSearchFilters wrapped in NumericFilters
func ArrayOfMixedSearchFiltersAsNumericFilters(v *[]MixedSearchFilters) NumericFilters {
	return NumericFilters{
		ArrayOfMixedSearchFilters: v,
	}
}

// stringAsNumericFilters is a convenience function that returns string wrapped in NumericFilters
func StringAsNumericFilters(v *string) NumericFilters {
	return NumericFilters{
		String: v,
	}
}

// Unmarshal JSON data into one of the pointers in the struct
func (dst *NumericFilters) UnmarshalJSON(data []byte) error {
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

	return fmt.Errorf("Data failed to match schemas in oneOf(NumericFilters)")
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src NumericFilters) MarshalJSON() ([]byte, error) {
	if src.ArrayOfMixedSearchFilters != nil {
		return json.Marshal(&src.ArrayOfMixedSearchFilters)
	}

	if src.String != nil {
		return json.Marshal(&src.String)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *NumericFilters) GetActualInstance() any {
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

type NullableNumericFilters struct {
	value *NumericFilters
	isSet bool
}

func (v NullableNumericFilters) Get() *NumericFilters {
	return v.value
}

func (v *NullableNumericFilters) Set(val *NumericFilters) {
	v.value = val
	v.isSet = true
}

func (v NullableNumericFilters) IsSet() bool {
	return v.isSet
}

func (v *NullableNumericFilters) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableNumericFilters(val *NumericFilters) *NullableNumericFilters {
	return &NullableNumericFilters{value: val, isSet: true}
}

func (v NullableNumericFilters) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableNumericFilters) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
