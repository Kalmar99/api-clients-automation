// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

public struct LatencyResponseMetrics: Codable, JSONEncodable, Hashable {
    public var latency: [String: [TimeInner]]?

    public init(latency: [String: [TimeInner]]? = nil) {
        self.latency = latency
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case latency
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encodeIfPresent(self.latency, forKey: .latency)
    }
}
