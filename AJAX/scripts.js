
$(document).ready(function () {
  
    $("#height-value").text($("#height").val());


    $("#height").on("input", function () {
        $("#height-value").text($(this).val());
    });

    $("#ideal-weight-form").on("submit", function (event) {
        event.preventDefault();

        const sex = $('input[name="sex"]:checked').val();
        const height = $("#height").val();

        $.ajax({
            url: "a3.php",
            type: "POST",
            data: 
	    {
               sex: sex,
               height: height
            },
         
            success: function (response) {
                $("#result").html(response);
            },
   
            error: function () {
                $("#result").html("Ошибка при отправке запроса");
            }
        });
    });
});