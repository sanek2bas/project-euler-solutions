module Problem_2

let private sumEvenFibonacciNumbers (max : int) =
    let mutable  preLastNumber = 1
    let mutable lastNumber = 2
    let mutable sum = 0
    while lastNumber <= max do
        let nextNumber = preLastNumber + lastNumber
        preLastNumber <- lastNumber
        lastNumber <- nextNumber
        if preLastNumber % 2 = 0 then
            sum <- sum + preLastNumber
    sum

let public GetResult =
    let maxFibonacciNumber = 4000000
    sumEvenFibonacciNumbers(maxFibonacciNumber)    