// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

/// The type of log entry.   - &#x60;SKIP&#x60;. A query is skipped because it doesn&#39;t match the conditions for
/// successful inclusion. For example, when a query doesn&#39;t generate enough search results. - &#x60;INFO&#x60;. An
/// informative log entry. - &#x60;ERROR&#x60;. The Query Suggestions process encountered an error.
public enum ModelLogLevel: String, Codable, CaseIterable {
    case skip = "SKIP"
    case info = "INFO"
    case error = "ERROR"
}
