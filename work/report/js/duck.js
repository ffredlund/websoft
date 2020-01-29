"use strict";


(function () {

  var button = document.getElementById("button");
  var duck = document.getElementById("duck");
  duck.style.display = 'none';
  duck.style.position = 'absolute';
  duck.style.top = Math.floor(Math.random()*90+5)+'%';
  duck.style.left = Math.floor(Math.random()*90+5)+'%';


  button.addEventListener("click", function() {
    if (duck.style.display == 'none') {
      duck.style.display = 'block';
    } else {
      duck.style.display = 'none';
    }
  });

    duck.addEventListener("click", function() {
        duck.style.position = 'absolute';
        duck.style.top = Math.floor(Math.random()*90+5)+'%';
        duck.style.left = Math.floor(Math.random()*90+5)+'%';
    });

})();
