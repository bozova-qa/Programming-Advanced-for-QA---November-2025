function addressbook(array){
    let sortedBook = {};

    for (let entry of array) {
        let [name, address] = entry.split(":");
        sortedBook[name] = address;  
    }

    Object.keys(sortedBook)
            .sort()
            .forEach(name => {
                console.log(`${name} -> ${sortedBook[name]}`);
            })
}

addressbook(['Bob:Huxley Rd',
'John:Milwaukee Crossing',
'Peter:Fordem Ave',
'Bob:Redwing Ave',
'George:Mesta Crossing',
'Ted:Gateway Way',
'Bill:Gateway Way',
'John:Grover Rd',
'Peter:Huxley Rd',
'Jeff:Gateway Way',
'Jeff:Huxley Rd'])