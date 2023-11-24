# coding: utf-8

"""
Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
"""
from __future__ import annotations

import json
from enum import Enum

try:
    from typing import Self
except ImportError:
    from typing_extensions import Self


class Anchoring(str, Enum):
    """
    Whether the pattern parameter matches the beginning (`startsWith`) or end (`endsWith`) of the query string, is an exact match (`is`), or a partial match (`contains`).
    """

    """
    allowed enum values
    """
    IS = "is"
    STARTSWITH = "startsWith"
    ENDSWITH = "endsWith"
    CONTAINS = "contains"

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of Anchoring from a JSON string"""
        return cls(json.loads(json_str))
