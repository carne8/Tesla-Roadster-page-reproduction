module App.View

open Feliz
open I18n
open Fable.Core.JsInterop

importAll "./App.sass"
let teslaLogo: string = importDefault "../assets/images/tesla.svg"

[<ReactComponent>]
let View (props: {| model: obj; dispatch: obj |}) =
    React.fragment [
        Html.header [
            prop.children [
                Html.img [
                    prop.src teslaLogo
                    prop.className "tesla-logo"
                ]

                Html.button [
                    prop.text I18n.menu
                    prop.className "menu-button"
                ]
            ]
        ]

        Html.h1 [
            prop.text I18n.carName
        ]

        Html.footer [
            prop.children [
                Html.p [
                    prop.text I18n.carInfos.description
                    prop.className "car-description"
                ]

                Html.div [
                    prop.className "car-informations"
                    prop.children [
                        Html.div [
                            prop.className "acceleration"
                            prop.children [
                                Html.div [
                                    prop.className "animations"
                                    prop.children [
                                        Components.SpeedMeter.View()
                                        Components.DefilingNumerals.View()
                                    ]
                                ]

                                Html.p [
                                    prop.text I18n.carInfos.speedRun
                                    prop.className "speed"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]