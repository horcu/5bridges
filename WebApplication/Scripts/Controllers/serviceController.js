//this file will contain the jquery code that calls the api

(function() {
    "use strict";

    angular.module("app-fiveBridges")
        .controller("serviceController", ['$scope', '$http', function ($scope, $http) {
            $scope.county = {};
            $scope.results = [];

            function getCountyInformationByName () {
                /* the $http service allows you to make arbitrary ajax requests.
                 * in this case you might also consider using angular-resource and setting up a
                 * User $resource. */
                $http.get("/api/FiveBridges/GetCountyByName/?name=", { params: county },
                    function (response) { $scope.results = response; },
                    function (failure) { console.log("failed :(", failure); });
            }
        }]
    );

})();