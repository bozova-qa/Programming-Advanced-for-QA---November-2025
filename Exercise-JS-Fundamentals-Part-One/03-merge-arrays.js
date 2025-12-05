function mergeArrays(arr1, arr2){
    let arr3 = [];
    
    for(let position = 0; position <= arr1.length - 1; position++){
        let firstElement = arr1[position];
        let secondElement = arr2[position];
        if(position % 2 === 0){
            arr3[position] = Number(firstElement) + Number(secondElement);//събиране
        }
        else{
            arr3[position] = firstElement + secondElement;//конкатенация
        }
    }
    console.log(arr3.join(" - "));
}

mergeArrays(['5', '15', '23', '56', '35'],
['17', '22', '87', '36', '11']
)