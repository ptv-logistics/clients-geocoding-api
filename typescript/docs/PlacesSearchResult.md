
# PlacesSearchResult

The result of a places search.

## Properties

Name | Type
------------ | -------------
`places` | [Array&lt;Place&gt;](Place.md)
`noMatchFeedbackId` | string
`warnings` | [Array&lt;Warning&gt;](Warning.md)

## Example

```typescript
import type { PlacesSearchResult } from ''

// TODO: Update the object below with actual values
const example = {
  "places": null,
  "noMatchFeedbackId": null,
  "warnings": null,
} satisfies PlacesSearchResult

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as PlacesSearchResult
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


