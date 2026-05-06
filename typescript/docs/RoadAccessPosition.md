
# RoadAccessPosition

A position on or very close to a road that marks the entry to the object. Available only for objects which represent buildings with a complete address and only if present in the data.    The road from which the object can be accessed is not necessarily the road which is closest to the object.

## Properties

Name | Type
------------ | -------------
`latitude` | number
`longitude` | number

## Example

```typescript
import type { RoadAccessPosition } from ''

// TODO: Update the object below with actual values
const example = {
  "latitude": null,
  "longitude": null,
} satisfies RoadAccessPosition

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as RoadAccessPosition
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


