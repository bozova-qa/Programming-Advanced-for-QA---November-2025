function meetings(array){
    //array = ['Monday Peter',
    //'Wednesday Bill',
    //'Monday Tim',
    //'Friday Tim']
    
    let schedule ={};
    for(let element of array){
        //element = 'Monday Peter'
        let weekday = element.split(" ")[0];
        let name = element.split(" ")[1];
    
        if (schedule.hasOwnProperty(weekday)){
            console.log(`Conflict on ${weekday}!`)
        }
        else{
            schedule[weekday] = name;
            console.log(`Scheduled for ${weekday}`)
        }
    }

    //отпечатваме schedule
    for (let key in schedule){
        console.log(key + " -> " + schedule[key]);
    }

}

meetings(['Monday Peter',
 'Wednesday Bill',
 'Monday Tim',
 'Friday Tim']
)