export function sum(arr) {
    //arr = [3, 4, 5, 6]
    let sum = 0;
    for (let num of arr){
        sum += Number(num);
    }
    return sum; //18
}
