// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package com.algolia.client

import com.algolia.client.api.SearchClient
import com.algolia.client.configuration.*
import com.algolia.client.extensions.*
import com.algolia.client.model.search.*
import com.algolia.client.transport.*
import com.algolia.utils.*
import io.ktor.http.*
import kotlinx.coroutines.test.*
import kotlinx.serialization.encodeToString
import kotlinx.serialization.json.*
import kotlin.test.*

class SearchTest {

  @Test
  fun `calls api with correct read host`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key")
    client.runTest(
      call = {
        customGet(
          path = "test",
        )
      },
      intercept = {
        assertEquals("test-app-id-dsn.algolia.net", it.url.host)
      },
    )
  }

  @Test
  fun `calls api with correct write host`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key")
    client.runTest(
      call = {
        customPost(
          path = "test",
        )
      },
      intercept = {
        assertEquals("test-app-id.algolia.net", it.url.host)
      },
    )
  }

  @Test
  fun `tests the retry strategy`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6676), Host(url = "localhost", protocol = "http", port = 6677), Host(url = "localhost", protocol = "http", port = 6678))))
    client.runTest(
      call = {
        customGet(
          path = "1/test/retry/kotlin",
        )
      },

      response = {
        val response = Json.encodeToString(it)
        assertEquals("{\"message\":\"ok test server response\"}", response)
      },
    )
  }

  @Test
  fun `test the compression strategy`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6678)), compressionType = CompressionType.GZIP))
    client.runTest(
      call = {
        customPost(
          path = "1/test/gzip",
          parameters = mapOf(),
          body = buildJsonObject {
            put(
              "message",
              JsonPrimitive("this is a compressed body"),
            )
          },
        )
      },

      response = {
        val response = Json.encodeToString(it)
        assertEquals("{\"message\":\"ok compression test server response\",\"body\":{\"message\":\"this is a compressed body\"}}", response)
      },
    )
  }

  @Test
  fun `calls api with correct user agent`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    client.runTest(
      call = {
        customPost(
          path = "1/test",
        )
      },
      intercept = {
        val regexp = "^Algolia for Kotlin \\(\\d+\\.\\d+\\.\\d+(-?.*)?\\)(; [a-zA-Z. ]+ (\\(\\d+((\\.\\d+)?\\.\\d+)?(-?.*)?\\))?)*(; Search (\\(\\d+\\.\\d+\\.\\d+(-?.*)?\\)))(; [a-zA-Z. ]+ (\\(\\d+((\\.\\d+)?\\.\\d+)?(-?.*)?\\))?)*$".toRegex()
        val header = it.headers["User-Agent"].orEmpty()
        assertTrue(actual = header.matches(regexp), message = "Expected $header to match the following regex: $regexp")
      },
    )
  }

  @Test
  fun `calls api with default read timeouts`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    client.runTest(
      call = {
        customGet(
          path = "1/test",
        )
      },
      intercept = {
        assertEquals(2000, it.connectTimeout)
        assertEquals(5000, it.socketTimeout)
      },
    )
  }

  @Test
  fun `calls api with default write timeouts`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    client.runTest(
      call = {
        customPost(
          path = "1/test",
        )
      },
      intercept = {
        assertEquals(2000, it.connectTimeout)
        assertEquals(30000, it.socketTimeout)
      },
    )
  }

  @Test
  fun `generate secured api key basic`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    client.runTest(
      call = {
        generateSecuredApiKey(
          parentApiKey = "2640659426d5107b6e47d75db9cbaef8",
          restrictions = SecuredApiKeyRestrictions(
            validUntil = 2524604400L,
            restrictIndices = listOf("Movies"),
          ),
        )
      },

      response = {
        assertEquals("""NjFhZmE0OGEyMTI3OThiODc0OTlkOGM0YjcxYzljY2M2NmU2NDE5ZWY0NDZjMWJhNjA2NzBkMjAwOTI2YWQyZnJlc3RyaWN0SW5kaWNlcz1Nb3ZpZXMmdmFsaWRVbnRpbD0yNTI0NjA0NDAw""", it)
      },

    )
  }

  @Test
  fun `generate secured api key with searchParams`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    client.runTest(
      call = {
        generateSecuredApiKey(
          parentApiKey = "2640659426d5107b6e47d75db9cbaef8",
          restrictions = SecuredApiKeyRestrictions(
            validUntil = 2524604400L,
            restrictIndices = listOf("Movies", "cts_e2e_settings"),
            restrictSources = "192.168.1.0/24",
            filters = "category:Book OR category:Ebook AND _tags:published",
            userToken = "user123",
            searchParams = SearchParamsObject(
              query = "batman",
              typoTolerance = TypoToleranceEnum.entries.first { it.value == "strict" },
              aroundRadius = AroundRadiusAll.entries.first { it.value == "all" },
              mode = Mode.entries.first { it.value == "neuralSearch" },
              hitsPerPage = 10,
              optionalWords = listOf("one", "two"),
            ),
          ),
        )
      },

      response = {
        assertEquals("""MzAxMDUwYjYyODMxODQ3ZWM1ZDYzNTkxZmNjNDg2OGZjMjAzYjQyOTZhMGQ1NDJhMDFiNGMzYTYzODRhNmMxZWFyb3VuZFJhZGl1cz1hbGwmZmlsdGVycz1jYXRlZ29yeSUzQUJvb2slMjBPUiUyMGNhdGVnb3J5JTNBRWJvb2slMjBBTkQlMjBfdGFncyUzQXB1Ymxpc2hlZCZoaXRzUGVyUGFnZT0xMCZtb2RlPW5ldXJhbFNlYXJjaCZvcHRpb25hbFdvcmRzPW9uZSUyQ3R3byZxdWVyeT1iYXRtYW4mcmVzdHJpY3RJbmRpY2VzPU1vdmllcyUyQ2N0c19lMmVfc2V0dGluZ3MmcmVzdHJpY3RTb3VyY2VzPTE5Mi4xNjguMS4wJTJGMjQmdHlwb1RvbGVyYW5jZT1zdHJpY3QmdXNlclRva2VuPXVzZXIxMjMmdmFsaWRVbnRpbD0yNTI0NjA0NDAw""", it)
      },

    )
  }

  @Test
  fun `call replaceAllObjects without error`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6679))))
    client.runTest(
      call = {
        replaceAllObjects(
          indexName = "cts_e2e_replace_all_objects_kotlin",
          objects = listOf(
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("1"),
              )
              put(
                "name",
                JsonPrimitive("Adam"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("2"),
              )
              put(
                "name",
                JsonPrimitive("Benoit"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("3"),
              )
              put(
                "name",
                JsonPrimitive("Cyril"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("4"),
              )
              put(
                "name",
                JsonPrimitive("David"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("5"),
              )
              put(
                "name",
                JsonPrimitive("Eva"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("6"),
              )
              put(
                "name",
                JsonPrimitive("Fiona"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("7"),
              )
              put(
                "name",
                JsonPrimitive("Gael"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("8"),
              )
              put(
                "name",
                JsonPrimitive("Hugo"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("9"),
              )
              put(
                "name",
                JsonPrimitive("Igor"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("10"),
              )
              put(
                "name",
                JsonPrimitive("Julia"),
              )
            },
          ),
          batchSize = 3,
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""{"copyOperationResponse":{"taskID":125,"updatedAt":"2021-01-01T00:00:00.000Z"},"batchResponses":[{"taskID":127,"objectIDs":["1","2","3"]},{"taskID":130,"objectIDs":["4","5","6"]},{"taskID":133,"objectIDs":["7","8","9"]},{"taskID":134,"objectIDs":["10"]}],"moveOperationResponse":{"taskID":777,"updatedAt":"2021-01-01T00:00:00.000Z"}}""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `call saveObjects without error`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6680))))
    client.runTest(
      call = {
        saveObjects(
          indexName = "cts_e2e_saveObjects_kotlin",
          objects = listOf(
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("1"),
              )
              put(
                "name",
                JsonPrimitive("Adam"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("2"),
              )
              put(
                "name",
                JsonPrimitive("Benoit"),
              )
            },
          ),
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""[{"taskID":333,"objectIDs":["1","2"]}]""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `call partialUpdateObjects with createIfNotExists=true`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6680))))
    client.runTest(
      call = {
        partialUpdateObjects(
          indexName = "cts_e2e_partialUpdateObjects_kotlin",
          objects = listOf(
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("1"),
              )
              put(
                "name",
                JsonPrimitive("Adam"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("2"),
              )
              put(
                "name",
                JsonPrimitive("Benoit"),
              )
            },
          ),
          createIfNotExists = true,
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""[{"taskID":444,"objectIDs":["1","2"]}]""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `call partialUpdateObjects with createIfNotExists=false`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6680))))
    client.runTest(
      call = {
        partialUpdateObjects(
          indexName = "cts_e2e_partialUpdateObjects_kotlin",
          objects = listOf(
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("3"),
              )
              put(
                "name",
                JsonPrimitive("Cyril"),
              )
            },
            buildJsonObject {
              put(
                "objectID",
                JsonPrimitive("4"),
              )
              put(
                "name",
                JsonPrimitive("David"),
              )
            },
          ),
          createIfNotExists = false,
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""[{"taskID":555,"objectIDs":["3","4"]}]""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `call deleteObjects without error`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6680))))
    client.runTest(
      call = {
        deleteObjects(
          indexName = "cts_e2e_deleteObjects_kotlin",
          objectIDs = listOf("1", "2"),
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""[{"taskID":666,"objectIDs":["1","2"]}]""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `wait for api key helper - add`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6681))))
    client.runTest(
      call = {
        waitForApiKey(
          key = "api-key-add-operation-test-kotlin",
          operation = ApiKeyOperation.entries.first { it.value == "add" },
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""{"value":"api-key-add-operation-test-kotlin","description":"my new api key","acl":["search","addObject"],"validity":300,"maxQueriesPerIPPerHour":100,"maxHitsPerQuery":20,"createdAt":1720094400}""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `wait for api key - update`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6681))))
    client.runTest(
      call = {
        waitForApiKey(
          key = "api-key-update-operation-test-kotlin",
          operation = ApiKeyOperation.entries.first { it.value == "update" },
          apiKey = ApiKey(
            description = "my updated api key",
            acl = listOf(Acl.entries.first { it.value == "search" }, Acl.entries.first { it.value == "addObject" }, Acl.entries.first { it.value == "deleteObject" }),
            indexes = listOf("Movies", "Books"),
            referers = listOf("*google.com", "*algolia.com"),
            validity = 305,
            maxQueriesPerIPPerHour = 95,
            maxHitsPerQuery = 20,
          ),
        )
      },

      response = {
        assertNotNull(it)
        val expected = Json.parseToJsonElement("""{"value":"api-key-update-operation-test-kotlin","description":"my updated api key","acl":["search","addObject","deleteObject"],"indexes":["Movies","Books"],"referers":["*google.com","*algolia.com"],"validity":305,"maxQueriesPerIPPerHour":95,"maxHitsPerQuery":20,"createdAt":1720094400}""")
        val actual = Json.encodeToJsonElement(it)
        areJsonElementsEqual(expected, actual)
      },

    )
  }

  @Test
  fun `wait for api key - delete`() = runTest {
    val client = SearchClient(appId = "test-app-id", apiKey = "test-api-key", options = ClientOptions(hosts = listOf(Host(url = "localhost", protocol = "http", port = 6681))))
    client.runTest(
      call = {
        waitForApiKey(
          key = "api-key-delete-operation-test-kotlin",
          operation = ApiKeyOperation.entries.first { it.value == "delete" },
        )
      },

      response = {
        assertNull(it)
      },

    )
  }

  @Test
  fun `client throws with invalid parameters`() = runTest {
    assertFails {
      val client = SearchClient(appId = "", apiKey = "")
    }.let { error -> assertError(error, "`appId` is missing.") }
    assertFails {
      val client = SearchClient(appId = "", apiKey = "my-api-key")
    }.let { error -> assertError(error, "`appId` is missing.") }
    assertFails {
      val client = SearchClient(appId = "my-app-id", apiKey = "")
    }.let { error -> assertError(error, "`apiKey` is missing.") }
  }

  @Test
  fun `'addApiKey' throws with invalid parameters`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    assertFails {
      client.addApiKey(
        apiKey = empty(),
      )
    }.let { error -> assertError(error, "Parameter `apiKey` is required when calling `addApiKey`.") }
  }

  @Test
  fun `'addOrUpdateObject' throws with invalid parameters`() = runTest {
    val client = SearchClient(appId = "appId", apiKey = "apiKey")
    assertFails {
      client.addOrUpdateObject(
        indexName = empty(),
        objectID = "my-object-id",
        body = buildJsonObject {
        },
      )
    }.let { error -> assertError(error, "Parameter `indexName` is required when calling `addOrUpdateObject`.") }
    assertFails {
      client.addOrUpdateObject(
        indexName = "my-index-name",
        objectID = empty(),
        body = buildJsonObject {
        },
      )
    }.let { error -> assertError(error, "Parameter `objectID` is required when calling `addOrUpdateObject`.") }
    assertFails {
      client.addOrUpdateObject(
        indexName = "my-index-name",
        objectID = "my-object-id",
        body = empty(),
      )
    }.let { error -> assertError(error, "Parameter `body` is required when calling `addOrUpdateObject`.") }
  }
}
