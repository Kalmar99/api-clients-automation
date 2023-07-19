// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import type { Anchoring } from './anchoring';

/**
 * Rules search parameters.
 */
export type SearchRulesParams = {
  /**
   * Rule object query.
   */
  query?: string;

  anchoring?: Anchoring;

  /**
   * Restricts responses to the specified [contextual rule](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#creating-contextual-rules).
   */
  context?: string;

  /**
   * Requested page (the first page is page 0).
   */
  page?: number;

  /**
   * Maximum number of hits per page.
   */
  hitsPerPage?: number;

  /**
   * Restricts responses to enabled rules. When not specified (default), _all_ rules are retrieved.
   */
  enabled?: boolean | null;

  /**
   * Request options to send with the API call.
   */
  requestOptions?: Array<Record<string, any>>;
};
