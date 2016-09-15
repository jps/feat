namespace feat.test
open System.IO
open Xunit
open FsUnit
open feat

module DataManiuplatorTests =
     [<Fact>]
     let ``Empty list returns emtpy list`` () = 
        let pathFeatures = Array.empty<(string * FeatureToggle[])>
        let grouped = DataManipulator.GroupPathFeaturesByName pathFeatures
        grouped |> Seq.toArray |> should haveLength 0
     [<Fact>]
     let ``Single path with single feature`` () = 
        let features = [| FeatureToggle("toggleName", false) |]
        let pathFeatures = [| ("path.json", features) |]
        let grouped = DataManipulator.GroupPathFeaturesByName pathFeatures        
        grouped |> Seq.toArray |> should haveLength 1