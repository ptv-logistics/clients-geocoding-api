# PlacesApi

All URIs are relative to *https://api.myptv.com/geocoding/v1*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**searchPlacesByArea**](PlacesApi.md#searchplacesbyarea) | **POST** /places/by-area |  |
| [**searchPlacesByPosition**](PlacesApi.md#searchplacesbyposition) | **GET** /places/by-position/{latitude}/{longitude} |  |
| [**searchPlacesByText**](PlacesApi.md#searchplacesbytext) | **GET** /places/by-text |  |



## searchPlacesByArea

> PlacesSearchResult searchPlacesByArea(placesByAreaRequest, categoryFilter, language)



Searches for places within a requested area.

### Example

```ts
import {
  Configuration,
  PlacesApi,
} from '';
import type { SearchPlacesByAreaRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new PlacesApi(config);

  const body = {
    // PlacesByAreaRequest
    placesByAreaRequest: ...,
    // Array<string> | A comma-separated list of place category IDs. Only results having one of these categories will be returned. If no filter is specified, all categories will be returned. However, empty values are not allowed. (optional)
    categoryFilter: ["navteq-lcms:700-7200-0328","navteq-lcms:700-7400-0292"],
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
  } satisfies SearchPlacesByAreaRequest;

  try {
    const data = await api.searchPlacesByArea(body);
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
| **placesByAreaRequest** | [PlacesByAreaRequest](PlacesByAreaRequest.md) |  | |
| **categoryFilter** | `Array<string>` | A comma-separated list of place category IDs. Only results having one of these categories will be returned. If no filter is specified, all categories will be returned. However, empty values are not allowed. | [Optional] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |

### Return type

[**PlacesSearchResult**](PlacesSearchResult.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## searchPlacesByPosition

> PlacesSearchResult searchPlacesByPosition(latitude, longitude, radius, categoryFilter, limit, language)



Searches for places near a given geographical position.

### Example

```ts
import {
  Configuration,
  PlacesApi,
} from '';
import type { SearchPlacesByPositionRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new PlacesApi(config);

  const body = {
    // number
    latitude: 1.2,
    // number
    longitude: 1.2,
    // number | The search radius [m] around the given position. (optional)
    radius: 56,
    // Array<string> | A comma-separated list of place category IDs. Only results having one of these categories will be returned. If no filter is specified, all categories will be returned. However, empty values are not allowed. (optional)
    categoryFilter: ["navteq-lcms:700-7200-0328","navteq-lcms:700-7400-0292"],
    // number | Limits the number of results that are returned. (optional)
    limit: 56,
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
  } satisfies SearchPlacesByPositionRequest;

  try {
    const data = await api.searchPlacesByPosition(body);
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
| **radius** | `number` | The search radius [m] around the given position. | [Optional] [Defaults to `1000`] |
| **categoryFilter** | `Array<string>` | A comma-separated list of place category IDs. Only results having one of these categories will be returned. If no filter is specified, all categories will be returned. However, empty values are not allowed. | [Optional] |
| **limit** | `number` | Limits the number of results that are returned. | [Optional] [Defaults to `5`] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |

### Return type

[**PlacesSearchResult**](PlacesSearchResult.md)

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


## searchPlacesByText

> PlacesSearchResult searchPlacesByText(searchText, categoryFilter, countryFilter, language, center, radius, boundingBox)



Searches for places based on a single-field text input.

### Example

```ts
import {
  Configuration,
  PlacesApi,
} from '';
import type { SearchPlacesByTextRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new PlacesApi(config);

  const body = {
    // string | Free-form text input that describes a place.
    searchText: searchText_example,
    // Array<string> | A comma-separated list of place category IDs. Only results having one of these categories will be returned. If no filter is specified, all categories will be returned. However, empty values are not allowed. (optional)
    categoryFilter: ["navteq-lcms:700-7200-0328","navteq-lcms:700-7400-0292"],
    // Array<string> | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** `GEOCODING_COUNTRY_FILTER_MODIFIED` is returned with the response. (optional)
    countryFilter: ["DE","FR"],
    // string | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. (optional)
    language: en,
    // Array<number> | Defines a circular search context. The format of the `center` parameter is a comma-separated pair of double values setting the latitude and longitude, i. e. `<lat>,<lon>`. The values for the latitude from south to north between -90 and 90 and for the longitude between -180 and 180 from west to east are in degrees (WGS84/EPSG:4326). A certain radius around the center is considered and this can be adapted by setting the parameter `radius` in addition. Note: The parameters `center` respectively `radius` and `boundingBox` (if available) are mutually exclusive. (optional)
    center: [49.0131,8.4279],
    // number | The search radius [m] around the given position. (optional)
    radius: 56,
    // Array<number> | Defines a rectangular search context. The format of the `boundingBox` parameter is a comma-separated list of double values setting the maximum latitude _top_, the minimum longitude _left_, the minimum latitude _bottom_ and the maximum longitude _right_, i. e. `<top>,<left>,<bottom>,<right>`. The values for _top_ and _bottom_ from south to north between -90 and 90 as well as for _left_ and _right_ between -180 and 180 from west to east are in degrees (WGS84/EPSG:4326). Note: The parameters `boundingBox` and `center` respectively `radius` are mutually exclusive. (optional)
    boundingBox: [49.0135,8.4279,49.0124,8.4308],
  } satisfies SearchPlacesByTextRequest;

  try {
    const data = await api.searchPlacesByText(body);
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
| **searchText** | `string` | Free-form text input that describes a place. | [Defaults to `undefined`] |
| **categoryFilter** | `Array<string>` | A comma-separated list of place category IDs. Only results having one of these categories will be returned. If no filter is specified, all categories will be returned. However, empty values are not allowed. | [Optional] |
| **countryFilter** | `Array<string>` | A comma-separated list of country codes according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision. The search will only consider data from countries with these codes. If no filter is specified, all countries are taken into account. However, empty values are not allowed.     If a given subdivision code is not supported, only the first two digits referring to the country are considered in the search and a **warningCode** &#x60;GEOCODING_COUNTRY_FILTER_MODIFIED&#x60; is returned with the response. | [Optional] |
| **language** | `string` | The preferred language for the response formatted according to [ISO-639-1](https://www.loc.gov/standards/iso639-2/php/code_list.php) for languages or [BCP47](https://tools.ietf.org/html/bcp47) for language variants. By default the service uses the language spoken in the country or region of the result. In case the given preferred language is not available in the data, the default language is used. | [Optional] [Defaults to `undefined`] |
| **center** | `Array<number>` | Defines a circular search context. The format of the &#x60;center&#x60; parameter is a comma-separated pair of double values setting the latitude and longitude, i. e. &#x60;&lt;lat&gt;,&lt;lon&gt;&#x60;. The values for the latitude from south to north between -90 and 90 and for the longitude between -180 and 180 from west to east are in degrees (WGS84/EPSG:4326). A certain radius around the center is considered and this can be adapted by setting the parameter &#x60;radius&#x60; in addition. Note: The parameters &#x60;center&#x60; respectively &#x60;radius&#x60; and &#x60;boundingBox&#x60; (if available) are mutually exclusive. | [Optional] |
| **radius** | `number` | The search radius [m] around the given position. | [Optional] [Defaults to `1000`] |
| **boundingBox** | `Array<number>` | Defines a rectangular search context. The format of the &#x60;boundingBox&#x60; parameter is a comma-separated list of double values setting the maximum latitude _top_, the minimum longitude _left_, the minimum latitude _bottom_ and the maximum longitude _right_, i. e. &#x60;&lt;top&gt;,&lt;left&gt;,&lt;bottom&gt;,&lt;right&gt;&#x60;. The values for _top_ and _bottom_ from south to north between -90 and 90 as well as for _left_ and _right_ between -180 and 180 from west to east are in degrees (WGS84/EPSG:4326). Note: The parameters &#x60;boundingBox&#x60; and &#x60;center&#x60; respectively &#x60;radius&#x60; are mutually exclusive. | [Optional] |

### Return type

[**PlacesSearchResult**](PlacesSearchResult.md)

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

