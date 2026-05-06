
# InputField

Enumeration to specify a parameter of a suggestions/by-address request.    * `COUNTRY` - Specifies the country parameter.    * `STATE` - Specifies the state parameter.    * `POSTAL_CODE` - Specifies the postalCode parameter.    * `LOCALITY` - Specifies the locality parameter.    * `STREET` - Specifies the street parameter.    * `HOUSE_NUMBER` - Specifies the houseNumber parameter.

## Properties

Name | Type
------------ | -------------

## Example

```typescript
import type { InputField } from ''

// TODO: Update the object below with actual values
const example = {
} satisfies InputField

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as InputField
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


