namespace feat
open FSharp.Data

[<AutoOpen>]
module Types = 
    type FeatureToggleSchema = JsonProvider<"../feat/JsonSchema/FeatureSchema.json">
    type FeatureToggle = FeatureToggleSchema.Root