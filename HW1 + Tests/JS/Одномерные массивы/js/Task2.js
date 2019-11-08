

let myArray = [5, 12, 4, 7, 2, 9, 1, 5, 3, 26, 45, 6, 15, 8];
function findMax(array) {
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }
    if ( typeof(array) !== 'object' ){
        return false
    }
    let max = array[0];
    for (var i = 0; i < array.length; i++) {
        if (max < array[i]) max = array[i];
    }
    return max;
}