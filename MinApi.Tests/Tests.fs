module Tests

open Xunit
open FSharp.Control.Tasks
open TestApi

[<Fact>]
let ``/ should return "Hello world"`` () =
    task {
        let api = runTestApi().CreateClient()
        let! response = api.GetAsync("/")
        let! responseContent = response.Content.ReadAsStringAsync()
        Assert.Equal("Hello world", responseContent)
    }
