
# Location


## Properties

Name | Type
------------ | -------------
`referencePosition` | [ReferencePosition](ReferencePosition.md)
`roadAccessPosition` | [RoadAccessPosition](RoadAccessPosition.md)
`address` | [Address](Address.md)
`formattedAddress` | string
`feedbackId` | string
`locationType` | [LocationType](LocationType.md)
`quality` | [Quality](Quality.md)

## Example

```typescript
import type { Location } from ''

// TODO: Update the object below with actual values
const example = {
  "referencePosition": null,
  "roadAccessPosition": null,
  "address": null,
  "formattedAddress": null,
  "feedbackId": null,
  "locationType": null,
  "quality": null,
} satisfies Location

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as Location
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


