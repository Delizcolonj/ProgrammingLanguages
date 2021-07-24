// Learn more about F# at http://fsharp.org

open System
open System.Numerics
//Problem 1: Cube list
let list0 = [2;4;6]
let list = List.map (fun i -> i * i * i) list0
printfn "=====Problem 1====="
printfn "Test list: %A" list0
printfn "%A" list
;;

//Problem 2:replicate C (n,k) = n! / (k! *(n-k)!) npte: May use bigint Bigint
let rec fact (n : int) =
    match n with
    | 0 | 1 -> bigint.One
    | _ -> (bigint n) * fact(n-1)
;;
let Combination (n:int) (k:int) = 
    let result =
        if n = 0 then bigint.Zero 
        else (fact n) / ((fact  k * fact(n- k)))
    printfn "Number of combinations: %A" result
printfn "=====Problem 2====="
Combination 30 5
;;

//Problem pattern list and list.map
let list1 = [1;2;3]
let list2 = [4;5;6]
let rec vecadd a b =
    match a, b with
    | [], [] -> []   // sum of two empty lists is an empty list
    | a::atail, b::btail -> (a + b) :: (vecadd atail btail)
printfn "=====Problem 3====="
printfn "%A" list1
printfn "%A" list2
printfn "Added two vectors: %A" (vecadd list1 list2)
;;

let vecadd2 = List.map2 (+)
let result3 = vecadd2 list1 list2
printfn "=====Problem 3 Part 2 W/ Map====="
printfn "%A" list1
printfn "%A" list2
printfn "Added two vectors: %A" (vecadd list1 list2)
;;

//Problem 4
let matrix1 = [[1;2;3]; [4;5;6]]
let matrix2 = [[7;8;9]; [1;2;3]]

let rec matadd m1 m2 = 
    match m1, m2 with
    | [], [] -> []
    | m1::matrix1, m2::matrix2 -> (vecadd m1 m2) :: (matadd matrix1 matrix2)
printfn "=====Problem 4====="
printfn "%A" matrix1
printfn "%A" matrix2
printfn "Added two vectors: %A" (matadd matrix1 matrix2)
;;
