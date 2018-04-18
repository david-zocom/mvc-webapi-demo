// Write your JavaScript code.

// hämta id
// lägga till eventlistener
// ajax request till API
// ta emot resultat och gör om till JSON
// presentera resultatet
let btn = document.getElementById('mysteryButton');
let div = document.getElementById('mysteryDiv');
// Med jQuery: let btn = $('#mysteryButton');

btn.addEventListener('click', function (event) {
    fetch('/Api/MysteryAnimal/1')
        .then(response => {
            return response.json();
        })
        .then(data => {
            console.log('data is:', data);
            div.innerHTML += '<br/>' + data.value;
        })
        .catch(error => {
            console.log('Something went wrong!', error);
        });
});
