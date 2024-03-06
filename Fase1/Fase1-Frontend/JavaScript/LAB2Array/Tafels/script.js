var tafelArray = [2, 4, 6, 8]; 

function genereerTafels(tafelArray) {
    var output = document.getElementById('output');
    var html = '<div class="operation"><h2>Array met tafels:</h2>';
    
    tafelArray.forEach(function(getal) {
        html += '<h3>Tafel van ' + getal + ':</h3>';
        for (var i = 1; i <= 10; i++) {
            html += getal + ' x ' + i + ' = ' + (getal * i) + '<br>';
        }
    });
    
    html += '</div>';
    output.innerHTML += html;
}

genereerTafels(tafelArray);
