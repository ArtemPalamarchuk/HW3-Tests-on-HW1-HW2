describe("function minElArray() Найти минимальный элемент массива ", function() {
    it("call function minElArray with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ] and return -2", function () {
        const a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ];
        const exp = -2;
        const act = minElArray(a);

        assert.deepEqual(act, exp);
    });
    it("call function minElArray with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ] and return -2", function () {
        const a = ['1' , '22' , '7' , 4 , '74' , '88' , '-2'  , 121 ];
        const exp = '-2';
        const act = minElArray(a);

        assert.deepEqual(act, exp);
    });
    it("call function minElArray with a = 2 and return false", function () {
        const a = 2;
        const exp = false;
        const act = minElArray(a);

        assert.deepEqual(act, exp);
    });
    it("call function minElArray with a = 2 , b = 3 and return false", function () {
        const a = 2;
        const b = 3;
        const exp = false;
        const act = minElArray(a , b);

        assert.deepEqual(act, exp);
    });
});

describe('Функция findMax принимает один аргумент array в виде массива и находит его максимальный элемент', function () {
    it('Функция принимает в аргумент не объект, ожидание false', function () {
        const a = 1;
        const exp = false;
        const act = findMax(a);

        assert.equal(exp, act);
    });

    it('Функция не принимает аргумента, ожидание false', function () {
        const exp = false;
        const act = findMax();

        assert.equal(exp, act);
    });

    it('Функция принимает более одного аргумента, ожидание false', function () {
        const arr = [1,2,3,4];
        const b = 1;
        const exp = false;
        const act = findMax(arr, b);

        assert.equal(exp, act);
    });

    it('Функция принимает массив чисел 48,2,4,1,95,6,7,-15,111 , ожидание 111', function () {
        const newArray = [48,2,4,1,95,6,7,-15,111];
        const exp = 111;
        const act = findMax(newArray);

        assert.equal(exp, act);
    });

    it('Функция принимает массив чисел -48,2,-4,1,-95,-6,7,-15,-111 , ожидание 7', function () {
        const newArray = [-48,2,-4,1,-95,-6,7,-15,-111];
        const exp = 7;
        const act = findMax(newArray);

        assert.equal(exp, act);
    })

});

describe('Функия принимает один аргумент array в виде массива и находит индекс минимального элемента', function () {

    it('Функция принимает в аргумент не объект, ожидание false', function () {
        const a = 1;
        const exp = false;
        const act = findMinIndex(a);

        assert.equal(exp, act);
    });

    it('Функция не принимает аргумента, ожидание false', function () {
        const exp = false;
        const act = findMinIndex();

        assert.equal(exp, act);
    });

    it('Функция принимает более одного аргумента, ожидание false', function () {
        const arr = [1,2,3,4];
        const b = 1;
        const exp = false;
        const act = findMinIndex(arr, b);

        assert.equal(exp, act);
    });

    it('Функция принимает массив чисел 48,2,4,1,95,6,7,-15,111 , ожидание 7', function () {
        const newArray = [48,2,4,1,95,6,7,-15,111];
        const exp = 7;
        const act = findMinIndex(newArray);

        assert.equal(exp, act);
    })

    it('Функция принимает массив чисел -48,2,-4,1,-95,-6,7,-15,-111 , ожидание 7', function () {
        const newArray = [-48,2,-4,1,-95,-6,7,-15,-111];
        const exp = 8;
        const act = findMinIndex(newArray);

        assert.equal(exp, act);
    })
});


describe("function maxElArray() Найти индексмаксимального элемента массива ", function() {
    it("call function maxElArray with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ]and return 7", function () {
        const a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ];
        const exp = 7;
        const act = maxElArray(a);

        assert.deepEqual(act, exp);
    });
    it("call function maxElArray with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ]and return 7", function () {
        const a = ['1' , '22' , '7' , '4' , 74 , 88 , -2  , '121' ];
        const exp = 7;
        const act = maxElArray(a);
        console.log(a)
        assert.equal(act, exp);
    });
    it("call function maxElArray with a = 2 and return false", function () {
        const a = 2;
        const exp = false;
        const act = maxElArray(a);

        assert.deepEqual(act, exp);
    });
    it("call function maxElArray with a = 2 , b = 3 and return false", function () {
        const a = 2;
        const b = 3;
        const exp = false;
        const act = maxElArray(a , b);

        assert.deepEqual(act, exp);
    });
});

describe("function sumOddElArray() Посчитать сумму элементов массива с нечетными индексами ", function() {
    it("call function sumOddElArray with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ]and return 235", function () {
        const a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ];
        const exp = 235;
        const act = sumOddElArray(a);

        assert.deepEqual(act, exp);
    });

    it("call function sumOddElArray with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ]and return 7", function () {
        const a = ['1' , '22' , '7' , '4' , 74 , 88 , -2  , '121' ];
        const exp = '022488121';
        const act = sumOddElArray(a);
        assert.equal(act, exp);
    });
    it("call function sumOddElArray with a = 2 and return false", function () {
        const a = 2;
        const exp = false;
        const act = sumOddElArray(a);

        assert.deepEqual(act, exp);
    });
    it("call function sumOddElArray with a = 2 , b = 3 and return false", function () {
        const a = 2;
        const b = 3;
        const exp = false;
        const act = sumOddElArray(a , b);

        assert.deepEqual(act, exp);
    });

});

describe("function reverseArr() сделать реверс массива ", function() {
    it("call function reverseArr with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ]and return 235", function () {
        const a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ];
        const exp = [121 , -2 , 88 , 74 , 4, 7 , 22 , 1 ];
        const act = reverseArr(a);

        assert.deepEqual(act, exp);
    });

    it("call function reverseArr with a = [1 , 22 , 7 , 4 , 74 , 88 , -2  , 121 ]and return 7", function () {
        const a = ['1' , '22' , '7' , '4' , 74 , 88 , -2  , '121' ];
        const exp = ['121' , -2 , 88 , 74 , '4', '7' , '22' , '1' ];
        const act = reverseArr(a);
        assert.deepEqual(act, exp);
    });
    it("call function reverseArr with a = 2 and return false", function () {
        const a = 2;
        const exp = false;
        const act = reverseArr(a);

        assert.deepEqual(act, exp);
    });
    it("call function reverseArr with a = 2 , b = 3 and return false", function () {
        const a = 2;
        const b = 3;
        const exp = false;
        const act = reverseArr(a , b);

        assert.deepEqual(act, exp);
    });

});


describe('Функция принимает аргумент в виде массива и выводит количество его нечетных элементов', function () {
    it('Функция принимает массив 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 , ожидание 6 ', function () {
        const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
        const exp = 6;
        const act = quantityСalculation(arr);

        assert.equal(exp, act);
    });

    it('Функция принимает массив 1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11 , ожидание 6 ', function () {
        const arr = [1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11];
        const exp = 6;
        const act = quantityСalculation(arr);

        assert.equal(exp, act);
    });

    it('Функция принимает в аргумент не объект, ожидание false', function () {
        const a = 1;
        const exp = false;
        const act = quantityСalculation(a);

        assert.equal(exp, act);
    });

    it('Функция не принимает аргумента, ожидание false', function () {
        const exp = false;
        const act = quantityСalculation();

        assert.equal(exp, act);
    });

    it('Функция принимает более одного аргумента, ожидание false', function () {
        const arr = [1,2,3,4];
        const b = 1;
        const exp = false;
        const act = quantityСalculation(arr, b);

        assert.equal(exp, act);
    });
});

describe('Функция принимает аргумент в виде массива и меняет местами первую и вторую его части', function () {
    it('Функция принимает массив 1, 2, 3, 4, , ожидание 3, 4, 1, 2 ', function () {
        const arr = [1, 2, 3, 4];
        const exp = [3, 4, 1, 2];
        const act = switchHalf(arr);

        assert.deepEqual(exp, act);
    });

    it('Функция принимает массив 1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11, 12 ,' +
        ' ожидание -7, 8, 9, 10, -11, 12, 1, -2, -3, 4, 5, -6', function () {
        const arr = [1,-2,-3,4,5,-6,-7,8,9,10,-11,12];
        const exp = [-7,8,9,10,-11,12,1,-2,-3,4,5, -6];
        const act = switchHalf(arr);

        assert.deepEqual(exp, act);
    });

    it('Функция принимает в аргумент не объект, ожидание false', function () {
        const a = 1;
        const exp = false;
        const act = switchHalf(a);

        assert.equal(exp, act);
    });

    it('Функция не принимает аргумента, ожидание false', function () {
        const exp = false;
        const act = switchHalf();

        assert.equal(exp, act);
    });

    it('Функция принимает более одного аргумента, ожидание false', function () {
        const arr = [1,2,3,4];
        const b = 1;
        const exp = false;
        const act = switchHalf(arr, b);

        assert.equal(exp, act);
    });
});
describe('Функции сортировки по 9 заданию', function () {

    describe('Функция принимает аргумент в виде массива и производит сортировку Пузырьком (buble sort)', function () {
        it('Функция принимает массив 15,2,4,-5,99,8 , ожидание -5,2,4,8,15,99 ', function () {
            const arr = [15,2,4,-5,99,8];
            const exp = [-5,2,4,8,15,99];
            const act = sortBubble(arr);

            assert.deepEqual(exp, act);
        });

        it('Функция принимает массив 1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11 ,' +
            '  ожидание -11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10 ', function () {
            const arr = [1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11];
            const exp = [-11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10];
            const act = sortBubble(arr);

            assert.deepEqual(exp, act);
        });

        it('Функция принимает в аргумент не объект, ожидание false', function () {
            const a = 1;
            const exp = false;
            const act = sortBubble(a);

            assert.equal(exp, act);
        });

        it('Функция не принимает аргумента, ожидание false', function () {
            const exp = false;
            const act = sortBubble();

            assert.equal(exp, act);
        });

        it('Функция принимает более одного аргумента, ожидание false', function () {
            const arr = [1,2,3,4];
            const b = 1;
            const exp = false;
            const act = sortBubble(arr, b);

            assert.equal(exp, act);
        });
    });

    describe('Функция принимает аргумент в виде массива и производит сортировку sortInsert', function () {
        it('Функция принимает массив 15,2,4,-5,99,8 , ожидание -5,2,4,8,15,99 ', function () {
            const arr = [15,2,4,-5,99,8];
            const exp = [-5,2,4,8,15,99];
            const act = sortInsert(arr);

            assert.deepEqual(exp, act);
        });

        it('Функция принимает массив 1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11 ,' +
            '  ожидание -11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10 ', function () {
            const arr = [1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11];
            const exp = [-11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10];
            const act = sortInsert(arr);

            assert.deepEqual(exp, act);
        });

        it('Функция принимает в аргумент не объект, ожидание false', function () {
            const a = 1;
            const exp = false;
            const act = sortInsert(a);

            assert.equal(exp, act);
        });

        it('Функция не принимает аргумента, ожидание false', function () {
            const exp = false;
            const act = sortInsert();

            assert.equal(exp, act);
        });

        it('Функция принимает более одного аргумента, ожидание false', function () {
            const arr = [1,2,3,4];
            const b = 1;
            const exp = false;
            const act = sortInsert(arr, b);

            assert.equal(exp, act);
        });
    });

    describe('Функция принимает аргумент в виде массива и производит сортировку sortSelect', function () {
        it('Функция принимает массив 15,2,4,-5,99,8 , ожидание -5,2,4,8,15,99 ', function () {
            const arr = [15,2,4,-5,99,8];
            const exp = [-5,2,4,8,15,99];
            const act = sortSelect(arr);

            assert.deepEqual(exp, act);
        });

        it('Функция принимает массив 1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11 ,' +
            '  ожидание -11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10 ', function () {
            const arr = [1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11];
            const exp = [-11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10];
            const act = sortSelect(arr);

            assert.deepEqual(exp, act);
        });

        it('Функция принимает в аргумент не объект, ожидание false', function () {
            const a = 1;
            const exp = false;
            const act = sortSelect(a);

            assert.equal(exp, act);
        });

        it('Функция не принимает аргумента, ожидание false', function () {
            const exp = false;
            const act = sortSelect();

            assert.equal(exp, act);
        });

        it('Функция принимает более одного аргумента, ожидание false', function () {
            const arr = [1,2,3,4];
            const b = 1;
            const exp = false;
            const act = sortSelect(arr, b);

            assert.equal(exp, act);
        });
    });
});

describe('Функция принимает аргумент в виде массива и производит сортировку quickSort', function () {
    it('Функция принимает массив 15,2,4,-5,99,8 , ожидание -5,2,4,8,15,99 ', function () {
        const arr = [15,2,4,-5,99,8];
        const exp = [-5,2,4,8,15,99];
        const act = quickSort(arr);

        assert.deepEqual(exp, act);
    });

    it('Функция принимает массив 1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11 ,' +
        '  ожидание -11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10 ', function () {
        const arr = [1, -2, -3, 4, 5, -6, -7, 8, 9, 10, -11];
        const exp = [-11, -7, -6, -3, -2 , 1, 4, 5, 8, 9, 10];
        const act = quickSort(arr);

        assert.deepEqual(exp, act);
    });

    it('Функция принимает в аргумент не объект, ожидание false', function () {
        const a = 1;
        const exp = false;
        const act = quickSort(a);

        assert.equal(exp, act);
    });

    it('Функция не принимает аргумента, ожидание false', function () {
        const exp = false;
        const act = quickSort();

        assert.equal(exp, act);
    });

    it('Функция принимает более одного аргумента, ожидание false', function () {
        const arr = [1,2,3,4];
        const b = 1;
        const exp = false;
        const act = quickSort(arr, b);

        assert.equal(exp, act);
    });
});