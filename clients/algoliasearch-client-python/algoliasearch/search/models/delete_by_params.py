# coding: utf-8

"""
Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
"""
from __future__ import annotations

import json
import pprint
from typing import Any, ClassVar, Dict, List, Optional, Union

from pydantic import BaseModel, Field, StrictFloat, StrictInt, StrictStr

from algoliasearch.search.models.around_radius import AroundRadius
from algoliasearch.search.models.facet_filters import FacetFilters
from algoliasearch.search.models.numeric_filters import NumericFilters
from algoliasearch.search.models.tag_filters import TagFilters

try:
    from typing import Self
except ImportError:
    from typing_extensions import Self


class DeleteByParams(BaseModel):
    """
    DeleteByParams
    """

    facet_filters: Optional[FacetFilters] = Field(default=None, alias="facetFilters")
    filters: Optional[StrictStr] = Field(
        default="",
        description="[Filter](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/) the query with numeric, facet, or tag filters. ",
    )
    numeric_filters: Optional[NumericFilters] = Field(
        default=None, alias="numericFilters"
    )
    tag_filters: Optional[TagFilters] = Field(default=None, alias="tagFilters")
    around_lat_lng: Optional[StrictStr] = Field(
        default="",
        description="Search for entries [around a central location](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filter-around-a-central-point), enabling a geographical search within a circular area.",
        alias="aroundLatLng",
    )
    around_radius: Optional[AroundRadius] = Field(default=None, alias="aroundRadius")
    inside_bounding_box: Optional[List[List[Union[StrictFloat, StrictInt]]]] = Field(
        default=None,
        description="Search inside a [rectangular area](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).",
        alias="insideBoundingBox",
    )
    inside_polygon: Optional[List[List[Union[StrictFloat, StrictInt]]]] = Field(
        default=None,
        description="Search inside a [polygon](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas) (in geographical coordinates).",
        alias="insidePolygon",
    )
    __properties: ClassVar[List[str]] = [
        "facetFilters",
        "filters",
        "numericFilters",
        "tagFilters",
        "aroundLatLng",
        "aroundRadius",
        "insideBoundingBox",
        "insidePolygon",
    ]

    model_config = {"populate_by_name": True, "validate_assignment": True}

    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True,
        # exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of DeleteByParams from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        """
        _dict = self.model_dump(
            by_alias=True,
            exclude={},
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of
        # facet_filters
        if self.facet_filters:
            _dict["facetFilters"] = self.facet_filters.to_dict()
        # override the default output from pydantic by calling `to_dict()` of
        # numeric_filters
        if self.numeric_filters:
            _dict["numericFilters"] = self.numeric_filters.to_dict()
        # override the default output from pydantic by calling `to_dict()` of
        # tag_filters
        if self.tag_filters:
            _dict["tagFilters"] = self.tag_filters.to_dict()
        # override the default output from pydantic by calling `to_dict()` of
        # around_radius
        if self.around_radius:
            _dict["aroundRadius"] = self.around_radius.to_dict()
        return _dict

    @classmethod
    def from_dict(cls, obj: Dict) -> Self:
        """Create an instance of DeleteByParams from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate(
            {
                "facetFilters": FacetFilters.from_dict(obj.get("facetFilters"))
                if obj.get("facetFilters") is not None
                else None,
                "filters": obj.get("filters") if obj.get("filters") is not None else "",
                "numericFilters": NumericFilters.from_dict(obj.get("numericFilters"))
                if obj.get("numericFilters") is not None
                else None,
                "tagFilters": TagFilters.from_dict(obj.get("tagFilters"))
                if obj.get("tagFilters") is not None
                else None,
                "aroundLatLng": obj.get("aroundLatLng")
                if obj.get("aroundLatLng") is not None
                else "",
                "aroundRadius": AroundRadius.from_dict(obj.get("aroundRadius"))
                if obj.get("aroundRadius") is not None
                else None,
                "insideBoundingBox": obj.get("insideBoundingBox"),
                "insidePolygon": obj.get("insidePolygon"),
            }
        )
        return _obj
