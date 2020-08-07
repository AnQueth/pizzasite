// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$.ajax({
    url: "api/inventory"
}).done(function (res) {
    $(res).each(function (i, r) {
        $("#inventory").append($("<div>" + r.name + "</div>"));

    });
 
});