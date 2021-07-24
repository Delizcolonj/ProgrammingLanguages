let add a b = a+b
printfn "=====Problem 1====="
printfn "%d" (add 25 15)
printfn "=====Problem 1b====="
printfn "%d"  (add(add 18 34) (add 23 19))
;;

let round x = 
 if (x >= 100) then 
  100
  else if (x < 0) then
   0
 else x
printfn "=====Problem 2a====="
printfn "%i" (round 120)
printfn "%i" (round -15)
printfn "%i" (round 77)
;;

let round2 x = 
  match x with 
    |y when y >=100 -> 100
    |y when y < 0 -> 0
    |_ -> x
printfn "=====Problem 2b====="
printfn "%i" (round2 106)
printfn "%i" (round2 -56)
printfn "%i" (round2 45)
;;

let rec factorial n =
 match n with
 | 0 
 | 1 -> 1
 | n -> n * factorial(n-1)
printfn "=====Problem 3====="
printfn "%d" (factorial 6)
;;



let list = [ 1..10]
let rec sum L1 = 
 //ex: [1;2;3] 1+ sum tail[2;3]
 match L1 with
 |head::tail -> head + sum tail
 |[] -> 0
printfn "=====Problem 4====="
printfn "%d" (sum list)
;;

let list1 = [ 1;2;3 ]
printfn "=====Problem 5====="
printfn "list is Empty: %b" list1.IsEmpty
printfn "list’s Length: %d" list1.Length
printfn "First element of list: %d" list1.Head
printfn "Second element if list: %d" (list1.Item(1))
printfn "Third element of list: %d"  (list1.Item(2))
printfn "Last element of list: %d" (list1.Item(2))
;;
