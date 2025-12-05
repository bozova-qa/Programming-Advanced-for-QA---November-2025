function addAndSubtract(array){
    
    let newArray = [];

    for(let position = 0; position <= array.length - 1; position++){
        let currentElement = array[position];
        if (currentElement % 2 == 0){
           let evenElement = currentElement + position;
           newArray[position] = evenElement;
        }
        else {
            let oddElement = currentElement - position;
            newArray[position] = oddElement;
        }
    }
    console.log(newArray);

    let sumArray = 0;
    for(let i = 0; i <= array.length - 1; i++){
        sumArray += array[i];
    }
    console.log(sumArray);

    let sumNewArray = 0;
    for(let j = 0; j <= newArray.length - 1; j++){
        sumNewArray += newArray[j];
    }
    console.log(sumNewArray);

}

addAndSubtract([5, 15, 23, 56, 35]);