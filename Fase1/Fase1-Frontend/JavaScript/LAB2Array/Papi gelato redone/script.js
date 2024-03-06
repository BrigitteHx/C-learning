
// variabelen
const ijs = {"bolletjes" : 0, "bakje" : 0, "hoorntje" : 0, "liter" : 0};
const toppings = {"toppings" : 0};
const keuze = ["A", "B", "C", "D"];
const prijzen = {"bolletjes" : 0.95, "bakje" : 0.75, "hoorntje" : 1.25, "liter" : 9.80};
const totaal = {"bolletjes" : 0, "hoorntje" : 0, "bakje" : 0, "toppings" : 0, "prijs" : 0};
var ijsGeplaatst;
var hoeveelBolletjes;

// type klant
function typeKlant() {
    var Klant = prompt("Bent u 1) particulier of 2) zakelijk?");
    if (Klant == 1) {
        hoeveelBolletjesFunction();
    } else if (Klant == 2) {
        zakelijk();
    } else {
        alert("Kies een gegeven optie");
        typeKlant();
    }
}

// voor zakelijk
function zakelijk() {
    var ijsLiter = prompt("Hoeveel liter ijs wilt u?");
    ijs["liter"] = ijsLiter;
    for (i = 1; i <= ijs["liter"]; i++) {
        var ijsSmaak = prompt("Welke smaak wilt u voor " + i + " liter ijs? A) Aardbei, C) chocolade of V) vanille?").toUpperCase();
    }
    maakBonnetje(2);
}


// hoeveel bolletjes
function hoeveelBolletjesFunction() {
    var hoeveelBolletjes = prompt("Hoeveel bolletjes wilt u?");
    var toegevoegdeBolletjes = parseInt(hoeveelBolletjes); 
    if (ijs["bolletjes"] + toegevoegdeBolletjes > 8) {
        alert("Sorry, zulke grote bakken hebben we niet");
        ijs["bolletjes"] = 0; // nul voordat recursief (anders worden de bolletjes alsnog meegeteld)
        hoeveelBolletjesFunction();
        return;
    }

    ijs["bolletjes"] += toegevoegdeBolletjes;

    if (ijs["bolletjes"] >= 4 && ijs["bolletjes"] <= 8) {
        alert("Dan krijgt u een bakje met " + ijs["bolletjes"] + " bolletjes van mij");
        ijsGeplaatst = "B";
        ijs["bakje"] += 1;
        smaak();
    } else {
        smaak();
    }
}


// smaak registratie 
function smaak() {
    for (i = 1; i <= ijs["bolletjes"]; i++) {
        var ijsSmaak = prompt("Welke smaak wilt u voor bolletje " + i + "? A) Aardbei, C) chocolade of V) vanille?").toUpperCase();
        switch (ijsSmaak) {
            case "A":
               continue;
            case "C":
                continue;
            case "V":
                continue;
            default:
                alert("Kies een gegeven optie");
                smaak();
        }
    }
    if (ijsGeplaatst) {
        topping();
    } else {
        plaatsingLogica();
    }
}

// hoorntje/ bakje
function plaatsingLogica() {
    var ijsGeplaatst = prompt("Wilt u deze " + ijs["bolletjes"] + " bolletjes in A) een hoorntje of B) een bakje? ").toUpperCase();
    switch (ijsGeplaatst) {
        case "A":
            ijs["hoorntje"] += 1;
            topping();
            break;
        case "B":
            ijs["bakje"] += 1;
            topping();
            break;
        default:
            alert("Kies een gegeven optie");
            plaatsingLogica();
    }
}

// toppings 
function topping() { 
    var ijsTopping = prompt("Wat voor topping wilt u: A) Geen, B) slagroom, C) sprinkels of D) caramel saus?").toUpperCase();
    if (keuze.includes(ijsTopping)) {
        if (ijsTopping != "A") {
            toppings["toppings"] += 1;
            meerBestellen(); 
        } else {
            meerBestellen(); 
        }
    } else {
        alert("Kies een gegeven optie");
        topping(); 
    }
}

// meer bestellen 
function meerBestellen() { 
    if (ijs["hoorntje"]) {
        var meerOfNiet = prompt("Hier is uw hoorntje met " + ijs["bolletjes"] + " bolletjes. Wilt u nog meer bestellen? (Y/N)").toUpperCase();
    } else {
        var meerOfNiet = prompt("Hier is uw bakje met " + ijs["bolletjes"] + " bolletjes. Wilt u nog meer bestellen? (Y/N)").toUpperCase();
    }


    if (meerOfNiet == "Y") {
        totaal["bolletjes"] += ijs["bolletjes"];
        totaal["hoorntje"] += ijs["hoorntje"];
        totaal["bakje"] += ijs["bakje"];
        totaal["toppings"] += toppings["toppings"];

        ijs["bolletjes"] = 0;
        ijs["hoorntje"] = 0;
        ijs["bakje"] = 0;
        
        toppings["toppings"] = 0;
        hoeveelBolletjesFunction();
    
    } else if (meerOfNiet == "N") {
        totaal["bolletjes"] += ijs["bolletjes"];
        totaal["hoorntje"] += ijs["hoorntje"];
        totaal["bakje"] += ijs["bakje"];
        totaal["toppings"] += toppings["toppings"];
        maakBonnetje(1);
    
    } else {
        alert("Kies een gegeven optie")
        meerBestellen();
    }
}

// bonnetje bouwen
function maakBonnetje(type) {
    if(type == 1) {
        totaal["prijs"] = 0 

        const title = document.createElement("h2");
        title.innerText = "Papi Gelato Receipt";
        document.body.appendChild(title);

        const receipt = document.createElement("p");
        document.body.appendChild(receipt);
        
        totaal["prijs"]+= (totaal["bolletjes"] * prijzen["bolletjes"]);
        receipt.innerText = "Prijs bolletjes: " + totaal["bolletjes"] + " x €"+ prijzen["bolletjes"] + " = €" + (totaal["bolletjes"] * prijzen["bolletjes"]).toFixed(2);
        receipt.innerHTML += "<br>";

        if (ijs["hoorntje"] > 0) {
            totaal["prijs"] += (ijs["hoorntje"] * prijzen["hoorntje"]);
            receipt.innerText += "Prijs hoorntje(s): " + ijs["hoorntje"] + " x €"+ prijzen["hoorntje"] + " = €" + (ijs["hoorntje"] * prijzen["hoorntje"]).toFixed(2);
            receipt.innerHTML += "<br>";
        }

        if (ijs["bakje"] > 0) {
            totaal["prijs"] += (ijs["bakje"] * prijzen["bakje"]);
            receipt.innerText += "Prijs bakje(s): " + ijs["bakje"] + " x €"+ prijzen["bakje"] + " = €" + (ijs["bakje"] * prijzen["bakje"]).toFixed(2);
            receipt.innerHTML += "<br>";
        }

        if (toppings["toppings"] > 0) {
            totaal["prijs"] += (toppings["toppings"] * 0.50);
            receipt.innerText += "Prijs topping: " + toppings["toppings"] + " x €"+ 0.50 + " = €" + (toppings["toppings"] * 0.50).toFixed(2);
            receipt.innerHTML += "<br>";
        }

        receipt.innerText += "Totale prijs: €" + totaal["prijs"];
    
    } else if (type ==2) {
        const title = document.createElement("h2");
        title.innerText = "Papi Gelato Receipt";
        document.body.appendChild(title);

        const receipt = document.createElement("p");
        document.body.appendChild(receipt);

        receipt.innerText = "Liter ijs: " + ijs["liter"] + "L x €" + prijzen["liter"] + " = €" + (ijs["liter"] * prijzen["liter"]).toFixed(2);
    }
}

// start 
typeKlant();