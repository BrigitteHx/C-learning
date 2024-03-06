var num;

do {
    var userInput = prompt('voer een getal in tussen 1 en 20:');

    num = parseInt(userInput);

    if (isNaN(num) || num < 1 || num > 20) {
        alert('ongeldige invoer, voer een getal tussen 1 en 20 in.');
    }
} while (isNaN(num) || num < 1 || num > 20);

var output = document.getElementById('output');
var html = '<div class="operation"><h2>Piramide aflopend:</h2>';

// aflopende piramide
for (var i = num; i >= 0; i--) {
    for (var j = 0; j <= i; j++) {
        html += j;
    }
    html += '<br>';
}

html += '</div>';
output.innerHTML += html;
