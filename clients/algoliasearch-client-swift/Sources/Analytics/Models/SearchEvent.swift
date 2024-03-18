// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

public struct SearchEvent: Codable, JSONEncodable, Hashable {
    /// Date of the event in the format YYYY-MM-DD.
    public var date: String
    /// Number of occurrences.
    public var count: Int

    public init(date: String, count: Int) {
        self.date = date
        self.count = count
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case date
        case count
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encode(self.date, forKey: .date)
        try container.encode(self.count, forKey: .count)
    }
}
