// Посчитать сумму элементов массива с нечетными индексами

function sumOddElArray(array){
       if (typeof array != 'object'){
              return false;
       }
       if(arguments.length > 1){
              return false;
       }
       let oddSum = 0;
       for (let i = 0; i < array.length; i++) {
              if(i % 2 != 0 ){
                     oddSum += array[i];
              }
       }
       return oddSum;
}




