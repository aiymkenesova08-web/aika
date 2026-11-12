
type Arithmetic() =

    member this.Add(a: int, b: int) =
        a + b

    member this.Subtract(a: int, b: int) =
        a - b

    member this.Multiply(a: int, b: int) =
        a * b

    member this.Divide(a: int, b: int) =
        if b = 0 then
            failwith "Нөлге бөлуге болмайды"
        else
            a / b
