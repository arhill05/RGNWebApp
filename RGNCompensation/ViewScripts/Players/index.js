function PlayerViewModel(a) {
    var self = this;
    self.uid = ko.observable(a.uid || "");
    self.name = ko.observable(a.name || "");
    self.playerid = ko.observable(a.playerid || "");
    self.cash = ko.observable(a.cash || "");
    self.bankacc = ko.observable(a.bankacc || "");
    self.coplevel = ko.observable(a.coplevel);
    self.cop_licenses = ko.observable(a.cop_licenses || "");
    self.med_licenses = ko.observable(a.med_licenses || "");
    self.cop_gear = ko.observable(a.cop_gear || "");
    self.med_gear = ko.observable(a.med_gear || "");
    self.mediclevel = ko.observable(a.mediclevel || "");
    self.arrested = ko.observable(a.arrested || "");
    self.aliases = ko.observable(a.aliases || "");
    self.adminlevel = ko.observable(a.adminlevel || "");
    self.donatorlvl = ko.observable(a.donatorlvl || "");
    self.civ_gear = ko.observable(a.civ_gear || "");
    self.blacklist = ko.observable(a.blacklist || "");
    //self.last_connected = ko.observable(a.last_connected || "");
    self.editing = ko.observable(false);
    self.adding = ko.observable(false);
    self.showDelete = ko.observable(false);
    self.all = ko.observableArray();
}

(function () {
    var baseUri = "api/PlayersApi"
    var self = this;
    self.Player = ko.observable("");
    self.Players = ko.observableArray();
    self.query = ko.observable("");
   
  
    var queryResults = ko.observableArray();
    self.filteredPlayers = ko.computed(function () {


        var filter = query().toLowerCase();
        if (!filter) {
            return self.Players();
        } else {
            return ko.utils.arrayFilter(Players(), function (data) {
                var test = [data.uid(), data.name(), data.playerid(), data.cash(), data.bankacc()].toString(); //, data.last_connected()]
                return isFound(test, filter)
            });
        }

    }).extend({ rateLimit: 800 });

    self.newCompensationLog = function () {
        return {
            reimburse_id: ko.observable(""),
            reimburse_amount: ko.observable(""),
            reimburse_player_id: ko.observable(self.selectedPlayer().playerid()),
            reimburse_justification: ko.observable(""),
            reimburse_admin: ko.observable("")
        }
    }

    self.amountToCompensate = ko.observable("");
    self.selectedPlayer = ko.observable();
    self.compensationLog = ko.observable(self.newCompensationLog);
    self.setSelectedPlayer = function(player) {
        self.selectedPlayer(player);
        self.compensationLog(self.newCompensationLog());
    }

    function isFound(data, filter) {
        return ((data !== null) && data.toString().toLowerCase().indexOf(filter) !== -1)
    } 

    self.pageSize = ko.observable(10);
    self.currentPageIndex = ko.observable(0);
    self.contacts = ko.observableArray();
    self.currentPage = ko.computed(function ()
    {
        var pagesize = parseInt(self.pageSize(), 10),
        startIndex = pagesize * self.currentPageIndex(),
        endIndex = startIndex + pagesize;
        return self.filteredPlayers().slice(startIndex, endIndex);
    });

    self.nextPage = function ()
    {
        if (((self.currentPageIndex() + 1) * self.pageSize()) < self.Players().length)
        {
            self.currentPageIndex(self.currentPageIndex() + 1);
        }
        else
        {
            self.currentPageIndex(0);
        }
    }
    self.previousPage = function ()
    {
        if (self.currentPageIndex() > 0)
        {
            self.currentPageIndex(self.currentPageIndex() - 1);
        }
        else
        {
            self.currentPageIndex((Math.ceil(self.Players().length / self.pageSize())) - 1);
        }
    }


    self.addCompensation = function () {

       
        selectedPlayer().bankacc(selectedPlayer().bankacc() + + self.compensationLog().reimburse_amount());        
        
        
        var data = ko.toJS(compensationLog)
        var data2 = ko.toJS(selectedPlayer)
        $.ajax({
            type: "POST",
            url: baseUri,
            data: JSON.stringify({ Player: data2, CompensationLog: data }),
            contentType: 'application/json; charset=utf-8'
        }).done(toastr.options.positionClass = 'toast-bottom-full-width', toastr.success("Player compensated!"))
    }

    self.updatePlayerLevels = function () {
       
       
        var data = ko.toJS(selectedPlayer)
        $.ajax({
            type: "PUT",
            url: baseUri,
            data: JSON.stringify(data),
            contentType: 'application/json; charset=utf-8'
        }).done(toastr.options.positionClass = 'toast-bottom-full-width', toastr.success("Player levels updated!"))
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
                    var item = new PlayerViewModel(data[i]);
                    self.Players.push(item);
                }
            },
            complete:  function(){
            $('#floatingCirclesG').hide();
        }
        });
    }
    
    self.getData();
    ko.applyBindings(self);
})();
