
$(document).ready(() => {
    var i = new Inventory();
    i.Show();
});


class Inventory {
    public Show() {
        $.ajax({
            url: "api/inventory"
        }).done((res) => {
            $(res).each((i, r) => {
                $("#inventory").append($("<div>" + r.name + "</div>"));
            });
        });
    }
}