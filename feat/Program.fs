namespace feat

open System

module Main =     
    let defaultSearchPath = "C:\Development\moonpig.features.definitions\Library\src\Moonpig.Features.Definitions\Configs";
    let ls = 
        DataAccess.GetFeatures
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