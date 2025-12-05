function calculateArea(input){
    let result;
    let inputType = typeof(input);
    switch(inputType){
        case 'number':
            console.log(result = ((input**2) * Math.PI).toFixed(2));
            break;
         default:
            console.log(`We can not calculate the circle area, because we received a ${typeof(input)}.`);
            break;
    }
}

calculateArea('name')