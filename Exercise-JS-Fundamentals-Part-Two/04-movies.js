function movies(inputArray){
    let allMovies = []; //празен масив, в който ще пазим обекти за всеки филм

    for (const element of inputArray) {
        if(element.startsWith('addMovie')){
            let movieName = element.substring(9) //Take the substring of element starting from index 9 until the end.
            allMovies.push({name: movieName})  // добавям анонимен обект
        } else if (element.includes('directedBy')){
            let [movieName, directorName] = element.split(' directedBy ')

            // търся по име дали има такъв филм в моята колекци
            let movie = allMovies.find( m => m.name === movieName)
            
            // ако е намерило филм, мога да го ползвам като True
            // в другия случай undefined -> False
            if (movie){
                movie.director = directorName // добавям пропърти director по референция
            }
        } else if (element.includes('onDate')){
            let [movieName, movieDate] = element.split(' onDate ')

            // търся по име дали има такъв филм в моята колекция
            let movie = allMovies.find( m => m.name === movieName)

            if (movie){
                movie.date = movieDate // добавям пропърти date по референция
            }
        }
    }

    for (const movie of allMovies) {
        if (movie.name && movie.director && movie.date){
            console.log(JSON.stringify(movie))
        }
    }
}

movies([
'addMovie Fast and Furious',
'addMovie Godfather',
'Inception directedBy Christopher Nolan',
'Godfather directedBy Francis Ford Coppola',
'Godfather onDate 29.07.2018',
'Fast and Furious onDate 30.07.2018',
'Batman onDate 01.08.2018',
'Fast and Furious directedBy Rob Cohen'
])