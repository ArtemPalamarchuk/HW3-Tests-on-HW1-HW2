// Найти минимальный элемент массива


function minElArray(array){
        if(arguments.length > 1){
            return false;
        }
        if (typeof array != 'object'){
            return false;
        }
        let min = array[0];
        for(let i = 1; i < array.length; ++i){
            if(array[i] < min){
                min = array[i];
            }
        }
        return min;
}
