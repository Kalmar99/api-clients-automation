// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

/// Response from the API when the Authentication is successfully created.
public struct AuthenticationCreateResponse: Codable, JSONEncodable, Hashable {
    /// The authentication UUID.
    public var authenticationID: String
    /// An human readable name describing the object.
    public var name: String
    /// Date of creation (RFC3339 format).
    public var createdAt: String

    public init(authenticationID: String, name: String, createdAt: String) {
        self.authenticationID = authenticationID
        self.name = name
        self.createdAt = createdAt
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case authenticationID
        case name
        case createdAt
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encode(self.authenticationID, forKey: .authenticationID)
        try container.encode(self.name, forKey: .name)
        try container.encode(self.createdAt, forKey: .createdAt)
    }
}
