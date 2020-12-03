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

function ordersPage(page) {
    $.ajax({
        type:"POST",
        url:"/User/MyOrdersPage",
        data: {
            "page":page
        },
        success: function(response) {
            document.getElementById("orders").innerHTML = response;
        },
        error: function(response) {}
    })
}

function updateTimer() {
    var timer = document.getElementsByClassName("timer");
    for (var i = 0; i < timer.length; i++) {    
        var array = timer[i].textContent.split(":");

        var hours = parseInt(array[0]);
        var minutes = parseInt(array[1]);
        var seconds = parseInt(array[2]);

        var time_in_seconds = hours * 3600 + minutes * 60 + seconds - 1;
        
        if(time_in_seconds <= 0) {
            time_in_seconds = 0;
        }

        seconds = time_in_seconds % 60;
        minutes = Math.floor(time_in_seconds / 60) % 60;
        hours = Math.floor(time_in_seconds / 3600);
        
        if(seconds < 10) {
            seconds = "0" + seconds
        }
    
        if(minutes < 10) {
            minutes = "0" + minutes
        }
    
        if(hours < 10) {
            hours = "0" + hours
        }

        timer[i].textContent = hours + ":" + minutes + ":" + seconds;
    }
}

setInterval(updateTimer, 1000)

function getTokens() {
    $.ajax({
        type:"POST",
        url:"/User/MyTokens",
        success: function(response) {
            $("#tokens").val(response);
        },
        error: function(response) {}
    })
}

var connection = new signalR.HubConnectionBuilder().withUrl("/update").build()

function handelError(error) {
    alert(error);
}

connection.start().then(
    function() {
        var auction_id = $("#auction_id").val();
        connection.invoke("AddGroup", auction_id)
                .catch(handleError)
    }
).catch(handleError)

connection.on(
    "Bid",
    function() {
        getTokens();
    }
);

connection.on(
    "PurchaseTokens",
    function() {
        getTokens();
    }
);