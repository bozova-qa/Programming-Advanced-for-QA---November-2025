function oddOccurences(sentence){
    //правим всички с малки букви
    //разделяме ги в масив с интервали
    let words = sentence.toLowerCase().split(" ");

    //създаваме един празен обект/ речник
    let outputWords = {};

    for(const word of words){
        if(outputWords[word]){//ако се съдържа в outputwords
            outputWords[word]++;//ако го има, увеличаваме
        }
        else {
            outputWords[word] = 1;//ако не, ще го добавим
        }
    }
    // създаваме празен масив за думите срещнати нечетен брой пъти
    let outputArray = []

    // този for-in цикъл връша само ключвете!!!
    for (const key of outputWords) {
        if(outputWords[key] % 2 !== 0){
            outputArray.push(key)
        }  
    }

    console.log(outputArray.join(' '))
}

oddOccurences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')