function note (note1, note2, note3, note4){
    note1 = parseInt(prompt("Qual foi a nota do 1° Bimestre?"))
    note2 = parseInt(prompt("Qual foi a nota do 2° Bimestre?"))
    note3 = parseInt(prompt("Qual foi a nota do 3° Bimestre?"))
    note4 = parseInt(prompt("Qual foi a nota do 4° Bimestre?"))

    let finalGrade = (note1 + note2 + note3 + note4) / 4

    if(finalGrade >= 90){
        document.getElementById('note').innerHTML = "A"
    }
    else if(finalGrade<90 && finalGrade>79){
        document.getElementById('note').innerHTML = "B"
    }
    else if(finalGrade<80 && finalGrade>69){
        document.getElementById('note').innerHTML = "C"
    }
    else if(finalGrade<70 && finalGrade>59){
        document.getElementById('note').innerHTML = "D"
    }
    else{
        document.getElementById('note').innerHTML = "F"
    }
}