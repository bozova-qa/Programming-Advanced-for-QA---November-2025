function printStars(count){
    console.log("*".repeat(count));
}

function printName(){
    console.log("Ivan");
    printStars(9);//може да има функция във функция
}

function getSum(num1, num2){
    return num1 + num2;//функциите може както да отпечатат, така и само да връщат резултат
}

//Arrow functions - функция със "стрелкичка"
let increment = x => x + 1;//приема стойност x и връща резултат x + 1
console.log(increment(5));//6

let sum = (a,b) => a + b; //с два параметъра
console.log(sum(5, 6));

printStars(5);
printName();
console.log(getSum(3,4));