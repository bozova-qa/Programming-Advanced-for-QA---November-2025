function reverseAnArray(count, numbers){
    //count - броят на числата, които трябва да вземем;
    //numbers - масив от числа

    //count = 3;

    //създаваме нов масив, в който слагаме първите count на брой елемента
    let newArray = [];//празен масив
    for(let i = 1; i <= count; i++){
        let firstElement = numbers.shift(); //махни първия елемент
        newArray.push(firstElement);//добави до в празния масив, така до count
    };

    newArray.reverse();//обръщаме масива наобратно
    console.log(newArray.join(" "));
    
}


//let newArray = numbers.slice(0, count).reverse();
reverseAnArray(3, [10, 20, 30, 40, 50]);