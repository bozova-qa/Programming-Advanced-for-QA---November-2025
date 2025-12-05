function sumFirstAndLastElements(array){
    //array = [20, 30, 40]
    let firstElement = array[0];
    let lastElement = array[array.length -1];
    console.log(Number(firstElement) + Number(lastElement));
}

sumFirstAndLastElements([11, 58, 69]);