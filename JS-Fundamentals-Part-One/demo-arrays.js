function demoArray(){
    //създаване на масив
    //начин 1:
    let array = ["John Doe", 24, true];
}
    //начин 2:
    let newArray = [];
    newArray[0] = "John Doe";
    newArray[1] = 24;
    newArray[2] = true;

    //начин 3:(с конструктор)
    let myArray = new Array("John Doe", 24, true);

    //дължина на масив == броя на елементите, които сме съхранили в масива
    let count = newArray.length;
    console.log(array.length);

    //достъп на елементи в масив
    //newArray = ["Desi", "Test", 34]
    console.log(newArray[0]);//достъп до 1 елемент
    console.log(newArray[newArray.length - 1]);//достъп до последния елемент
    console.log(newArray[100]);//undefined
    console.log(newArray[-3]);//undefined

    //Pop - премахва и връща последния елемент на масива
    let nums = [10, 20, 30, 40, 50, 60, 70];
    //[10, 20, 30, 40, 50, 60, 70] -> length 7
    nums.pop(); //само премахва
    //[10, 20, 30, 40, 50, 60] -> length 6
    let lastElement = nums.pop();//извежда последния елемент, съхранява го в променлива

    //Push - добавя елемент в края на масива
    //[10, 20, 30, 40, 50, 60] -> length 6
    nums.push(90);
    //[10, 20, 30, 40, 50, 60, 90] -> length 7

    //Shift - обратното на POp - премахва и връща първия елемент
    //[10, 20, 30, 40, 50, 60, 90] -> length 7
    nums.shift();
    //[20, 30, 40, 50, 60, 90] -> length 6
    let firstElement = nums.shift();


    //Unshift - добавя елементи в началото на масива
    //[20, 30, 40, 50, 60, 90] -> length 6
    nums.shift(100);
    //[100, 20, 30, 40, 50, 60, 90] -> length 7

    //Splice - добавяне и замяна на елементи
    //[100, 20, 30, 40, 50, 60, 90] -> length 7
    nums.splice(1, 0, 34);//почни от 1 позиция, изтрий 0 елементи и вмъкни 34
    //[100, 34, 20, 30, 40, 50, 60, 90] -> length 8
    nums.splice(4, 1, 19); //премахваме един елемент на 4 позиция и на негово място слагаме 19
    //[100, 34, 20, 30, 19, 50, 60, 90] -> length 8
    nums.splice(2,1); //на 2 позиция да изтрием 1
    //[100, 34, 30, 19, 50, 60, 90] -> length 7

    //Reverse - обръща масива наобратно, посл. елемент става първи
    //[100, 34, 30, 19, 50, 60, 90] -> length 7
    nums.reverse();
    //[90, 60, 50, 19, 30, 34, 100] -> length 7

    //Join - обединяване на елементите на масив в текст; конкатенира елементите на масив
    let names = ["Desi", "Iva", "Ivan", "Gosho", "Mitko"]
    let result = names.join(" - ")//"Desi - Iva - Ivan - Gosho - Mitko"

    //Slice - създава подмасив от нашия главен масив
    //names = ["Desi", "Iva", "Ivan", "Gosho, "Mitko"]
    let subArray = names.slice(0,3);//включва всички елементи от 0 до 3 позиция, но този на 3 позиция не го включва
    //subArray = ["Desi", "Iva", "Ivan"]

    //Includes - проверка дали даден елемент се включва в масива; отговор true or false
    //names = ["Desi", "Iva", "Ivan", "Gosho, "Mitko"]
    console.log(names.includes("Desi")) //true
    let isInArray = names.includes("Nade")
    names.includes("Nade")//false
    if (names.includes("Ivan")){
        console.log("Ivan is here.")
    }

    //IndexOf - търсене на елемент по неговия индекс
    //names = ["Desi", "Iva", "Ivan", "Gosho, "Mitko"]
    let index = names.indexOf("Ivan");//2
    console.log(names.indexOf("Gosho"));//3
    console.log(names.indexOf("Orlin"));//-1 -> няма такъв

    //обхождане на масив
    //начин 1: for loop
    for(let position = 0; position <= names.length - 1; position++){
        let currentElement = names[position];//текущия елемент
        console.log(currentElement);
    }

    //начин 2: foreach loop
    names.forEach(element => console.log(element));

    //начин 3: for of
    for (let name in names){
        console.log(name); //отпечатва всеки един елемент от масива names
    }

    //Map - прилагаме функция върху всеки един елемент от масива и получаваме нов масив;
    let dates = [1, 4, 9]
    let roots = dates.map(function(num, i, arr) {
        return Math.sqrt(num)
    })
    //взима масива dates и прилага корен квадратен на всеки елемент
    //root = [1, 2, 3]

    //Find - намира първия елемент, които да отговаря на някакво условие
    let array1 = [5, 12, 8, 130, 44]
    let found = array1.find(function(element){
        return element > 10;
    });
    console.log(found);//12

    //Filter - създава нов масив с филтрирани елементи
    

demoArray();