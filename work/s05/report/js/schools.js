function runFetch () {
    'use strict';

//    fetch('https://api.scb.se/UF0109/v2/skolenhetsregister/sv/kommun/1081')
    fetch('data/1081.json')
        .then(response => response.text())
        .then(data => {

        var obj = JSON.parse(data);

        var data2 = obj.Skolenheter;

        var col = [];
        for (var i = 0; i < data2.length; i++) {
            for (var key in data2[i]) {
                if (col.indexOf(key) === -1) {
                    col.push(key);
                }
            }
        }

        // Dynamic table.
        var table = document.createElement("table");

        // create html table header row

        var tr = table.insertRow(-1);  //table row

        for (var i = 0; i < col.length; i++) {
            var th = document.createElement("th");      // TABLE HEADER.
            th.innerHTML = col[i];
            tr.appendChild(th);
        }

        for (var i = 0; i < data2.length; i++) {

            tr = table.insertRow(-1);

            for (var j = 0; j < col.length; j++) {
                var tabCell = tr.insertCell(-1);
                tabCell.innerHTML = data2[i][col[j]];
            }
        }
        // FINALLY ADD THE NEWLY CREATED TABLE WITH JSON DATA TO A CONTAINER.
        var divContainer = document.getElementById("placeholder");
        divContainer.innerHTML = "";
        divContainer.appendChild(table);

        })

        .then((myJson) => {
            console.log(myJson);
            console.log('JSON fetched');

    })
}
