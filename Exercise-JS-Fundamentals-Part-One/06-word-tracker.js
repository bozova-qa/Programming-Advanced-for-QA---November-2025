function wordTracker(array){
    let wordsToTrack = array.shift().split(" ");//взима първия елемент и до сплитва

    let outputWords = {};//създаваме асоц масив/ речник

    // обхождаме всички думи в wordsToTrack и ги добавяме в речника като ключове със стойност 0
    for (const word of wordsToTrack) {
        outputWords[word] = 0
    }

    // обхождаме всички думи във входния масив и търсим съвпадения
    for (const currentWord of array) {
        // проверка дали има такъв ключ в речинка
        if(outputWords.hasOwnProperty(currentWord)){
            outputWords[currentWord]++
        }
    }

    // в JS не можем директно да сортираме речник (обект)
    // преобразувамe речника в масив
    let entries = Object.entries(outputWords)

    // сортираме масива с ключове и стойности, в обратен ред по стойност[1]
    entries.sort((a, b) => b[1] - a[1]) 

    for(let [word, count] of entries){
        console.log(`${word} - ${count}`)
    }
}

wordTracker([
'this sentence', 
'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
]
)