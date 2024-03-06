document.addEventListener("DOMContentLoaded", function() {
    const container = document.getElementById("container");
    const numButtons = 30; 

    // rijen
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
    button.dataset.clicks = 0; 
    button.addEventListener("click", function() {
        const currentClicks = parseInt(this.dataset.clicks);
        switch (currentClicks) {
            case 0:
                this.style.backgroundColor = "red";
                break;
            case 1:
                this.style.backgroundColor = "purple";
                break;
            case 2:
                this.style.backgroundColor = "blue";
                break;
            case 3:
                this.style.backgroundColor = "black";
                break;
            case 4:
                this.remove(); 
                break;
            default:
                break;
        }
        this.dataset.clicks = currentClicks + 1; 
    });
    return button; // return value
}
