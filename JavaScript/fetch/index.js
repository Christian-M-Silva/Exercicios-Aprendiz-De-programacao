fetch("https://api.github.com/users/Christian-M-Silva") 
    .then(result => console.log(result))
    .catch(err => console.log(err))