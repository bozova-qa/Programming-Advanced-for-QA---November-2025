function demoObjects(){
    //object - структурирано съхранение на информация
    //properties - характеристики
    //methods - действия

    //създаване на обект

    const personIvan = {
        name: "Ivan",
        age: 20,
        town: "Plovdiv",
        sayHello: function(){
            console.log("Hello");//метод, действие
        }
    };//name, age, town - properties
    console.log(personIvan.age);
    console.log(personIvan.sayHello);

    const dogAra = {
        name: "Sharo",
        age: 2,
        breed: "Puddle",
        sayBau: function(){
            console.log("Wof!");
        }
    }

    const dogSharo = {};//празен обект + добавяме properties с .
    dogSharo.name = "Sharo";
    dogSharo.age = 2;
    dogSharo.breed = "Terrier";
    dogSharo["color"] = "brown";
    dogSharo.sayHello = () => console.log("Hi, guys");

    //built-in methods for objects
    Object.keys(personIvan);//["name", "age", "town"] - масив от всички properties
    Object.values(personIvan);//["Ivan", 20, "Plovdiv"] - масив от стойности
    Object.entries(personIvan);//[["name", "Ivan"], ["age", 20], ["town","Plovdiv"]]масив от всички двойки записи

    //обхождане на обект - for of
    for(let key of Object.keys(personIvan)){
        console.log(`${key}: ${obj[key]}`);//отпечатва характеристика и ключът срещу тази характеристика
    }


}