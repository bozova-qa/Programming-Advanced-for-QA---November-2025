export function analyzeArray(arr) {
    if (!Array.isArray(arr) || arr.length === 0) {
        return undefined;
    }

    let min = arr[0];//първият елемент слагаме Min, max
    let max = arr[0];

    for (let i = 0; i < arr.length; i++) {
        if (typeof arr[i] !== 'number') {
            return undefined;
        }
        if (arr[i] < min) {//проверяваме дали всеки един е по-малък/ голям от първия
            min = arr[i];
        }
        if (arr[i] > max) {
            max = arr[i];
        }
}

    return { min, max, length: arr.length }; //връща обект
}
