// Найти индекс максимального элемента массива

function maxElArray(array){
    if (typeof array != 'object'){
        return false;
    }
    if(arguments.length > 1){
        return false;
    }
    let max = array[0];
    let indexArray = 0;
    for (let i = 0; i < array.length; i++) {
        if (array[i] > max) {
            max = array[i];
            indexArray = i;
        }
    }
    return indexArray;
}


