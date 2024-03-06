function generateFibonacci() {
    var input = document.getElementById("number").value;
    var resultDiv = document.getElementById("result");
    resultDiv.innerHTML = ""; // Clear previous results

    if (input < 1 || input > 20) {
        resultDiv.textContent = "Voer een getal tussen 1 en 20 in.";
        return;
    }

    var fibonacciArray = [0, 1];
    for (var i = 2; i < input; i++) {
        fibonacciArray.push(fibonacciArray[i - 1] + fibonacciArray[i - 2]);
    }

    resultDiv.textContent = "Fibonacci reeks: " + fibonacciArray.join(", ");
}
