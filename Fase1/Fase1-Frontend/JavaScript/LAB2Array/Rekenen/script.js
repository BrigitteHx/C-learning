var arrayEen = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var arrayTwee = [2, 4, 6, 8, 10, 12, 14, 16, 18, 20];

function optellen(arr1, arr2) {
    var output = document.getElementById('output');
    var html = '<div class="operation"><h2>Optellen van de twee arrays:</h2>';
    for (var i = 0; i < arr1.length; i++) {
        html += arr1[i] + '+' + arr2[i] + '=' + (arr1[i] + arr2[i]) + '<br>';
    }
    html += '</div>';
    output.innerHTML += html;
}

function aftrekken(arr1, arr2) {
    var output = document.getElementById('output');
    var html = '<div class="operation"><h2>Aftrekken van de twee arrays:</h2>';
    for (var i = 0; i < arr1.length; i++) {
        html += arr2[i] + '-' + arr1[i] + '=' + (arr2[i] - arr1[i]) + '<br>';
    }
    html += '</div>';
    output.innerHTML += html;
}

function vermenigvuldigen(arr1, arr2) {
    var output = document.getElementById('output');
    var html = '<div class="operation"><h2>Vermenigvuldigen van de twee arrays:</h2>';
    for (var i = 0; i < arr1.length; i++) {
        html += arr1[i] + '*' + arr2[i] + '=' + (arr1[i] * arr2[i]) + '<br>';
    }
    html += '</div>';
    output.innerHTML += html;
}

function delen(arr1, arr2) {
    var output = document.getElementById('output');
    var html = '<div class="operation"><h2>Delen van de twee arrays:</h2>';
    for (var i = 0; i < arr1.length; i++) {
        html += arr2[i] + '/' + arr1[i] + '=' + (arr2[i] / arr1[i]) + '<br>';
    }
    html += '</div>';
    output.innerHTML += html;
}

optellen(arrayEen, arrayTwee);
aftrekken(arrayEen, arrayTwee);
vermenigvuldigen(arrayEen, arrayTwee);
delen(arrayEen, arrayTwee);
