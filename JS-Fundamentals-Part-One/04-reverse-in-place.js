function reverseStringArray(array){
    //array = ['abc', 'def', 'hig', 'klm', 'nop']
    array.reverse();
    //['nop', 'klm', 'hig', 'def', 'abc']
    console.log(array.join(" "));
}

reverseStringArray(['abc', 'def', 'hig', 'klm', 'nop']);