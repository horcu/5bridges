//Caroll Controller
(function() {

    "use strict";

//get the existing module
    angular.module("app-fiveBridges")
        .controller("carollController", carollController);

    function carollController(){
        var vm = this;
        vm.name = "Caroll";
        vm.location = "Caroll County";
    }

})();