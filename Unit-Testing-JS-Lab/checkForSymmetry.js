export function isSymmetric(arr) {
    if (!Array.isArray(arr)){
        return false; // Non-arrays are non-symmetric; проверява дали е масив
    }
    let reversed = arr.slice(0).reverse(); // Clone and reverse, обръща го и сравнява дали е еднакъв от двете страни
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}
