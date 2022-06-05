module Problem_10

let private getSumOfPrimes (max: int) = 
    let isComposite = [| for i in 0 .. max -> false |]

    for i in 4 .. 2 .. max do
        isComposite.[i] <- true

    let mutable nextPrime = 3
    let stopAt =  System.Convert.ToInt32(sqrt((double)max)) + 1
    while(nextPrime <= stopAt) do
        for i in nextPrime * 2 .. nextPrime .. max do
            isComposite.[i] <- true
        nextPrime <- nextPrime + 2
        while(nextPrime <= max && isComposite.[nextPrime]) do
            nextPrime <- nextPrime + 2

    let mutable result:uint64 = (uint64)2
    for i in 3 .. 2 .. max do
        if isComposite.[i] = false then
            result <- result + (uint64)i
    result

let public GetResult =
    let maxPrime = 2000000
    getSumOfPrimes(maxPrime)    