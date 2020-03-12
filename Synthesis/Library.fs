module Synthesis

let abelar input = 
    (input > 12 && input < 3097) && (input % 12 = 0)
    //failwith "Not implemented"

let area b h =
    match (b < 0.0 || h < 0.0) with
    | true -> failwith "base of height is negative"
    | _ -> (0.5 * b) * h
    //failwith "Not implemented"

let zollo input =
    match (input < 0) with
    | true -> input * -1
    | _ -> input * 2
    //failwith "Not implemented"

let min a b =
    match (a < b) with
    | true -> a
    | _ -> b
    //failwith "Not implemented"

let max a b =
    match (a < b) with
    | false -> a
    | _ -> b
    //failwith "Not implemented"

let ofTime h m s = 
    (h * 3600) + (m * 60) + s
    //failwith "Not implemented"

let toTime seconds =
    match (seconds < 0) with
    | true -> (0,0,0)
    | _ -> ((seconds / 60) / 60, (seconds / 60) % 60, seconds % 60)
    //failwith "Not implemented"

let digits input =
    let rec count n =
        match (n < 10 && n > -10) with
        | true -> 1
        | _ -> 1 + count(n/10)
    count input
    //failwith "Not implemented"

let minmax input =
    (min(min(), min()), max(max()))
    //failwith "Not implemented"

let isLeap _ =
    failwith "Not implemented"

let month _ =
    failwith "Not implemented"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"