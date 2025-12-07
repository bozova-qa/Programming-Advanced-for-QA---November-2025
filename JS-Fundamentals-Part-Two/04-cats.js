class Cat {
    //характеристики: име и възраст
    constructor(name, age){
        this.name = name;
        this.age = age
        }
    
    //действия: мяу
    meow (){
            console.log(`${this.name}, age ${this.age} says Meow`);
    }
}

function cats(array){
    //array = ['Mellow 2', 'Tom 5']
    for(let text of array){
        let catName = text.split(" ")[0];//["Mellow", "2"]
        let catAge = text.split(" ")[1];

        const cat = new Cat(catName, catAge) //конструктор нов обект
        cat.meow();
    }
}

cats(['Mellow 2', 'Tom 5'])