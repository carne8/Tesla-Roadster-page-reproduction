module Components.DefilingNumerals

open Feliz
open Fable.Core.JsInterop

importAll "./DefilingNumerals.sass"
let numerals: string = importDefault "../assets/images/speed-meter/numerals.svg"

let View () =
    Html.div [
        prop.className "numerals"
        prop.children [
            Html.div [
                prop.classes [
                    "unity"
                    "numerals"
                ]
            ]

            Html.p [
                prop.text "."
                prop.className "point"
            ]

            Html.div [
                prop.classes [
                    "decimal"
                    "numerals"
                ]
            ]

            Html.p [
                prop.text "s"
                prop.className "seconds"
            ]
        ]
    ]