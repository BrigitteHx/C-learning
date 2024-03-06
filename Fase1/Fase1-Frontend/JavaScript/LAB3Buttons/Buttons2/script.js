document.addEventListener("DOMContentLoaded", function() {
    const container = document.getElementById("container");
    const numButtons = 30; 
    
    for (let i = 0; i < numButtons / 5; i++) {
        const row = document.createElement("div");
        row.className = "button-row";
        
        // 5 buttons elke rij
        for (let j = 0; j < 5; j++) {
            const buttonNumber = i * 5 + j + 1;
            const button = createButton(buttonNumber);
            row.appendChild(button);
        }

        container.appendChild(row);
    }
});

// button element maken
function createButton(number) {
    const button = document.createElement("button");
    button.className = "number-button";
    button.innerText = number;
    button.addEventListener("click", function() {
        if (button.style.backgroundColor === "green") {
            button.style.backgroundColor = "red";
        } else {
            button.style.backgroundColor = "green";
        }
    });
    return button;
}
