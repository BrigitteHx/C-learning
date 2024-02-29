const greenButton = document.getElementById('green');
const redButton = document.getElementById('red');
const blueButton = document.getElementById('blue');

greenButton.addEventListener('click', () => {
  document.body.style.backgroundColor = 'green';
});

redButton.addEventListener('click', () => {
  document.body.style.backgroundColor = 'red';
});

blueButton.addEventListener('click', () => {
  document.body.style.backgroundColor = 'blue';
});