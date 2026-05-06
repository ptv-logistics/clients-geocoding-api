
# ReferencePosition

The actual position of the object itself, such as the rooftop of a building, the center of a street, or the reference position of a city.

## Properties

Name | Type
------------ | -------------
`latitude` | number
`longitude` | number

## Example

```typescript
import type { ReferencePosition } from ''

// TODO: Update the object below with actual values
const example = {
  "latitude": null,
  "longitude": null,
} satisfies ReferencePosition

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as ReferencePosition
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


