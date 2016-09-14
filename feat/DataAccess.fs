namespace feat
open System
open System.IO
open FSharp.Data
open FSharp.Data.JsonExtensions

module DataAccess =
    type FeatureProvider = JsonProvider<"../feat/JsonSchema/FeatureSchema.json">
    let GetFeatureFilePaths directoryPath =         
        Directory.GetFiles(directoryPath, "*.json")        
    let GetFeatures (filePath:string) =            
        let json = FeatureProvider.Load(filePath)        
        json
        