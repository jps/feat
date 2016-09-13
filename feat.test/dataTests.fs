namespace feat.test
open Xunit // import namespace
open FsUnit

module testHelpers =
    let add x y = x + y // unit


module tests =
    [<Fact>]   // test
    let ``can list features`` =
        testHelpers.add 5 3 |> should equal 8



