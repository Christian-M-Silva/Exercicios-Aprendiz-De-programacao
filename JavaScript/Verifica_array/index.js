/*Seu objetivo é implementar uma função de diferença, que subtrai uma lista de outra e retorna o resultado.

Ele deve remover todos os valores dea primeira lista, que estão presentes na segunda lista mantendo sua ordem.

arrayDiff([1,2],[1]) == [2]

Se um valor estiver presente em b, todas as suas ocorrências devem ser removidas do outro:

arrayDiff([1,2,2,2,3],[2]) == [1,3]*/



function arrayDifferent(arr1, arr2) {
    arr1 = [2,2,2,1,3,6]
    arr2 = [1,2,4,5]
    let newArray;
    let newFirstArray
    let newSecondArray

    newFirstArray = arr1.filter(x => !arr2.includes(x))

    newSecondArray = arr2.filter(x => !arr1.includes(x))

    newArray = newFirstArray.concat(newSecondArray)

    return newArray;
}

console.log(arrayDifferent())