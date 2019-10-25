function sortBubble(array) {
    if ( typeof(array) !== 'object' ){
        return false
    }
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }
    let tmp;
    for (var i = array.length - 1; i > 0; i--) {
        for (var j = 0; j < i; j++) {
            if (array[j] > array[j + 1]) {
                tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
    return array
}

function sortSelect(array) {
    if ( typeof(array) !== 'object' ){
        return false
    }
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }
    var tmp;
    for (var i = 0; i < array.length; i++) {
        for (var j = i; j < array.length;j++) {
            if (array[j] < array[i]) {
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
    return array
}

function sortInsert(array) {
    if ( typeof(array) !== 'object' ){
        return false
    }
    if(arguments.length > 1 || arguments.length == 0){
        return false
    }
    for (let n = 1, l = array.length; n < l; n++) {
        let current = array[n];
        let j = n
        for (j; j > 0 && array[j - 1] > current; j--) {
            array[j] = array[j - 1];
        }
        array[j] = current;

    }
    return array
}