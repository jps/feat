namespace feat.test
open System.IO
open Xunit
open FsUnit
open feat

module DataAccessTests =    
    let testExecutionPath = System.Reflection.Assembly.GetExecutingAssembly().Location
    let testDataDirectory = Path.GetDirectoryName (testExecutionPath)
                            |> fun x -> Path.Combine(x, @"..\..\TestData\")
    let testDataFileLocal = Path.Combine (testDataDirectory, "Features.acceptance.feat.json")
    [<Fact>]
    let ``Finds feature files in directory`` () =        
        let paths = DataAccess.GetFeatureFilePaths(testDataDirectory)
        paths |> should not' (be Null)
        paths |> should haveLength 6
    [<Fact>]
    let ``Finds feature in file`` () = 
        let data = DataAccess.GetFeaturesFromFile(testDataFileLocal)
        data |> should not' (be Null)
        data |> should haveLength 1
        Array.head(data).Enabled |> should be True
        Array.head(data).Name |> should equal "SNB-1234:TestFeature"