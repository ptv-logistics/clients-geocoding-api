
# Address

Represents the address of a geographical object. Whenever a string, such as a city or street name, is available in multiple languages, it is returned in the default language specified by the country in which an object is located. Most of the fields are optional, because addressing schemes vary strongly between countries.

## Properties

Name | Type
------------ | -------------
`countryName` | string
`state` | string
`province` | string
`postalCode` | string
`city` | string
`district` | string
`subdistrict` | string
`street` | string
`houseNumber` | string
`countryCodeIsoAlpha2` | string
`countryCodeIsoAlpha3` | string
`countryCode` | string

## Example

```typescript
import type { Address } from ''

// TODO: Update the object below with actual values
const example = {
  "countryName": null,
  "state": null,
  "province": null,
  "postalCode": null,
  "city": null,
  "district": null,
  "subdistrict": null,
  "street": null,
  "houseNumber": null,
  "countryCodeIsoAlpha2": null,
  "countryCodeIsoAlpha3": null,
  "countryCode": null,
} satisfies Address

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as Address
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


