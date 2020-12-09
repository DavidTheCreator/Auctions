// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var connection = new signalR.HubConnectionBuilder().withUrl("/update").build();

function handleError(error) {
    alert(error);
}

function handleSuccess(success) {
    alert(success);
}

connection.start().then(
    function() {
        var auction_id = $("#auction_id").val();
        if(auction_id != null) {
            connection.invoke("AddToGroup", auction_id)
        }
    }
).catch(handleError)


connection.on(
    "UpdateIndex",
    function() {
        filter();
        getTokens();
    }
)

connection.on(
    "UpdateAuctionDetails",
    function(id) {
        getAuctionDetails(+id);
        getTokens();
    }
)

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

        if (time_in_seconds <= 0) {
            connection.invoke("BidInIndex").catch(handleError);
        }
    }
}

setInterval(updateTimer, 1000)

function filter(page) {
    $.ajax({
            type:"POST",
            url:"/Home/Filter",
            data: {
                "auction_name":$("#auction_name").val(), 
                "from_price":$("#from_price").val(), 
                "to_price":$("to_price").val(), 
                "state":$("#state").val(), 
                "page":page
            },
            success: function(response) {
                $("#auctions").html(response);
            }
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
            $("#orders").html(response);
        }
    })
}

function getAuctionDetails(auction_id) {
    $.ajax({
        type:"GET",
        url:"/User/GetAuctionDetails",
        data: {
            "id": auction_id
        },
        success: function(response) {
            $("#auction").html(response);
        }
    })
}

function getTokens() {
    $.ajax({
        type:"GET",
        url:"/User/MyTokens",
        success: function(response) {
            $("#user_tokens").html(response + " Tokens");
        }
    })
}

function bid(auction_id) {
        $.ajax({
            type:"GET",
            url:"/User/Bid",
            data: {
                "id": auction_id
            },
            success: function(response) {
                connection.invoke("BidInIndex").catch(handleError);
                connection.invoke("BidInAuctionDetails", auction_id+"").catch(handleError);
                getTokens(); 
                handleSuccess(response);
            }, error: function(response) {
                handleError(response.responseText);
            }
        }
    )
}