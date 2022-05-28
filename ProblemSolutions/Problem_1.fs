module Problem_1
    
let private sumDevidableByX (x : int, limit : int) =
    let mutable sum = 0
    for i in x .. x .. limit do
        sum <- sum + i
    sum

let public GetResult =
    let limit = 999;
    let three = 3;
    let five = 5;
    sumDevidableByX(three, 1000) + sumDevidableByX(five, limit) - sumDevidableByX(three * five, limit)
