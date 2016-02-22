app.service('ngservice', function ($http) {    
    this.getOrders = function () {        
        var result = $http.get("/OrdersManager");
        return result;
    };

    this.getFilteredData = function (filter, value) {        
        var result;
        if (value.length == 0) {
            result = $http.get("/OrdersManager");
            return result;
        } else {
            result = $http.get("/OrdersManager/" + filter + "/" + value);
            return result;
        }
    };
});