
# Area

Defines the area as [GeoJSON](https://datatracker.ietf.org/doc/html/rfc7946) geometry. Supported geometry types are Polygon and MultiPolygon. Geometries that cause too long processing times will be rejected. In this case an error response is returned that explains the reason.

## Properties

Name | Type
------------ | -------------
`geometry` | string

## Example

```typescript
import type { Area } from ''

// TODO: Update the object below with actual values
const example = {
  "geometry": null,
} satisfies Area

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as Area
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


