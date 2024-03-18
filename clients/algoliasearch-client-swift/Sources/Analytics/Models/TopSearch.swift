// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

public struct TopSearch: Codable, JSONEncodable, Hashable {
    /// User query.
    public var search: String
    /// Number of tracked _and_ untracked searches (where the `clickAnalytics` parameter isn't `true`).
    public var count: Int
    /// Number of results (hits).
    public var nbHits: Int

    public init(search: String, count: Int, nbHits: Int) {
        self.search = search
        self.count = count
        self.nbHits = nbHits
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case search
        case count
        case nbHits
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encode(self.search, forKey: .search)
        try container.encode(self.count, forKey: .count)
        try container.encode(self.nbHits, forKey: .nbHits)
    }
}
