//Harford County Controller
(function() {

    "use strict";

//get the existing module
    angular.module("app-fiveBridges")
        .controller("harfordController", harfordController);

    function harfordController(){
        var vm = this;
        vm.name = "Harford";
        vm.location = "Harford County";
    }

})();