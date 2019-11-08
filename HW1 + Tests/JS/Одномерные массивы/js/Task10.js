let arrayQuick = [1, 144, 22, 7, 4, 74, 121, -2, -3, 88];
function quickSort(array) {
    if ( typeof(masive) !== 'object' ){
        return false
    }
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }

    if (array.length <= 1) {
        return array;
    }
    let pivot = array[array.length - 1];
    let left = [];
    let right = [];

    for (let i = 0; i < array.length - 1; i++) {

        if (array[i] < pivot) {
            left.push(array[i]);
        } else {
            right.push(array[i]);
        }

    }

    return [...quickSort(left), pivot, ...quickSort(right)];

}