
# Quality

Quality indicators that help deciding how well a result fits to the search input.

## Properties

Name | Type
------------ | -------------
`distance` | number
`totalScore` | number
`addressScores` | [AddressScores](AddressScores.md)

## Example

```typescript
import type { Quality } from ''

// TODO: Update the object below with actual values
const example = {
  "distance": null,
  "totalScore": null,
  "addressScores": null,
} satisfies Quality

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as Quality
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


