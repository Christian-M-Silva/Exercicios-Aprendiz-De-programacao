const url = "http://localhost:5501/api"
/*
function getUsers() {
    fetch(url)
        .then(result => result.json())
        .then(user => document.getElementById("apiResult").innerHTML = JSON.stringify(user.users))
        .catch(erro => console.error(erro))
} 

getUsers()
*/

function getUser() {
    fetch(`${url}/1`)
        .then(result => result.json())
        .then(user => {
            document.getElementById("apiResult").innerHTML = JSON.stringify(user)
            userName.textContent = user.name
            userState.textContent = user.city
            userImg.src = user.avatar
        })
        .catch(error => console.error(error))
}

getUser()