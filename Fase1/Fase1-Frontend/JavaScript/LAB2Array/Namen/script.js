document.addEventListener("DOMContentLoaded", function() {
    let numberOfNames = parseInt(prompt("hoeveel namen wil je in de array stoppen? (minimaal 3)"));

    // check aantal namen
    while (isNaN(numberOfNames) || numberOfNames < 3) {
        numberOfNames = parseInt(prompt("minimaal 3 namen, probeer nog eens"));
    }

    let names = [];
    for (let i = 0; i < numberOfNames; i++) {
        names.push(prompt(`voer naam ${i + 1} in`)); // note: andere " vanwege naamaantal
    }

    // print van originele namen
    document.getElementById("originalNames").textContent = names.join(", ");

    // print van namen in omgekeerde volgorde
    document.getElementById("reversedNames").textContent = names.slice().reverse().join(", ");
});
