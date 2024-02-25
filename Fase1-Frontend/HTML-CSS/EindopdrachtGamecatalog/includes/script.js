
function navigation(game, nav) {
    // alle containers niet zichtbaar
    let containers = document.querySelectorAll('.container');
    for (const element of containers) {
      element.classList.add('hide');
    }
  
    // alleen geslecteerd zichtbaar
    let container = document.querySelector('.' + game);
    container.classList.remove('hide');
  
    // remove 'active' klasse van alle navigatie-elementen
    let navigationElements = document.querySelectorAll('.games a');
    for (const element of navigationElements) {
      element.classList.remove('active');
    }
  
    // add 'active' klasse toe aan het geselecteerde navigatie-element
    nav.classList.add('active');
  }
  