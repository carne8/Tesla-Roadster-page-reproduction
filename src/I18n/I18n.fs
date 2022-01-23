module I18n

open Fable.Core
open Fable.Core.JsInterop
open Fable.PolyglotProvider

[<Literal>]
let enJsonFile = __SOURCE_DIRECTORY__ + "/strings.en.json"

type I18n = Fable.PolyglotProvider.Generator<enJsonFile>

let culture =
    Browser.Navigator.navigator.language
    |> Option.defaultValue ""
    |> fun x -> x.ToLowerInvariant().Split([| '-' |]).[0]

[<StringEnum>]
[<RequireQualifiedAccess>]
type Language =
    | Fr
    | En

let language =
    match culture with
    | "fr" -> Language.Fr
    | _ -> Language.En



let I18n =
    match culture with
    | "fr" -> I18n(importDefault ("./strings.fr.json"), "fr")
    | _ -> I18n(importDefault ("./strings.en.json"), "en")