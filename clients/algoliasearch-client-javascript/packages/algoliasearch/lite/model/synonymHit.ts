// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import type { SynonymType } from './synonymType';

/**
 * Synonym object.
 */
export type SynonymHit = {
  /**
   * Unique identifier of a synonym object.
   */
  objectID: string;

  type: SynonymType;

  /**
   * Words or phrases considered equivalent.
   */
  synonyms?: string[];

  /**
   * Word or phrase to appear in query strings (for [`onewaysynonym`s](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/one-way-synonyms/)).
   */
  input?: string;

  /**
   * Word or phrase to appear in query strings (for [`altcorrection1` and `altcorrection2`](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-alternative-corrections/)).
   */
  word?: string;

  /**
   * Words to be matched in records.
   */
  corrections?: string[];

  /**
   * [Placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders/) to be put inside records.
   */
  placeholder?: string;

  /**
   * Query words that will match the [placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders/).
   */
  replacements?: string[];
};
