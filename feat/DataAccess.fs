namespace feat

open System
open System.IO
open FSharp.Data
open FSharp.Data.JsonExtensions
open feat.Types

module DataAccess =
    let GetFeatureFilePaths directoryPath =         
        Directory.GetFiles(directoryPath, "*.json")        
    let GetFeaturesFromFile (filePath:string) =            
        let json = FeatureToggleSchema.Load(filePath)
        json