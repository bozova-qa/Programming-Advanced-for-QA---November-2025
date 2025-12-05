function phonebook(array){
    //array = ['Tim 0834212554',
    //'Peter 0877547887',
    //'Bill 0896543112',
    //'Tim 0876566344']

    //асоциативен масив: име(key) -> тел. номер(value)
    let phonebook = {};

    for(let element of array){
        //element - 'Tim 0834212554'
        let name = element.split(" ")[0];
        let phoneNumber = element.split(" ")[1];
        phonebook[name] = phoneNumber;//срещу това име в асоц. масив, слагаш този номер;
    }

    //отпечатваме асоц, масив
    for (let key in phonebook){
        console.log(key + " -> " + phonebook[key]);
    }
}

phonebook(['Tim 0834212554',
 'Peter 0877547887',
 'Bill 0896543112',
 'Tim 0876566344']
)