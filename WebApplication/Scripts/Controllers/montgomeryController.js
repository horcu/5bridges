//montgomery Controller
(function() {

    "use strict";

//get the existing module
    angular.module("app-fiveBridges")
        .controller("montgomeryController", montgomeryController);

    function montgomeryController(){
        var vm = this;
        vm.name = "Montgomery";
        vm.location = "Montgomery County";
    }

})();