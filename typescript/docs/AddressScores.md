
# AddressScores

Quality indicators that help deciding how well a result fits to the search input.    This is only available for **searchLocationsByText** and **searchLocationsByAddress** results.

## Properties

Name | Type
------------ | -------------
`country` | number
`state` | number
`province` | number
`postalCode` | number
`city` | number
`district` | number
`subDistrict` | number
`street` | number
`houseNumber` | number

## Example

```typescript
import type { AddressScores } from ''

// TODO: Update the object below with actual values
const example = {
  "country": null,
  "state": null,
  "province": null,
  "postalCode": null,
  "city": null,
  "district": null,
  "subDistrict": null,
  "street": null,
  "houseNumber": null,
} satisfies AddressScores

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as AddressScores
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


