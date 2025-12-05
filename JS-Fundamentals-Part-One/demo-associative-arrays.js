function demoAssArrays(){
    //създаване на асоциативен масив
    //начин 1:
    let assocArr = {
        'Desi': 13.50,
        'Ivan': 23.45,
        'Pesho': 3.98
    };

    //начин 2: създаваме празен асоц. масив и добавяме елементи
    let assoArray = {};
    assoArray["apple"] = 4.50;
    assoArray["peach"] = 5.40;
    assoArray["carrot"] = 2.30;

    // размер на асоциативен масив
    let size = Object.keys(assoArray).length;//взима ключвовете, колкото са те, толкова и размера size = 3

    //достъпване на value в един запис
    console.log(assoArray["apple"])//4.50

    //обхождане на асоц. масив
    //for in - отпечатва ключа и стойността срещу нея
    for(let key in assoArray){
        console.log(key);
        console.log(assoArray[key]);
    }

    //проверка дали даден запис съществува
    console.log(assoArray.hasOwnProperty("apple"));//true
    if (assoArray.hasOwnProperty("pear")){
        console.log("success")
    };

    //премахване на запис от асоц. масив
    delete assoArray["apple"];

}