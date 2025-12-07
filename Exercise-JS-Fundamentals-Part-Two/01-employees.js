function employees(array){
    let person = {};//празен обект

    for (const element of array) {
        person.name = element;//създаваме property на person
        person.personalNumber = element.length;
        console.log(`Name: ${person.name} -- Personal Number: ${person.personalNumber}`)
    }

}

employees([
'Silas Butler',
'Adnaan Buckley',
'Juan Peterson',
'Brendan Villarreal'
]
)