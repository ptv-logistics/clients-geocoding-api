
# SuggestedAddress

An address suggested for the input of the searchLocationsByAddress endpoint.

## Properties

Name | Type
------------ | -------------
`caption` | string
`country` | string
`state` | string
`postalCode` | string
`locality` | string
`street` | string
`houseNumber` | string

## Example

```typescript
import type { SuggestedAddress } from ''

// TODO: Update the object below with actual values
const example = {
  "caption": null,
  "country": null,
  "state": null,
  "postalCode": null,
  "locality": null,
  "street": null,
  "houseNumber": null,
} satisfies SuggestedAddress

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as SuggestedAddress
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


