//Prince George's Controller
(function() {

    "use strict";

//get the existing module
    angular.module("app-fiveBridges")
        .controller("princeGeorgeController", princeGeorgeController);

    function princeGeorgeController(){
        var vm = this;
        vm.name = "Prince George";
        vm.location = "Prince George County";
    }

})();