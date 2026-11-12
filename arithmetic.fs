
module Arithmetic

// Қосу
let add a b =
    a + b

// Азайту
let subtract a b =
    a - b

// Көбейту
let multiply a b =
    a * b

// Бөлу
let divide a b =
    if b = 0 then
        failwith "Нөлге бөлуге болмайды!"
    else
        a / b
