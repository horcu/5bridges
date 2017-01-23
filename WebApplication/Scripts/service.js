//this file will contain the jquery code that calls the api

(function() {
    "use strict";

function getCountyInformationByName(name) {

    $.ajax({
        type: "POST",
        dataType: "json",
        url: "api/FiveBridges/GetCountyByName?name=" + json.stringify(name),
        data: source,
        success: function (data) {
            //ideally pass data back to ui
            alert(data);
        },
        error: function (error) {

           var jsonValue = jQuery.parseJSON(error.responseText);
            alert("error" + error.responseText);
        }
    });
}

})();