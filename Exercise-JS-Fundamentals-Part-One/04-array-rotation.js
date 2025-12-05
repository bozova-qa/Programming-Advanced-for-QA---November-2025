function arrayRotation(array, rotation){

    //[51, 47, 32, 61, 21], 2
    for (let i = 1; i <= rotation; i++) {
        let firstElement = array.shift();//премахва и връща първия елемент
        array.push(firstElement);//добавя накрая

    }
    console.log(array.join(" "));
}

arrayRotation([51, 47, 32, 61, 21], 2)