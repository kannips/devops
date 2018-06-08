$(document).ready(function () {
    $("#SelectedItem").change(function (event) {
        var month = $('#SelectedItem :selected').text();
        var date = $("#SelectedItem").val();
        var valueArray = [];
        valueArray.push(month);
        valueArray.push(date);      
        $.ajax({
            url: "Home/Index",
            data: { values: valueArray },
            cache: false,
            type: "POST",
            dataType: "html",

            success: function (data, textStatus, XMLHttpRequest) {
               
                // $("#divPartialView").html( data );

                var select = $("#SelectedDate");
                select.empty();
               
            }
        });
    });
});
