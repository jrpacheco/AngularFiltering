app.controller('ngcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["CustomerName", "SalesAgentName"];
    $scope.SelectedCriteria = "";
    $scope.filterValue = "";

    loadOrders();

    function loadOrders() {
        var promise = ngservice.getOrders();
        promise.then(function (resp) {
            $scope.Orders = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (error) {
            $scope.Message = "Call failed " + error.status;
        });
    };

    $scope.getFilteredData = function () {
        var filter = $scope.filterValue.lenght == 0 ? "MS" : $scope.filterValue;
        var promise = ngservice.getFilteredData($scope.SelectedCriteria, filter);
        debugger;
        promise.then(function (resp) {
            $scope.Orders = resp.data;            
        }, function (error) {
            $scope.Message = "Call failed " + error.status;
        });
    }
});