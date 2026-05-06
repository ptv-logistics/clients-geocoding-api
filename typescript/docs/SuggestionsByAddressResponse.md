
# SuggestionsByAddressResponse

The list of suggested addresses.

## Properties

Name | Type
------------ | -------------
`suggestions` | [Array&lt;SuggestedAddress&gt;](SuggestedAddress.md)
`warnings` | [Array&lt;Warning&gt;](Warning.md)

## Example

```typescript
import type { SuggestionsByAddressResponse } from ''

// TODO: Update the object below with actual values
const example = {
  "suggestions": null,
  "warnings": null,
} satisfies SuggestionsByAddressResponse

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as SuggestionsByAddressResponse
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


