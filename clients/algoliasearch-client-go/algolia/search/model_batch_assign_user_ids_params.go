// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package search

import (
	"encoding/json"
	"fmt"
)

// BatchAssignUserIdsParams Assign userID parameters.
type BatchAssignUserIdsParams struct {
	// Cluster name.
	Cluster string `json:"cluster" validate:"required"`
	// User IDs to assign.
	Users []string `json:"users" validate:"required"`
}

// NewBatchAssignUserIdsParams instantiates a new BatchAssignUserIdsParams object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewBatchAssignUserIdsParams(cluster string, users []string) *BatchAssignUserIdsParams {
	this := &BatchAssignUserIdsParams{}
	this.Cluster = cluster
	this.Users = users
	return this
}

// NewBatchAssignUserIdsParamsWithDefaults instantiates a new BatchAssignUserIdsParams object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewBatchAssignUserIdsParamsWithDefaults() *BatchAssignUserIdsParams {
	this := &BatchAssignUserIdsParams{}
	return this
}

// GetCluster returns the Cluster field value
func (o *BatchAssignUserIdsParams) GetCluster() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Cluster
}

// GetClusterOk returns a tuple with the Cluster field value
// and a boolean to check if the value has been set.
func (o *BatchAssignUserIdsParams) GetClusterOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Cluster, true
}

// SetCluster sets field value
func (o *BatchAssignUserIdsParams) SetCluster(v string) {
	o.Cluster = v
}

// GetUsers returns the Users field value
func (o *BatchAssignUserIdsParams) GetUsers() []string {
	if o == nil {
		var ret []string
		return ret
	}

	return o.Users
}

// GetUsersOk returns a tuple with the Users field value
// and a boolean to check if the value has been set.
func (o *BatchAssignUserIdsParams) GetUsersOk() ([]string, bool) {
	if o == nil {
		return nil, false
	}
	return o.Users, true
}

// SetUsers sets field value
func (o *BatchAssignUserIdsParams) SetUsers(v []string) {
	o.Users = v
}

func (o BatchAssignUserIdsParams) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["cluster"] = o.Cluster
	}
	if true {
		toSerialize["users"] = o.Users
	}
	return json.Marshal(toSerialize)
}

func (o BatchAssignUserIdsParams) String() string {
	out := ""
	out += fmt.Sprintf("  cluster=%v\n", o.Cluster)
	out += fmt.Sprintf("  users=%v\n", o.Users)
	return fmt.Sprintf("BatchAssignUserIdsParams {\n%s}", out)
}

type NullableBatchAssignUserIdsParams struct {
	value *BatchAssignUserIdsParams
	isSet bool
}

func (v NullableBatchAssignUserIdsParams) Get() *BatchAssignUserIdsParams {
	return v.value
}

func (v *NullableBatchAssignUserIdsParams) Set(val *BatchAssignUserIdsParams) {
	v.value = val
	v.isSet = true
}

func (v NullableBatchAssignUserIdsParams) IsSet() bool {
	return v.isSet
}

func (v *NullableBatchAssignUserIdsParams) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableBatchAssignUserIdsParams(val *BatchAssignUserIdsParams) *NullableBatchAssignUserIdsParams {
	return &NullableBatchAssignUserIdsParams{value: val, isSet: true}
}

func (v NullableBatchAssignUserIdsParams) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableBatchAssignUserIdsParams) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
