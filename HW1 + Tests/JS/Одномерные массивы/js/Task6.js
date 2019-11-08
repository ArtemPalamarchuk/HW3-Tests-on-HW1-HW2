// Сделать реверс массива



function reverseArr(array){
    if (typeof array != 'object'){
        return false;
    }
    if(arguments.length > 1){
        return false;
    }
    let reverseArray = [];
    for(let i = array.length - 1; 0 <= i; i-- ){
        reverseArray.push(array[i]);
    }
    return reverseArray;
}


