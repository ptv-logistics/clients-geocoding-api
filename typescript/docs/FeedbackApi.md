# FeedbackApi

All URIs are relative to *https://api.myptv.com/geocoding/v1*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**provideFeedback**](FeedbackApi.md#providefeedback) | **POST** /feedback |  |



## provideFeedback

> provideFeedback(feedbackId)



Provides feedback about which location or place was considered to be the best match in an array obtained for the corresponding input address, position, or text. This is a fire and forget operation.     This endpoint is experimental and may change at any time in the future.

### Example

```ts
import {
  Configuration,
  FeedbackApi,
} from '';
import type { ProvideFeedbackRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new FeedbackApi(config);

  const body = {
    // string | A unique identifier for a location or a place in UUID format that can be used to provide feedback.
    feedbackId: 38400000-8cf0-11bd-b23e-10b96e4ef00d,
  } satisfies ProvideFeedbackRequest;

  try {
    const data = await api.provideFeedback(body);
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
| **feedbackId** | `string` | A unique identifier for a location or a place in UUID format that can be used to provide feedback. | [Defaults to `undefined`] |

### Return type

`void` (Empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

