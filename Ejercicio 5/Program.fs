open System
let from whom = sprintf "from %s" whom
let suma x y =  x + y
let resta x y =  x - y
let multiplicacion x y =  x * y
let division x y =  x / y

[<EntryPoint>]

let main argv =
    let message = from "F#" 
    Console.Write("Introduzca un numero: ")
    let a  = Convert.ToInt32(Console.ReadLine()) 
    Console.Write("Introduzca un numero: ")
    let b  = Convert.ToInt32(Console.ReadLine())

    printfn "La suma es             : %d" (suma a b)
    printfn "La resta es            : %d" (resta a b)
    printfn "La multiplicacion es   : %d" (multiplicacion a b)
    printfn "La division es         : %d" (division a b)
    
    let tecla = Console.ReadKey()
    0 
    