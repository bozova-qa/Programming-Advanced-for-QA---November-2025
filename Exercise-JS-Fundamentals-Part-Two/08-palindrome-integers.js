function checkPalindrome(inputArray){
    //[123,323,421,121]
    //loop through each number
    for (const element of inputArray) {
        console.log(isPalindrome(element))
    }

    function isPalindrome(num){
        //convert numbers to string
        let numAsAString = num.toString()
        //reverse the string
        //"121".split('') → ["1","2","1"]
        //.reverse() → ["1","2","1"]
        //.join('') → "121"

        let reversedString = numAsAString.split('').reverse().join('')
        //check if the original string matches the reversed string;
        if(numAsAString === reversedString){
            return true
        } else {
            return false
        }
    }
}


//2 начин:
function palindromeIntegers(inputArray){
    for (const element of inputArray) {
        console.log(element == element.toString().split('').reverse().join(''))
    }
}

//element.toString() → "121"
//.split('') → ["1","2","1"]
//.reverse() → ["1","2","1"]
//.join('') → "121"

checkPalindrome([123,323,421,121])