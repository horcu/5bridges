//Baltimre Bridge Controller
(function() {

    "use strict";

//get the existing module
    angular.module("app-fiveBridges")
        .controller("baltimoreController", baltimoreController);

    function baltimoreController(){
        var vm = this;
        vm.name = "Baltimore";
        vm.location = "Baltimore County";
    }

})();