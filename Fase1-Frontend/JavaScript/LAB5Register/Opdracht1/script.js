document.addEventListener("DOMContentLoaded", function() {
    fetch('opdracht1_bijlage.json')
      .then(response => response.json())
      .then(data => {
        displayPersonInfo(data);
      })
      .catch(error => console.error('Error fetching JSON:', error));
  
    function displayPersonInfo(person) {
      const container = document.getElementById('personInfo');
      container.innerHTML = '';
  
      for (const key in person) {
        if (person.hasOwnProperty(key)) {
          const label = document.createElement('span');
          label.className = 'label';
          label.textContent = key.charAt(0).toUpperCase() + key.slice(1) + ': ';
  
          const value = document.createElement('span');
          value.className = 'value';
          value.textContent = person[key];
  
          const div = document.createElement('div');
          div.className = 'person-info';
          div.appendChild(label);
          div.appendChild(value);
  
          container.appendChild(div);
        }
      }
    }
  });
  