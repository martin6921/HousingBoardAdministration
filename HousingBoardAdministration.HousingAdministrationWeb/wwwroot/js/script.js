"use strict"
dawaAutocomplete.dawaAutocomplete(document.getElementById("address"), {
    select: function (selected) {
        document.getElementById("chosenAddress").innerHTML = selected.tekst;
        document.getElementById("address").innerHTML = "";
    }
});