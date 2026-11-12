
function sum(a, b) {
    return a + b;
}

function subtract(a, b) {
    return a - b;
}

function multiply(a, b) {
    return a * b;
}

function divide(a, b) {
    if (b === 0) {
        throw new Error("Нөлге бөлуге болмайды!");
    }
    return a / b;
}

// Тексеру
console.log("Қосу:", sum(10, 5));
console.log("Азайту:", subtract(10, 5));
console.log("Көбейту:", multiply(10, 5));
console.log("Бөлу:", divide(10, 5));
