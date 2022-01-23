[<AutoOpen>]
module YoLo

module String =
    let Trim (str: string) =
        str.Trim()

    let Remove (strToRemove: string) (str: string) =
        str.Split [| ' ' |]
        |> Array.filter (fun str -> str <> strToRemove)
        |> String.concat " "
        |> Trim

module Browser =
    module Types =

        open Browser.Types

        type FixedHTMLInputElement =
            inherit HTMLInputElement
            abstract member width: int with get,set