open System

let from whom =
    sprintf "%s" whom

[<EntryPoint>]
let main argv =
    let message = from "!"
    printfn "Hello World%s" message
    0