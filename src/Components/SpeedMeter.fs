module Components.SpeedMeter

open Feliz
open Fable.Core.JsInterop

importAll "./SpeedMeter.sass"
let speedMeter: string = importDefault "../assets/images/speed-meter/speedometer.svg"
let speedMeterCircle: string = importDefault "../assets/images/speed-meter/speedometercircle.svg"
let speedMeterNeedle: string = importDefault "../assets/images/speed-meter/speedometerneedle.svg"

let View () =
    Html.div [
        prop.className "speed-meter"
        prop.children [
            Html.img [
                prop.src speedMeterCircle
                prop.className "speed-meter-background"
            ]
            Html.img [
                prop.src speedMeter
                prop.className "speed-meter-graduation"
            ]
            Html.img [
                prop.src speedMeterNeedle
                prop.className "speed-meter-needle"
            ]
        ]
    ]