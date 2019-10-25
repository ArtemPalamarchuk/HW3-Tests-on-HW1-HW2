//Задание 8:Поменять местави первую и вторую половину масива, например, для масива 1 2 3 4, результат 3 4 1 2.
var newMyArray = [1, 2, 3, 4];
function switchHalf(array) {
    if ( typeof(array) !== 'object' ){
        return false
    }
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }
    var halfOfMasive = array.length / 2;
    for (var i = 0; i < halfOfMasive; i++) {
        var firstHalf = array[i];
        array[i] = array[halfOfMasive + i];
        array[halfOfMasive + i] = firstHalf;
    }
    return array
}

