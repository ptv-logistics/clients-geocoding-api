# LocationsApi

All URIs are relative to *https://api.myptv.com/geocoding/v1*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**getSuggestionsByAddress**](LocationsApi.md#getsuggestionsbyaddress) | **GET** /suggestions/by-address |  |
| [**getSuggestionsByText**](LocationsApi.md#getsuggestionsbytext) | **GET** /suggestions/by-text |  |
| [**searchLocationsByAddress**](LocationsApi.md#searchlocationsbyaddress) | **GET** /locations/by-address |  |
| [**searchLocationsByPosition**](LocationsApi.md#searchlocationsbyposition) | **GET** /locations/by-position/{latitude}/{longitude} |  |
| [**searchLocationsByText**](LocationsApi.md#searchlocationsbytext) | **GET** /locations/by-text |  |



## getSuggestionsByAddress

> SuggestionsByAddressResponse getSuggestionsByAddress(inputField, country, state, locality, postalCode, street, houseNumber, language)



Gets suggestions for the address input of the searchLocationsByAddress endpoint.

### Example

```ts
import {
  Configuration,
  LocationsApi,
} from '';
import type { GetSuggestionsByAddressRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new LocationsApi(config);

  const body = {
    // InputField | Used to specify for which parameter of the suggestions/by-address request a suggestion is desired.
    inputField: ...,
    // string | The country or its initial characters to which the suggestion search is limited. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate. (optional)
    country: country_example,
    // string | The state or its initial characters to which the suggestion search is limited. A state is a subdivision of a country, for example a real state, a region or a province. (optional)
    state: state_example,
    // string | The locality or its initial characters to which the suggestion search is limited. The locality may be a city, a district or subdistrict. (optional)
    locality: locality_example,
    // string | The postal code or zip-code or its initial characters to which the suggestion search is limited. (optional)
    postalCode: postalCode_example,
    // string | The name of the road or its initial characters to which the suggestion search is limited. It must not contain additional information like building names, floor numbers or apartment numbers. (optional)
    street: street_example,
    // string | The house number or its initial characters to which the suggestion search is limited. If only a space is given, a list of all house numbers in the specified street will be suggested. Suggestions for house numbers are only provided if a street is specified. (optional)
    houseNumber: houseNumber_example,
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
  } satisfies GetSuggestionsByAddressRequest;

  try {
    const data = await api.getSuggestionsByAddress(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **inputField** | `InputField` | Used to specify for which parameter of the suggestions/by-address request a suggestion is desired. | [Defaults to `undefined`] [Enum: COUNTRY, STATE, POSTAL_CODE, LOCALITY, STREET, HOUSE_NUMBER] |
| **country** | `string` | The country or its initial characters to which the suggestion search is limited. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate. | [Optional] [Defaults to `undefined`] |
| **state** | `string` | The state or its initial characters to which the suggestion search is limited. A state is a subdivision of a country, for example a real state, a region or a province. | [Optional] [Defaults to `undefined`] |
| **locality** | `string` | The locality or its initial characters to which the suggestion search is limited. The locality may be a city, a district or subdistrict. | [Optional] [Defaults to `undefined`] |
| **postalCode** | `string` | The postal code or zip-code or its initial characters to which the suggestion search is limited. | [Optional] [Defaults to `undefined`] |
| **street** | `string` | The name of the road or its initial characters to which the suggestion search is limited. It must not contain additional information like building names, floor numbers or apartment numbers. | [Optional] [Defaults to `undefined`] |
| **houseNumber** | `string` | The house number or its initial characters to which the suggestion search is limited. If only a space is given, a list of all house numbers in the specified street will be suggested. Suggestions for house numbers are only provided if a street is specified. | [Optional] [Defaults to `undefined`] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |

### Return type

[**SuggestionsByAddressResponse**](SuggestionsByAddressResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## getSuggestionsByText

> SuggestionsByTextResponse getSuggestionsByText(searchText, countryFilter, center, language)



Gets suggestions for the input of the searchLocationsByText endpoint.  This method is in a preview state. It is stable, but feature changes could be introduced in the future.

### Example

```ts
import {
  Configuration,
  LocationsApi,
} from '';
import type { GetSuggestionsByTextRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new LocationsApi(config);

  const body = {
    // string | Free-form text input that partially describes a location.
    searchText: searchText_example,
    // Array<string> | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** `GEOCODING_COUNTRY_FILTER_MODIFIED` is returned with the response. (optional)
    countryFilter: ["DE","FR"],
    // Array<number> | Defines a search center. The format of the `center` parameter is a comma-separated pair of double values setting the latitude and longitude, i. e. `<lat>,<lon>`. The values for the latitude from south to north between -90 and 90 and for the longitude between -180 and 180 from west to east are in degrees (WGS84/EPSG:4326). (optional)
    center: [49.0131,8.4279],
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
  } satisfies GetSuggestionsByTextRequest;

  try {
    const data = await api.getSuggestionsByText(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **searchText** | `string` | Free-form text input that partially describes a location. | [Defaults to `undefined`] |
| **countryFilter** | `Array<string>` | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** &#x60;GEOCODING_COUNTRY_FILTER_MODIFIED&#x60; is returned with the response. | [Optional] |
| **center** | `Array<number>` | Defines a search center. The format of the &#x60;center&#x60; parameter is a comma-separated pair of double values setting the latitude and longitude, i. e. &#x60;&lt;lat&gt;,&lt;lon&gt;&#x60;. The values for the latitude from south to north between -90 and 90 and for the longitude between -180 and 180 from west to east are in degrees (WGS84/EPSG:4326). | [Optional] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |

### Return type

[**SuggestionsByTextResponse**](SuggestionsByTextResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## searchLocationsByAddress

> LocationsSearchResult searchLocationsByAddress(country, state, locality, postalCode, street, houseNumber, countryFilter, language, results, totalScoreType)



Searches for locations based on a multi-field address input.

### Example

```ts
import {
  Configuration,
  LocationsApi,
} from '';
import type { SearchLocationsByAddressRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new LocationsApi(config);

  const body = {
    // string | The country in which the locations should be searched. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate. (optional)
    country: country_example,
    // string | A subdivision of a country, for example a state, a region or a province. Using this field narrows down the search and reduces the number of possible results. (optional)
    state: state_example,
    // string | The locality of the address, which may be a city, a district or subdistrict. (optional)
    locality: locality_example,
    // string | The postal code, or zip-code, which is used by a postal authority of a country to identify where the address is located. (optional)
    postalCode: postalCode_example,
    // string | The name of the road where the address is located. It must not contain additional information like building names, floor numbers or apartment numbers. It may contain a house number, but using the **houseNumber** field instead will lead to better results. (optional)
    street: street_example,
    // string | The house number of the address. (optional)
    houseNumber: houseNumber_example,
    // Array<string> | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** `GEOCODING_COUNTRY_FILTER_MODIFIED` is returned with the response. (optional)
    countryFilter: ["DE","FR"],
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
    // Array<Results> | Comma-separated list that defines which results will be returned.  * `ADDRESS_SCORES` - Populate **location.quality.addressScores**. (optional)
    results: ["ADDRESS_SCORES"],
    // TotalScoreType | Defines how Location.quality.totalScore is calculated.    * `INPUT_AND_RESULT_BASED` - The total score is calculated by comparing the result against the input.    * `RESULT_BASED` - The total score is calculated by classifying result attributes.      This parameter is experimental and may change at any time in the future. (optional)
    totalScoreType: ...,
  } satisfies SearchLocationsByAddressRequest;

  try {
    const data = await api.searchLocationsByAddress(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **country** | `string` | The country in which the locations should be searched. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate. | [Optional] [Defaults to `undefined`] |
| **state** | `string` | A subdivision of a country, for example a state, a region or a province. Using this field narrows down the search and reduces the number of possible results. | [Optional] [Defaults to `undefined`] |
| **locality** | `string` | The locality of the address, which may be a city, a district or subdistrict. | [Optional] [Defaults to `undefined`] |
| **postalCode** | `string` | The postal code, or zip-code, which is used by a postal authority of a country to identify where the address is located. | [Optional] [Defaults to `undefined`] |
| **street** | `string` | The name of the road where the address is located. It must not contain additional information like building names, floor numbers or apartment numbers. It may contain a house number, but using the **houseNumber** field instead will lead to better results. | [Optional] [Defaults to `undefined`] |
| **houseNumber** | `string` | The house number of the address. | [Optional] [Defaults to `undefined`] |
| **countryFilter** | `Array<string>` | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** &#x60;GEOCODING_COUNTRY_FILTER_MODIFIED&#x60; is returned with the response. | [Optional] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |
| **results** | `Array<Results>` | Comma-separated list that defines which results will be returned.  * &#x60;ADDRESS_SCORES&#x60; - Populate **location.quality.addressScores**. | [Optional] |
| **totalScoreType** | `TotalScoreType` | Defines how Location.quality.totalScore is calculated.    * &#x60;INPUT_AND_RESULT_BASED&#x60; - The total score is calculated by comparing the result against the input.    * &#x60;RESULT_BASED&#x60; - The total score is calculated by classifying result attributes.      This parameter is experimental and may change at any time in the future. | [Optional] [Defaults to `undefined`] [Enum: INPUT_AND_RESULT_BASED, RESULT_BASED] |

### Return type

[**LocationsSearchResult**](LocationsSearchResult.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## searchLocationsByPosition

> LocationsSearchResult searchLocationsByPosition(latitude, longitude, language, minimumPopulation)



Searches for locations near a given geographical position.

### Example

```ts
import {
  Configuration,
  LocationsApi,
} from '';
import type { SearchLocationsByPositionRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new LocationsApi(config);

  const body = {
    // number
    latitude: 1.2,
    // number
    longitude: 1.2,
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
    // number | If specified, the response contains only the nearest city or town with at least the given population. The **locationType** of this result will be _LOCALITY_, street information will not be returned.  This parameter is in an experimental state and may change at any time. (optional)
    minimumPopulation: 50000,
  } satisfies SearchLocationsByPositionRequest;

  try {
    const data = await api.searchLocationsByPosition(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **latitude** | `number` |  | [Defaults to `undefined`] |
| **longitude** | `number` |  | [Defaults to `undefined`] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |
| **minimumPopulation** | `number` | If specified, the response contains only the nearest city or town with at least the given population. The **locationType** of this result will be _LOCALITY_, street information will not be returned.  This parameter is in an experimental state and may change at any time. | [Optional] [Defaults to `undefined`] |

### Return type

[**LocationsSearchResult**](LocationsSearchResult.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## searchLocationsByText

> LocationsSearchResult searchLocationsByText(searchText, countryFilter, language, results, cleanInput)



Searches for locations based on a single-field text input.

### Example

```ts
import {
  Configuration,
  LocationsApi,
} from '';
import type { SearchLocationsByTextRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new LocationsApi(config);

  const body = {
    // string | Free-form text input that describes a location.
    searchText: searchText_example,
    // Array<string> | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** `GEOCODING_COUNTRY_FILTER_MODIFIED` is returned with the response. (optional)
    countryFilter: ["DE","FR"],
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
    // Array<Results> | Comma-separated list that defines which results will be returned.  * `ADDRESS_SCORES` - Populate **location.quality.addressScores**. (optional)
    results: ["ADDRESS_SCORES"],
    // boolean | If set to `true`, the service will try (for certain countries) to clean the input in a pre-processing step. This helps to expedite processing if the input is a free-form text that may contain garbage. This flag may influence the scores in the response. For more details see the corresponding [concept](./concepts/clean-input).      This parameter is experimental and may change at any time in the future. (optional)
    cleanInput: true,
  } satisfies SearchLocationsByTextRequest;

  try {
    const data = await api.searchLocationsByText(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **searchText** | `string` | Free-form text input that describes a location. | [Defaults to `undefined`] |
| **countryFilter** | `Array<string>` | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** &#x60;GEOCODING_COUNTRY_FILTER_MODIFIED&#x60; is returned with the response. | [Optional] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |
| **results** | `Array<Results>` | Comma-separated list that defines which results will be returned.  * &#x60;ADDRESS_SCORES&#x60; - Populate **location.quality.addressScores**. | [Optional] |
| **cleanInput** | `boolean` | If set to &#x60;true&#x60;, the service will try (for certain countries) to clean the input in a pre-processing step. This helps to expedite processing if the input is a free-form text that may contain garbage. This flag may influence the scores in the response. For more details see the corresponding [concept](./concepts/clean-input).      This parameter is experimental and may change at any time in the future. | [Optional] [Defaults to `false`] |

### Return type

[**LocationsSearchResult**](LocationsSearchResult.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

