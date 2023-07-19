// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package analytics

import (
	"encoding/json"
	"fmt"
)

// SearchNoResultEvent struct for SearchNoResultEvent
type SearchNoResultEvent struct {
	// User query.
	Search string `json:"search" validate:"required"`
	// Number of occurrences.
	Count int32 `json:"count" validate:"required"`
	// Number of hits the search query matched.
	NbHits int32 `json:"nbHits" validate:"required"`
}

// NewSearchNoResultEvent instantiates a new SearchNoResultEvent object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSearchNoResultEvent(search string, count int32, nbHits int32) *SearchNoResultEvent {
	this := &SearchNoResultEvent{}
	this.Search = search
	this.Count = count
	this.NbHits = nbHits
	return this
}

// NewSearchNoResultEventWithDefaults instantiates a new SearchNoResultEvent object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSearchNoResultEventWithDefaults() *SearchNoResultEvent {
	this := &SearchNoResultEvent{}
	return this
}

// GetSearch returns the Search field value
func (o *SearchNoResultEvent) GetSearch() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Search
}

// GetSearchOk returns a tuple with the Search field value
// and a boolean to check if the value has been set.
func (o *SearchNoResultEvent) GetSearchOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Search, true
}

// SetSearch sets field value
func (o *SearchNoResultEvent) SetSearch(v string) {
	o.Search = v
}

// GetCount returns the Count field value
func (o *SearchNoResultEvent) GetCount() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.Count
}

// GetCountOk returns a tuple with the Count field value
// and a boolean to check if the value has been set.
func (o *SearchNoResultEvent) GetCountOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Count, true
}

// SetCount sets field value
func (o *SearchNoResultEvent) SetCount(v int32) {
	o.Count = v
}

// GetNbHits returns the NbHits field value
func (o *SearchNoResultEvent) GetNbHits() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.NbHits
}

// GetNbHitsOk returns a tuple with the NbHits field value
// and a boolean to check if the value has been set.
func (o *SearchNoResultEvent) GetNbHitsOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.NbHits, true
}

// SetNbHits sets field value
func (o *SearchNoResultEvent) SetNbHits(v int32) {
	o.NbHits = v
}

func (o SearchNoResultEvent) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["search"] = o.Search
	}
	if true {
		toSerialize["count"] = o.Count
	}
	if true {
		toSerialize["nbHits"] = o.NbHits
	}
	return json.Marshal(toSerialize)
}

func (o SearchNoResultEvent) String() string {
	out := ""
	out += fmt.Sprintf("  search=%v\n", o.Search)
	out += fmt.Sprintf("  count=%v\n", o.Count)
	out += fmt.Sprintf("  nbHits=%v\n", o.NbHits)
	return fmt.Sprintf("SearchNoResultEvent {\n%s}", out)
}

type NullableSearchNoResultEvent struct {
	value *SearchNoResultEvent
	isSet bool
}

func (v NullableSearchNoResultEvent) Get() *SearchNoResultEvent {
	return v.value
}

func (v *NullableSearchNoResultEvent) Set(val *SearchNoResultEvent) {
	v.value = val
	v.isSet = true
}

func (v NullableSearchNoResultEvent) IsSet() bool {
	return v.isSet
}

func (v *NullableSearchNoResultEvent) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSearchNoResultEvent(val *SearchNoResultEvent) *NullableSearchNoResultEvent {
	return &NullableSearchNoResultEvent{value: val, isSet: true}
}

func (v NullableSearchNoResultEvent) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSearchNoResultEvent) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
