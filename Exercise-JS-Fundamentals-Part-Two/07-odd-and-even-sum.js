function oddAndEvenSum(number){
    let evenSum = 0;
    let oddSum = 0;

    //обръщаме числото в стринг, за да можем да го сплитнем
    let digitsArray = number.toString().split('');

    for(const digit of digitsArray){
        //обръщаме стринг пак в число: '5' -> 5
        let currentDigit = Number(digit);

        if(currentDigit % 2 === 0){
            evenSum += currentDigit;
        }
        else {
            oddSum += currentDigit;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}

oddAndEvenSum(3495892137259234)