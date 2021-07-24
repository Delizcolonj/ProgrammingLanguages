// Learn more about F# at http://fsharp.org

open System
let data = [9; 92; 3; 7; 36; 77; 13; 6; 11; 46; 19; 24; 30; 55; 6]
let rec quicksort  = function
| [] ->  []
| pivot::rem -> 
    let left, right = rem |> List.partition(fun i -> i < pivot)
    (quicksort left) @ [pivot] @ (quicksort right)
;;
printfn"The Standard List %A" data
//printfn"The Sorted List %A" quicksort data
printfn"The Sorted List %A" (quicksort data)
