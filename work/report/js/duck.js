"use strict";


(function () {

  var element = document.getElementById("duck");

    element.addEventListener("click", function() {
      console.log("clicked");
    });

    element.addEventListener("mouseover", function(){
      element.style.left = element.offsetLeft + 20 + "px";
    console.log("mouseover");
  });

})();
