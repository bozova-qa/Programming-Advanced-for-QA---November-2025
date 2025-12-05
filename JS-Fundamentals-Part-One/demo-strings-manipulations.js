function demoStrings(){
    let name = "Desislava";//типът на променливата става string

    //Конкатенация - долепяне на текстове
    //начин 1: +
    let lastName = "Topuzakova";
    let fullName = name + " " + lastName;//Desislava Topuzakova

    //начин 2: concat() -> вградена функционалност
    let greet = "Hello, ";
    let names = "John";
    let result = greet.concat(name);// "Hello, John"

    //indexOf/ lastIndexOf -> търсене на един текст в друг
    let sentence = "I am a student in Software University";
    console.log(sentence.indexOf("student"));//7 - отпечатва на коя позиция за пръв път среща Student 
    console.log(sentence.indexOf("javascript"));//-1 -> няма го

    console.log(sentence.lastIndexOf("am"));//2 - първата позиция на последното срещане
    console.log(sentence.lastIndexOf("Desi"))//-1

    //substring(startIndex, endIndex) - взимане на подтекст от друг текст
    //"Desislava"
    let substring = name.substring(1,5); //"esis", 5 позиция не се включва
    let test = name.substring(3); // от 3 позиция до края "islava"

    //replace(search, replacement) - замяна на текст; !!! заменя всички срещания на даден текст
    //sentence = "I am a student in Software University"
    let newSentence = sentence.replace("University", "Academy");
    // new sentence = "I am a student in Software Academy"

    //Split - взима текст и го разделя на масив от текстове с разделител
    let fruits = "apple, orange, peach"
    let arrayFruits = fruits.split(", ");//["apple", "orange", "peach"]
    

    //Includes = проверка дали един текст се съдържа в друг текст; true/ false отговор
    console.log(fruits.includes("apple"));// true
    let newFruit = fruits.includes("pineapple");// false
    if (fruits.includes("apple")){
        console.log("apple");
    }

    //repeat(count) - повтаряне на текст 
    let animal = "dog";
    let repeatedText = animal.repeat(3);//"dogdogdog"

    //trim() - премахва празни пространства(интервали в един текст)
    let example = "    Animal is a dog      ."
    example.trim();//премахва празни пространства в началото и края на текста
    example.trimEnd();//само в края
    example.trimStart();//само в началото

    //startsWith/ endsWith - проверка дали даден текст започва/ завършва с друг текст
    //sentence = "I am a student in Software University"
    console.log(sentence.startsWith("I am"));//true 
    let isContains = sentence.startsWith("Ivan");//false

    sentence.endsWith("University");//true
    sentence.endsWith("Desi");//false

    //padStart()/ padEnd() - добавяне елементи в началото/ края на нашия текст докато не
    //достигнем определена дължина на текста
    let dogName = "Sharo"//length = 5
    let newLongName = dogName.padStart(10, "a");//добавяме "а" докато не стигне 10 елемента; "aaaaaSharo"
    let newDogName = dogName.padEnd(20,"e");//"Sharoeeeeeeeeeeeeeee" -> length = 20;
    console.log(dogName, padEnd(10, '.'))// "Sharo....."

    //дължина на текст
    console.log(dogName.length);//5
    let count = dogName.length;

    //обхождане на текстове
    //начин 1: for loop
    for (let position = 0; position <= dogName.length - 1; position++){
        console.log(dogName[position]);
    }

    //начин 2: for of 
    for(let symbol of name){
        console.log(symbol);
    }


}
