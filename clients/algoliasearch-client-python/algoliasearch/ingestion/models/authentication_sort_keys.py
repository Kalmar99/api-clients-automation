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


class AuthenticationSortKeys(str, Enum):
    """
    Used to sort the Authentication list endpoint.
    """

    """
    allowed enum values
    """
    NAME = "name"
    AUTH_TYPE = "auth_type"
    PLATFORM = "platform"
    UPDATEDAT = "updatedAt"
    CREATEDAT = "createdAt"

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of AuthenticationSortKeys from a JSON string"""
        return cls(json.loads(json_str))
