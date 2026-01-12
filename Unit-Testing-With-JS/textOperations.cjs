function printText (text){
    console.log(text);
}

function printLettersInText (text) {
    for (letter in text){
        console.log(letter);
    }
}

module.exports = {
    printText,
    printLettersInText
    }
