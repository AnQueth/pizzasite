$(document).ready(function () {
    var i = new Inventory();
    i.Show();
});
var Inventory = /** @class */ (function () {
    function Inventory() {
    }
    Inventory.prototype.Show = function () {
        $.ajax({
            url: "api/inventory"
        }).done(function (res) {
            $(res).each(function (i, r) {
                $("#inventory").append($("<div>" + r.name + "</div>"));
            });
        });
    };
    return Inventory;
}());
//# sourceMappingURL=InventoryList.js.map