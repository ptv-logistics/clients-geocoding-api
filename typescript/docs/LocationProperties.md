
# LocationProperties


## Properties

Name | Type
------------ | -------------
`referencePosition` | [ReferencePosition](ReferencePosition.md)
`roadAccessPosition` | [RoadAccessPosition](RoadAccessPosition.md)
`address` | [Address](Address.md)
`formattedAddress` | string
`feedbackId` | string

## Example

```typescript
import type { LocationProperties } from ''

// TODO: Update the object below with actual values
const example = {
  "referencePosition": null,
  "roadAccessPosition": null,
  "address": null,
  "formattedAddress": null,
  "feedbackId": null,
} satisfies LocationProperties

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as LocationProperties
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


