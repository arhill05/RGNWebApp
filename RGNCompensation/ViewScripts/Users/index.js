function UserViewModel(a) {
    var self = this;
    self.Id = ko.observable(a.Id);
    self.UserName = ko.observable(a.UserName);
}

(function () {
    var baseUri = "api/UsersApi";
    var self = this;
    self.Users = ko.observableArray();

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
                    var item = new UserViewModel(data[i]);
                    self.Users.push(item);
                }
            }
        })
    }

    self.getData();
    ko.applyBindings(self);
})()