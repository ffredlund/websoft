/**
 * @preserve Made by mos@dbwebb.se
 */
(function () {
    'use strict';

<<<<<<< HEAD
//    fetch('https://api.scb.se/UF0109/v2/skolenhetsregister/sv/kommun/1081')
    fetch('data/1081.json')
=======
    let url;

    //url = "https://api.scb.se/UF0109/v2/skolenhetsregister/sv/kommun/1081";
    url = "data/1081.json";
    fetch(url)
        .then((response) => {
            return response.json();
        })
        .then((myJson) => {
            console.log(myJson);
        });

    url = "https://rem.dbwebb.se/api/users";
    fetch(url)
>>>>>>> 72c2be7414dc34405e643b310142186af502189f
        .then((response) => {
            return response.json();
        })
        .then((myJson) => {
            console.log(myJson);
        });

    console.log('Sandbox is ready!');
})();
