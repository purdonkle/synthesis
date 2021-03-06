﻿module Synthesis

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

let minmax (a,b,c,d) =
    (min (min a b) (min c d), max (max a b) (max c d))
    //failwith "Not implemented"

let isLeap year =
    match (year < 1582) with
    | true -> failwith "input year less than 1582"
    | _ -> ((year % 400 = 0) || ((year % 4 = 0) && (year % 100 <> 0)))
    //failwith "Not implemented"

let month = function
    | 1 -> ("January", 31)
    | 2 -> ("February", 28)
    | 3 -> ("March", 31)
    | 4 -> ("April", 30)
    | 5 -> ("May", 31)
    | 6 -> ("June", 30)
    | 7 -> ("July", 31)
    | 8 -> ("August", 31)
    | 9 -> ("September", 30)
    | 10 -> ("October", 31)
    | 11 -> ("November", 30)
    | 12 -> ("December", 31)
    | _ -> failwith "month number greater than 12 or smaller than 1"
    //failwith "Not implemented"

let toBinary input =
    match (input < 0) with
    | true -> failwith "negative input"
    | _ -> 
    let rec findBin dec output = 
        match (dec > 0 || output = "") with
        | false -> output
        | true -> findBin (dec / 2) (string(dec % 2) + output)
    findBin input ""
    //failwith "Not implemented"

let bizFuzz n = 
    match (n < 0) with
    | true -> (0,0,0)
    | false -> (((n - n%3)/3) , ((n - n%5)/5) , ((n - n%15)/15))
    //failwith "Not implemented"

let monthDay d y =
    let rec getMonth days monthNum =
       let monthName, numDays = month monthNum
       match days <= numDays with
       | true -> monthName
       | false -> getMonth (days - numDays) (monthNum + 1)

    match isLeap y with
    | true -> 
        match (d >= 1 && d <= 366) with
        | false -> failwith "invalid day"
        | true -> match (d > 32) with
                  | true -> getMonth (d-1) 1
                  | false -> getMonth d 1
    | false ->
        match (d >= 1 && d <= 365) with
        | false -> failwith "invalid day"
        | true -> getMonth d 1
    //failwith "Not implemented"

let coord (x1,x2,y1,y2) =
    let sqrt n =
        let rec calculate guess i =
            match i with
            | 10 -> guess
            | _ -> 
            let g = (guess + n/guess) / 2.0
            calculate g (i+1)

        match n <= 0.0 with
        | true -> failwith "Impossibru!"
        | _ -> calculate (n/2.0) 0

    let distance = sqrt ((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2))
    distance
    //failwith "Not implemented"