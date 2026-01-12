function calculteSum(a,b){
    return a + b;
}

//custom test
function testCalculateSum(){
    // Arrange - подготвяме данните, с които ще тестваме
    let firstNumber = 5;
    let secondNumber = 10;
    let expectedResult = 15;

    // Act - изпълняваме кода, който искаме да тестваме
    let actualResult = calculteSum(firstNumber, secondNumber);

    // Assert - проверяваме дали резултатът, които получаваме отговаря на резултата, които очакваме
    if(actualResult === expectedResult){
        console.log("Test is correct!");
    }
    else{
        throw new Error("Test is not correct!")
    }
    
}

testCalculateSum()