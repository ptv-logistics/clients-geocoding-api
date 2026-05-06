
# TotalScoreType

Enumeration to specify the type of total score calculation.    * `INPUT_AND_RESULT_BASED` - The total score is calculated by comparing the result against the input.    * `RESULT_BASED` - The total score is calculated by classifying result attributes.      This parameter is experimental and may change at any time in the future.

## Properties

Name | Type
------------ | -------------

## Example

```typescript
import type { TotalScoreType } from ''

// TODO: Update the object below with actual values
const example = {
} satisfies TotalScoreType

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as TotalScoreType
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


