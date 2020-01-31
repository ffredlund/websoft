"use strict";

(function () {

var france = document.getElementById("france");
var italy = document.getElementById("italy");
var ukrain = document.getElementById("ukrain");
var Frankrike = document.getElementById('Frankrike');
var Italien = document.getElementById('Italien');
var Ukraina = document.getElementById('Ukraina');
france.style.display = 'none';
italy.style.display = 'none';
ukrain.style.display = 'none';

Frankrike.addEventListener("click", function() {
  if (france.style.display == 'none') {
    italy.style.display = 'none';
    ukrain.style.display = 'none';
    france.style.display = 'block';
  } else {
    france.style.display = 'none';
  }
});

Italien.addEventListener("click", function() {
  if (italy.style.display == 'none') {
    france.style.display = 'none';
    ukrain.style.display = 'none';
    italy.style.display = 'block';
  } else {
    italy.style.display = 'none';
  }
});

Ukraina.addEventListener("click", function() {
  if (ukrain.style.display == 'none') {
    france.style.display = 'none';
    italy.style.display = 'none';
    ukrain.style.display = 'block';
  } else {
    ukrain.style.display = 'none';
  }
});


})();
