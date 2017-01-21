//Ann Arundel Controller
     (function() {

     "use strict";

     //get the existing module
     angular.module("app-fiveBridges")
         .controller("annArundelController", annArundelController);

         function annArundelController(){
             var vm = this;
             vm.name = "Ann Arundel";
             vm.location = "Ann Arundel County";
         }

     })();