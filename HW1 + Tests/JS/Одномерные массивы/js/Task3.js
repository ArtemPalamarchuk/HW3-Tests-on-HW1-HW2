//Задание 3: Найти индекс минимального элемента масива
var arr = [5, 12, 4, 7, 2, 9, 1, 5, 3, 26, 45, 6, 15, 8];

function findMinIndex(array) {
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }
    if ( typeof(array) !== 'object' ){
        return false
    }
    var min = array[0];
    for (var i = 0; i < array.length; i++) {
        if (min > array[i]) min = array[i];
    }
    return array.indexOf(min);
}
