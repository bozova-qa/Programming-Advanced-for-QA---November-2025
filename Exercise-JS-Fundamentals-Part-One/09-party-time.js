function partyTime(array){
    let guestList = []

    while(array[0] !== 'PARTY'){
        let guestNumber = array.shift() // вадя госта от входния масив
        guestList.push(guestNumber)   // добавям госта в листа с гости
    }

    array.shift() // премахвам 'PARTY' от входния масив

    for (const commingGuest of array) {
        // проверявам дали идващия гост го има в списъка
        if(guestList.includes(commingGuest)){
            let guestIndex = guestList.indexOf(commingGuest)
            guestList.splice(guestIndex, 1) // прехамвам госта от листа (отбелязвам си, че е дошъл)
        }
    }

    let vipGuests = guestList.filter(guest => !isNaN(guest[0]))
    let regularGuests = guestList.filter(guest => isNaN(guest[0]))

    console.log(guestList.length)
    console.log(vipGuests.join('\n'))
    console.log(regularGuests.join('\n'))
}

partyTime(['7IK9Yo0h',
'9NoBUajQ',
'Ce8vwPmE',
'SVQXQCbc',
'tSzE5t0p',
'PARTY',
'9NoBUajQ',
'Ce8vwPmE',
'SVQXQCbc'
]
)