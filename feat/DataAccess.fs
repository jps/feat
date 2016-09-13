namespace feat
open System
open System.IO
open FSharp.Data

module DataAccess =
    let GetFeatureFilePaths directoryPath =         
        Directory.GetFiles(directoryPath, "*.json")        
    let GetFeatures filePath =
        let fileContent = File.ReadAllText(filePath)
        let json = JsonValue.Parse(fileContent)// |> JsonValue.Array [| Name; Enabled |]
        //let features = json |> JsonValue.Array [| features |]
        match json with
        | JsonValue.Array [| features |] -> 
            for feature in features do           
//                if feature?value <> JsonValue.Null then 
//                    let name, enabled = feature?Name, feature?Enabled
                    ()
        | _ -> ()
        
        //let parsed = json 
        //parsed
        //fileContent