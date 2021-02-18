// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




$(document).ready(function () {

    function GetInfo() {

        var first = $("#first").val();
        var second = $("#second").val();

        //load the items on a second call
        $.ajax({
            url: '/Home/GetInfo',
            type: "POST",
            dataType: "json",
            data: { 
                Feet: "Stnky",
                Arms: "Long",
                Toes: "Many",
                Age: 15,
                Name: "Bob",
                CanDrive: false,
                CanVote: false,
                YearsTillDrive: 0,
                YearsTillVote: 0         
            },
            success: ShowResult,
            error: function () {
                alert('An Error occurred and the Admin was notified.');
            }
        }).done(function (data) {
            //something
        }).fail();
    

    }//GetInfo

    function ShowResult(data) {

        alert(data.name);

    }

    

    $(document).on("click", "#TestBtn", function () {
        GetInfo();

    });//btnSave
 

   
});


