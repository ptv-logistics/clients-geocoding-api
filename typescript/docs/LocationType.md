
# LocationType

Distinguishes different types of Locations:    * `LOCALITY` - Represents a locality (town, city or place).    * `POSTAL_CODE` - Represents a postal code area.    * `STREET` - Represents a street, or a section of a street.    * `EXACT_ADDRESS` - An address that is contained exactly in the geocoding data.     * `INTERPOLATED_ADDRESS` - An address that was interpolated from an address range.     * `INTERSECTION` - An at-grade junction where two streets meet.     * `POINT_OF_INTEREST` - A point of interest, like e.g. a shop, a service, or a museum.

## Properties

Name | Type
------------ | -------------

## Example

```typescript
import type { LocationType } from ''

// TODO: Update the object below with actual values
const example = {
} satisfies LocationType

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as LocationType
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


