
// Қосу функциясы
function add(a, b) {
    return a + b;
}

// Азайту функциясы
function subtract(a, b) {
    return a - b;
}

// Көбейту функциясы
function multiply(a, b) {
    return a * b;
}

// Бөлу функциясы
function divide(a, b) {
    if (b === 0) {
        throw new Error("Нөлге бөлуге болмайды!");
    }
    return a / b;
}

// Функцияларды экспорттау
module.exports = {
    add,
    subtract,
    multiply,
    divide
};
