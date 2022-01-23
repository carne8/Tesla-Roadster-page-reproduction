module Main

open Elmish
open Elmish.React
#if DEBUG
open Elmish.Debug
#endif

open Fable.Core.JsInterop

importAll "./sass/main.sass" // import default style

let view model dispatch =
    {| model = model
       dispatch = dispatch |}
    |> App.View.View

Program.mkProgram App.State.init App.State.update view
|> Program.withReactSynchronous "app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run