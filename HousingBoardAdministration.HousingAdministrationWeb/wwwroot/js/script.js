"use strict"
dawaAutocomplete.dawaAutocomplete(document.getElementById("address"), {
    select: function (selected) {
        document.getElementById("chosenAddress").value = document.getElementById("address").value;
        document.getElementById("address").value = "";
    }
});