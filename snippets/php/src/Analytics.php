<?php

// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

namespace Algolia\AlgoliaSearch\Snippets;

// >IMPORT
use Algolia\AlgoliaSearch\Api\AnalyticsClient;

// IMPORT<

class SnippetAnalyticsClient
{
    /**
     * Snippet for the CustomDelete method.
     *
     * allow del method for a custom path with minimal parameters
     */
    public function snippetForCustomDelete(): void
    {
        // >SEPARATOR customDelete default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->customDelete(
            'test/minimal',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the CustomGet method.
     *
     * allow get method for a custom path with minimal parameters
     */
    public function snippetForCustomGet(): void
    {
        // >SEPARATOR customGet default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->customGet(
            'test/minimal',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the CustomPost method.
     *
     * allow post method for a custom path with minimal parameters
     */
    public function snippetForCustomPost(): void
    {
        // >SEPARATOR customPost default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->customPost(
            'test/minimal',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the CustomPut method.
     *
     * allow put method for a custom path with minimal parameters
     */
    public function snippetForCustomPut(): void
    {
        // >SEPARATOR customPut default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->customPut(
            'test/minimal',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetAddToCartRate method.
     *
     * get getAddToCartRate with minimal parameters
     */
    public function snippetForGetAddToCartRate(): void
    {
        // >SEPARATOR getAddToCartRate default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getAddToCartRate(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetAverageClickPosition method.
     *
     * get getAverageClickPosition with minimal parameters
     */
    public function snippetForGetAverageClickPosition(): void
    {
        // >SEPARATOR getAverageClickPosition default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getAverageClickPosition(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetClickPositions method.
     *
     * get getClickPositions with minimal parameters
     */
    public function snippetForGetClickPositions(): void
    {
        // >SEPARATOR getClickPositions default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getClickPositions(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetClickThroughRate method.
     *
     * get getClickThroughRate with minimal parameters
     */
    public function snippetForGetClickThroughRate(): void
    {
        // >SEPARATOR getClickThroughRate default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getClickThroughRate(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetConversionRate method.
     *
     * get getConversationRate with minimal parameters
     */
    public function snippetForGetConversionRate(): void
    {
        // >SEPARATOR getConversionRate default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getConversionRate(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetNoClickRate method.
     *
     * get getNoClickRate with minimal parameters
     */
    public function snippetForGetNoClickRate(): void
    {
        // >SEPARATOR getNoClickRate default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getNoClickRate(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetNoResultsRate method.
     *
     * get getNoResultsRate with minimal parameters
     */
    public function snippetForGetNoResultsRate(): void
    {
        // >SEPARATOR getNoResultsRate default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getNoResultsRate(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetPurchaseRate method.
     *
     * get getPurchaseRate with minimal parameters
     */
    public function snippetForGetPurchaseRate(): void
    {
        // >SEPARATOR getPurchaseRate default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getPurchaseRate(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetRevenue method.
     *
     * get getRevenue with minimal parameters
     */
    public function snippetForGetRevenue(): void
    {
        // >SEPARATOR getRevenue default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getRevenue(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetSearchesCount method.
     *
     * get getSearchesCount with minimal parameters
     */
    public function snippetForGetSearchesCount(): void
    {
        // >SEPARATOR getSearchesCount default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getSearchesCount(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetSearchesNoClicks method.
     *
     * get getSearchesNoClicks with minimal parameters
     */
    public function snippetForGetSearchesNoClicks(): void
    {
        // >SEPARATOR getSearchesNoClicks default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getSearchesNoClicks(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetSearchesNoResults method.
     *
     * get getSearchesNoResults with minimal parameters
     */
    public function snippetForGetSearchesNoResults(): void
    {
        // >SEPARATOR getSearchesNoResults default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getSearchesNoResults(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetStatus method.
     *
     * get getStatus with minimal parameters
     */
    public function snippetForGetStatus(): void
    {
        // >SEPARATOR getStatus default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getStatus(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetTopCountries method.
     *
     * get getTopCountries with minimal parameters
     */
    public function snippetForGetTopCountries(): void
    {
        // >SEPARATOR getTopCountries default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getTopCountries(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetTopFilterAttributes method.
     *
     * get getTopFilterAttributes with minimal parameters
     */
    public function snippetForGetTopFilterAttributes(): void
    {
        // >SEPARATOR getTopFilterAttributes default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getTopFilterAttributes(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetTopFilterForAttribute method.
     *
     * get getTopFilterForAttribute with minimal parameters
     */
    public function snippetForGetTopFilterForAttribute(): void
    {
        // >SEPARATOR getTopFilterForAttribute default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getTopFilterForAttribute(
            'myAttribute',
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetTopFiltersNoResults method.
     *
     * get getTopFiltersNoResults with minimal parameters
     */
    public function snippetForGetTopFiltersNoResults(): void
    {
        // >SEPARATOR getTopFiltersNoResults default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getTopFiltersNoResults(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetTopHits method.
     *
     * get getTopHits with minimal parameters
     */
    public function snippetForGetTopHits(): void
    {
        // >SEPARATOR getTopHits default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getTopHits(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetTopSearches method.
     *
     * get getTopSearches with minimal parameters
     */
    public function snippetForGetTopSearches(): void
    {
        // >SEPARATOR getTopSearches default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getTopSearches(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the GetUsersCount method.
     *
     * get getUsersCount with minimal parameters
     */
    public function snippetForGetUsersCount(): void
    {
        // >SEPARATOR getUsersCount default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $response = $client->getUsersCount(
            'index',
        );

        // >LOG
        // play with the response
        var_dump($response);
        // SEPARATOR<
    }

    /**
     * Snippet for the SetClientApiKey method.
     *
     * switch API key
     */
    public function snippetForSetClientApiKey(): void
    {
        // >SEPARATOR setClientApiKey default
        // Initialize the client
        $client = AnalyticsClient::create('ALGOLIA_APPLICATION_ID', 'ALGOLIA_API_KEY', 'ALGOLIA_APPLICATION_REGION');

        // Call the API
        $client->setClientApiKey(
            'updated-api-key',
        );

        // >LOG
        // SEPARATOR<
    }
}
