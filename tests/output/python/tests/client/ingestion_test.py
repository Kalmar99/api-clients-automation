# Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
from re import compile
from json import loads

from algoliasearch.http.transporter import EchoTransporter
from algoliasearch.http.transporter_sync import EchoTransporterSync
from algoliasearch.http.hosts import Host, HostsCollection
from algoliasearch.ingestion.client import IngestionClient
from algoliasearch.ingestion.client import IngestionClientSync
from algoliasearch.ingestion.config import IngestionConfig


class TestIngestionClient:
    def create_client(self) -> IngestionClient:
        _config = IngestionConfig("appId", "apiKey", "us")
        return IngestionClient.create_with_config(
            config=_config, transporter=EchoTransporter(_config)
        )

    async def test_common_api_0(self):
        """
        calls api with correct user agent
        """
        _client = self.create_client()

        _req = await _client.custom_post_with_http_info(
            path="1/test",
        )
        regex_user_agent = compile(
            "^Algolia for Python \\(\\d+\\.\\d+\\.\\d+(-?.*)?\\)(; [a-zA-Z. ]+ (\\(\\d+((\\.\\d+)?\\.\\d+)?(-?.*)?\\))?)*(; Ingestion (\\(\\d+\\.\\d+\\.\\d+(-?.*)?\\)))(; [a-zA-Z. ]+ (\\(\\d+((\\.\\d+)?\\.\\d+)?(-?.*)?\\))?)*$"
        )
        assert regex_user_agent.match(_req.headers.get("user-agent")) is not None

    async def test_common_api_1(self):
        """
        the user agent contains the latest version
        """
        _client = self.create_client()

        _req = await _client.custom_post_with_http_info(
            path="1/test",
        )
        regex_user_agent = compile("^Algolia for Python \\(4.3.0\\).*")
        assert regex_user_agent.match(_req.headers.get("user-agent")) is not None

    async def test_common_api_2(self):
        """
        calls api with default read timeouts
        """
        _client = self.create_client()

        _req = await _client.custom_get_with_http_info(
            path="1/test",
        )
        assert _req.timeouts.get("connect") == 2000
        assert _req.timeouts.get("response") == 5000

    async def test_common_api_3(self):
        """
        calls api with default write timeouts
        """
        _client = self.create_client()

        _req = await _client.custom_post_with_http_info(
            path="1/test",
        )
        assert _req.timeouts.get("connect") == 2000
        assert _req.timeouts.get("response") == 30000

    async def test_parameters_0(self):
        """
        uses the correct region
        """

        _config = IngestionConfig("my-app-id", "my-api-key", "us")
        _client = IngestionClient.create_with_config(
            config=_config, transporter=EchoTransporter(_config)
        )
        _req = await _client.get_source_with_http_info(
            source_id="6c02aeb1-775e-418e-870b-1faccd4b2c0f",
        )
        assert _req.host == "data.us.algolia.com"

    async def test_parameters_1(self):
        """
        throws when incorrect region is given
        """

        try:
            _config = IngestionConfig("my-app-id", "my-api-key", "not_a_region")
            _client = IngestionClient.create_with_config(
                config=_config, transporter=EchoTransporter(_config)
            )
            assert False
        except (ValueError, Exception) as e:
            assert (
                str(e)
                == "`region` is required and must be one of the following: eu, us"
            )

    async def test_set_client_api_key_0(self):
        """
        switch API key
        """

        _config = IngestionConfig("test-app-id", "test-api-key", "us")
        _config.hosts = HostsCollection(
            [Host(url="localhost", scheme="http", port=6683)]
        )
        _client = IngestionClient.create_with_config(config=_config)
        _req = await _client.custom_get(
            path="check-api-key/1",
        )
        assert (
            _req
            if isinstance(_req, dict)
            else [elem.to_dict() for elem in _req]
            if isinstance(_req, list)
            else _req.to_dict()
        ) == loads("""{"headerAPIKeyValue":"test-api-key"}""")
        await _client.set_client_api_key(
            api_key="updated-api-key",
        )
        _req = await _client.custom_get(
            path="check-api-key/2",
        )
        assert (
            _req
            if isinstance(_req, dict)
            else [elem.to_dict() for elem in _req]
            if isinstance(_req, list)
            else _req.to_dict()
        ) == loads("""{"headerAPIKeyValue":"updated-api-key"}""")


class TestIngestionClientSync:
    def create_client(self) -> IngestionClientSync:
        _config = IngestionConfig("appId", "apiKey", "us")
        return IngestionClientSync.create_with_config(
            config=_config, transporter=EchoTransporterSync(_config)
        )

    def test_common_api_0(self):
        """
        calls api with correct user agent
        """
        _client = self.create_client()

        _req = _client.custom_post_with_http_info(
            path="1/test",
        )
        regex_user_agent = compile(
            "^Algolia for Python \\(\\d+\\.\\d+\\.\\d+(-?.*)?\\)(; [a-zA-Z. ]+ (\\(\\d+((\\.\\d+)?\\.\\d+)?(-?.*)?\\))?)*(; Ingestion (\\(\\d+\\.\\d+\\.\\d+(-?.*)?\\)))(; [a-zA-Z. ]+ (\\(\\d+((\\.\\d+)?\\.\\d+)?(-?.*)?\\))?)*$"
        )
        assert regex_user_agent.match(_req.headers.get("user-agent")) is not None

    def test_common_api_1(self):
        """
        the user agent contains the latest version
        """
        _client = self.create_client()

        _req = _client.custom_post_with_http_info(
            path="1/test",
        )
        regex_user_agent = compile("^Algolia for Python \\(4.3.0\\).*")
        assert regex_user_agent.match(_req.headers.get("user-agent")) is not None

    def test_common_api_2(self):
        """
        calls api with default read timeouts
        """
        _client = self.create_client()

        _req = _client.custom_get_with_http_info(
            path="1/test",
        )
        assert _req.timeouts.get("connect") == 2000
        assert _req.timeouts.get("response") == 5000

    def test_common_api_3(self):
        """
        calls api with default write timeouts
        """
        _client = self.create_client()

        _req = _client.custom_post_with_http_info(
            path="1/test",
        )
        assert _req.timeouts.get("connect") == 2000
        assert _req.timeouts.get("response") == 30000

    def test_parameters_0(self):
        """
        uses the correct region
        """

        _config = IngestionConfig("my-app-id", "my-api-key", "us")
        _client = IngestionClientSync.create_with_config(
            config=_config, transporter=EchoTransporterSync(_config)
        )
        _req = _client.get_source_with_http_info(
            source_id="6c02aeb1-775e-418e-870b-1faccd4b2c0f",
        )
        assert _req.host == "data.us.algolia.com"

    def test_parameters_1(self):
        """
        throws when incorrect region is given
        """

        try:
            _config = IngestionConfig("my-app-id", "my-api-key", "not_a_region")
            _client = IngestionClientSync.create_with_config(
                config=_config, transporter=EchoTransporterSync(_config)
            )
            assert False
        except (ValueError, Exception) as e:
            assert (
                str(e)
                == "`region` is required and must be one of the following: eu, us"
            )

    def test_set_client_api_key_0(self):
        """
        switch API key
        """

        _config = IngestionConfig("test-app-id", "test-api-key", "us")
        _config.hosts = HostsCollection(
            [Host(url="localhost", scheme="http", port=6683)]
        )
        _client = IngestionClientSync.create_with_config(config=_config)
        _req = _client.custom_get(
            path="check-api-key/1",
        )
        assert (
            _req
            if isinstance(_req, dict)
            else [elem.to_dict() for elem in _req]
            if isinstance(_req, list)
            else _req.to_dict()
        ) == loads("""{"headerAPIKeyValue":"test-api-key"}""")
        _client.set_client_api_key(
            api_key="updated-api-key",
        )
        _req = _client.custom_get(
            path="check-api-key/2",
        )
        assert (
            _req
            if isinstance(_req, dict)
            else [elem.to_dict() for elem in _req]
            if isinstance(_req, list)
            else _req.to_dict()
        ) == loads("""{"headerAPIKeyValue":"updated-api-key"}""")
