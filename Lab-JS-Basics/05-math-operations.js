function mathOperation (num1, num2, operator){
    let result;
    switch (operator){
        case '+':
            console.log(result = num1 + num2)
            break;
        case '-':
            console.log(result = num1 - num2)
            break;
        case '*':
            console.log(result = num1 * num2)
            break;
        case '/':
            console.log(result = num1 / num2)
            break;
        case '%':
            console.log(result = num1 % num2)
            break;
        case '**':
            console.log(result = num1 ** num2)
            break;
    }
    
}

mathOperation(3, 5.5, '*')