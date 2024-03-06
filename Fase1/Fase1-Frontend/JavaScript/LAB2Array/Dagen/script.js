document.addEventListener("DOMContentLoaded", function() {
    const daysOfWeek = ["maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag"];
    
    // dagen van de week
    document.getElementById("allDays").textContent = daysOfWeek.join(", ");

    // werkdagen
    document.getElementById("workDays").textContent = daysOfWeek.slice(0, 5).join(", ");

    // weekenddagen
    document.getElementById("weekendDays").textContent = daysOfWeek.slice(5).join(", ");

    // weekdagen in omgekeerde volgorde
    document.getElementById("allDaysReverse").textContent = daysOfWeek.slice().reverse().join(", ");

    // werkdagen omgekeerde volgorde
    document.getElementById("workDaysReverse").textContent = daysOfWeek.slice(0, 5).reverse().join(", ");

    // weekend omgekeerde volgorde
    document.getElementById("weekendDaysReverse").textContent = daysOfWeek.slice(5).reverse().join(", ");
});
