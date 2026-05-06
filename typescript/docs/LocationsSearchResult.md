
# LocationsSearchResult

The result of a locations search.

## Properties

Name | Type
------------ | -------------
`locations` | [Array&lt;Location&gt;](Location.md)
`noMatchFeedbackId` | string
`warnings` | [Array&lt;Warning&gt;](Warning.md)

## Example

```typescript
import type { LocationsSearchResult } from ''

// TODO: Update the object below with actual values
const example = {
  "locations": null,
  "noMatchFeedbackId": null,
  "warnings": null,
} satisfies LocationsSearchResult

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as LocationsSearchResult
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


