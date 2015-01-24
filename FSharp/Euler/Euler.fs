﻿namespace Euler

[<AutoOpen>]
module Problems =

    (*  
        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000.
    *)

    let problem1 lst =
        let checkMult3and5 number =
            match number % 3, number % 5 with
                | 0, 0 | 0, _ | _, 0 -> true
                | _ -> false
        lst 
            |> List.filter (fun elem -> checkMult3and5 elem)
            |> List.sum

    let problem1' lst =
        let checkMult3and5 =
            function
                | 0, 0 | 0, _ | _, 0 -> true
                | _ -> false
        lst 
            |> List.filter (fun elem -> checkMult3and5 (elem%3, elem%5))
            |> List.sum

    let problem1'' lst =
        let checkMult3and5 number =
            if (number % 3 = 0 || number % 5 = 0) then
                true
            else
                false
        lst 
            |> List.filter (fun elem -> checkMult3and5 elem)
            |> List.sum

    (*
        Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
        By starting with 1 and 2, the first 10 terms will be:
        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
        find the sum of the even-valued terms.
    *)
    
    let problem2 () =
            Seq.unfold (fun (a, b)  -> Some(a + b, (b, a + b))) (0I, 1I)
            |> Seq.takeWhile (fun elem -> elem < 4000000I)
            |> Seq.filter (fun elem -> elem % 2I = 0I)
            |> Seq.sum

    
        
        