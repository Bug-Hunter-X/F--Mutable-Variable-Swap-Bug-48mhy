let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp
    (x,y)

let x,y = swap x y
printfn "%d %d" x y