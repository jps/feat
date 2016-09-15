namespace feat

open System

module Main =     
    let defaultSearchPath = "C:\Development\moonpig.features.definitions\Library\src\Moonpig.Features.Definitions\Configs";
    let ls = 
        let filePaths = DataAccess.GetFeatureFilePaths defaultSearchPath
        let pathsFeatures = filePaths |> Array.map(fun path -> (path, DataAccess.GetFeaturesFromFile path))
        let flattend = pathsFeatures |> Array.map(fun (path,features) -> features |> Array.map(fun feature -> (path,feature))) 
                                    |> Array.concat
        let groupedByName = flattend |> Array.groupBy(fun (path,feature) -> feature.Name)
        //let sorted = 
        //let groupedByName 
        ()
    let notRecognised = 
        ()
    let matchToFn command =
        match command with
        | "ls" -> printfn "ls"
        | _ -> printfn "Not recognised"
    let readArgs (argv: string[]) = 
        argv  |> Array.map(fun key -> key.ToLower()) 
              |> Array.iter(fun lowerKey -> matchToFn(lowerKey))        
    [<EntryPoint>]
    let main argv = 
        
        printfn "%A" argv

        readArgs argv
        0 // return an integer exit code