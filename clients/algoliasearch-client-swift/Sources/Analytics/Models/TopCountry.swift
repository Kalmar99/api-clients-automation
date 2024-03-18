// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

public struct TopCountry: Codable, JSONEncodable, Hashable {
    /// Country.
    public var country: String
    /// Number of occurrences.
    public var count: Int

    public init(country: String, count: Int) {
        self.country = country
        self.count = count
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case country
        case count
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encode(self.country, forKey: .country)
        try container.encode(self.count, forKey: .count)
    }
}
