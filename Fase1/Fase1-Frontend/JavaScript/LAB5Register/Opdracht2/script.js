document.addEventListener("DOMContentLoaded", function() {
    fetch('opdracht2_bijlage.json')
      .then(response => response.json())
      .then(data => {
        displayPersons(data);
      })
      .catch(error => console.error('Error fetching JSON:', error));
  
    function displayPersons(persons) {
      const container = document.getElementById('personContainer');
      container.innerHTML = '';
  
      persons.forEach(person => {
        const personDiv = document.createElement('div');
        personDiv.className = 'person-info';
  
        for (const key in person) {
          if (person.hasOwnProperty(key)) {
            const label = document.createElement('span');
            label.className = 'label';
            label.textContent = key.charAt(0).toUpperCase() + key.slice(1) + ': ';
  
            const value = document.createElement('span');
            value.className = 'value';
            value.textContent = person[key];
  
            const br = document.createElement('br');
  
            personDiv.appendChild(label);
            personDiv.appendChild(value);
            personDiv.appendChild(br);
          }
        }
  
        container.appendChild(personDiv);
      });
    }
  });
  