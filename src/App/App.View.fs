module App.View

open Feliz
open I18n
open Fable.Core.JsInterop

importAll "./App.sass"
let teslaLogo: string = importDefault "../assets/images/tesla.svg"
let arrowDown: string = importDefault "../assets/images/arrow-down.svg"

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
                            prop.className "car-stats"
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
                                            prop.text (I18n.carInfos.speedRun + " " + I18n.speed)
                                            prop.className "speed"
                                        ]
                                    ]
                                ]

                                Html.div [
                                    prop.className "max-speed"
                                    prop.children [
                                        Html.div [
                                            prop.className "speed"
                                            prop.children [
                                                Html.p [ prop.text "+" ]
                                                Html.p [
                                                    prop.className "big-text"
                                                    prop.text I18n.carInfos.maxSpeed.speed
                                                ]
                                                Html.p [ prop.text I18n.speed ]
                                            ]
                                        ]

                                        Html.div [
                                            prop.className "text"
                                            prop.text I18n.carInfos.maxSpeed.text
                                        ]
                                    ]
                                ]

                                Html.div [
                                    prop.className "autonomy"
                                    prop.children [
                                        Html.div [
                                            prop.className "distance"
                                            prop.children [
                                                Html.p [
                                                    prop.className "big-text"
                                                    prop.text I18n.carInfos.autonomy.distance
                                                ]
                                                Html.p [ prop.text I18n.distance ]
                                            ]
                                        ]

                                        Html.div [
                                            prop.className "text"
                                            prop.text I18n.carInfos.autonomy.text
                                        ]
                                    ]
                                ]
                            ]
                        ]

                        Html.button [
                            prop.className "reserve-button"
                            prop.text I18n.reserve
                        ]
                    ]
                ]

                Html.img [
                    prop.src arrowDown
                    prop.className "arrow-down"
                ]
            ]
        ]
    ]