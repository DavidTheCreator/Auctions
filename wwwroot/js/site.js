// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function filter(page) {
    var auction_name = document.getElementById("auction_name").value;
    var from_price = document.getElementById("from_price").value;
    var to_price = document.getElementById("to_price").value;
    var state = document.getElementById("state").value;

    $.ajax({
            type:"POST",
            url:"/Home/Filter",
            data: {
                "auction_name":auction_name, 
                "from_price":from_price, 
                "to_price":to_price, 
                "state":state, 
                "page":page
            },
            success: function(response) {
                document.getElementById("auctions").innerHTML = response;
            },
            error: function(response) {}
        })
}
