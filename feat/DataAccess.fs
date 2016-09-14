namespace feat
open System
open System.IO
open FSharp.Data
open FSharp.Data.JsonExtensions

module DataAccess =
    type jsonProvider = JsonProvider<"../feat/JsonSchema/FeatureSchema.json", SampleIsList=true>
    let GetFeatureFilePaths directoryPath =         
        Directory.GetFiles(directoryPath, "*.json")        
    let GetFeatures filePath =            
        let fileContent = File.ReadAllText(filePath)
        let json = jsonProvider.Load(filePath)
        let array = json.JsonValue.AsArray()
        array