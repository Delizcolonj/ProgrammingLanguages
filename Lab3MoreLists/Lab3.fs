// Learn more about F# at http://fsharp.org

open System

let List1 = [15; 9; 18; 25; 50]
let rec last list = 
    match list with
    | [x] -> x
    | _::tail -> last tail
    | _ -> failwith "Empty List"
printfn "=====Problem 1======"
printfn "The last element in the list is %A" (last List1)
;;

let myList = [11..50]
let isDivisibleBy number elem = elem % number = 0
let result = List.find (isDivisibleBy 10) myList
printfn "=====Problem 2======"
printfn "True, The first element divisible by 10: %d" result
;;
