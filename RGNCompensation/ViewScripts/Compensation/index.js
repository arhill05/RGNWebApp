function CompensationLogViewModel(a) {
    var self = this;
    self.reimburse_id = ko.observable(a.reimburse_id);
    self.reimburse_amount = ko.observable(a.reimburse_amount);
    self.reimburse_player_id = ko.observable(a.reimburse_player_id);
    self.reimburse_justification = ko.observable(a.reimburse_justification);
    self.reimburse_admin = ko.observable(a.reimburse_admin);
}

(function () {
    var baseUri = "api/CompensationApi";
    var self = this;
    self.CompensationLogs = ko.observableArray();

    self.query = ko.observable("");
    var queryResults = ko.observableArray();
    self.filteredCompensation = ko.computed(function () {


        var filter = query().toLowerCase();
        if (!filter) {
            return self.CompensationLogs();
        } else {
            return ko.utils.arrayFilter(CompensationLogs(), function (data) {
                var test = [data.reimburse_id(), data.reimburse_amount(), data.reimburse_player_id(), data.reimburse_justification(), data.reimburse_admin()].toString();
                return isFound(test, filter)
            });
        }

    }).extend({ rateLimit: 800 });

    function isFound(data, filter) {
        return ((data !== null) && data.toString().toLowerCase().indexOf(filter) !== -1)
    }

    self.pageSize = ko.observable(10);
    self.currentPageIndex = ko.observable(0);
    self.contacts = ko.observableArray();
    self.currentPage = ko.computed(function () {
        var pagesize = parseInt(self.pageSize(), 10),
        startIndex = pagesize * self.currentPageIndex(),
        endIndex = startIndex + pagesize;
        return self.filteredCompensation().slice(startIndex, endIndex);
    });

    self.nextPage = function () {
        if (((self.currentPageIndex() + 1) * self.pageSize()) < self.CompensationLogs().length) {
            self.currentPageIndex(self.currentPageIndex() + 1);
        }
        else {
            self.currentPageIndex(0);
        }
    }
    self.previousPage = function () {
        if (self.currentPageIndex() > 0) {
            self.currentPageIndex(self.currentPageIndex() - 1);
        }
        else {
            self.currentPageIndex((Math.ceil(self.CompensationLogs().length / self.pageSize())) - 1);
        }
    }


    self.getData = function () {
        $.ajax({
            url: baseUri,
            cache: false,
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            data: {},
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    var item = new CompensationLogViewModel(data[i]);
                    self.CompensationLogs.push(item);
                }
            }
        })
    }

    self.getData();
    ko.applyBindings(self);
})()