function convertToObject(text){
    //text = '{"name": "George", "age": 40, "town": "Sofia"}'
    const obj = JSON.parse(text);
    //obj = {
        //name: "George",
        //age: 40,
        //town: "Sofia"
    //}
    //Object.entries(obj) -> получаваме масив от масиви;
    //[['name','George'],['age', '40'],['town','Sofia']]

    for(let entry of Object.entries(obj)){//обхождаме всички двойки от масива
        //entry: ['name', 'George']
        console.log(entry.join(": "));

    }
}

convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');