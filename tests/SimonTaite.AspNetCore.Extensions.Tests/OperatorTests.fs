module OperatorTests


open Expecto
open SimonTaite.AspNetCore.Extensions.Operators

[<Tests>]
let Test =
  testList "Operator" [
    testCase "Path.Combine" <| fun _ ->
      let subject = "path1" </> "path2"
      let expected = System.IO.Path.Combine("path1", "path2")
      Expect.equal subject expected "Path.Combine"
  ]
