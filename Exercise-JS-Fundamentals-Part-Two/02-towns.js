function towns(array){
    class Town{
        constructor(name, latitude, longitude){
            this.name = name,
            this.latitude = Number(latitude),//трябва да е парс-нато
            this.longitude = Number(longitude);
        }
    }
    for (const element of array) {
        let[name, latitude, longitude] = element.split(" | ")//creates array, assigns each a separate variable
        
        //създаваме нов празен обект на Town
        let city = new Town(name, latitude, longitude)
        console.log(`{ town: '${city.name}', latitude: '${city.latitude.toFixed(2)}', longitude: '${city.longitude.toFixed(2)}' }`);
    }


}

towns(['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625'])