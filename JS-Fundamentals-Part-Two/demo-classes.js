//описваме как ще изглежда и какви действия ще има всеки един човек
class Person{
    //конструктор - създаване на обекти от класа
    constructor(name, age){//name е параметър
        this.name = name;//задаваме property на параметъра, name: "Desi", age: 12
        this.age = age;
    }

    sayHello(name){
        console.log("Hello!" + name);
    }
}
    //създаваме обект(инстанция) от класа Person
    const personIvan = new Person("Ivan", 20);
    const personDesi = new Person("Desi", 35);
