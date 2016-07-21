let B
let I x = x
let K x y = x
let M x = x >> x
let T x y = y x
let Q x y z = y (x z)
let S x y z = x z (y z)
let rec Y f x = f (Y f) x
