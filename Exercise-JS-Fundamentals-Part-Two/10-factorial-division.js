function factorialDivision(num1, num2){
    let factorial1 = factorial(num1);//трябва да дефинираме факториел
    let factorial2 = factorial(num2);

    let result = factorial1 / factorial2;
    console.log(result.toFixed(2));

    function factorial(n){
        //дефинираме функцията
        let result = 1;
        for(let i = 1; i <= n;i++){
            result *= i;

        }
        return result;
    }
}

factorialDivision(6,
2
)