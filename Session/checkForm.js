document.addEventListener("DOMContentLoaded", function(){
    var Button = document.querySelector(".next");
    var Form = document.querySelector(".quiz");
    function check()
    {
        var radio = Form.querySelectorAll('input[type="radio"]');
        var Checked=false;
        for (var i=0;i<radio.length;i++)
            if(radios[i].checked)
                Checked=true;
        return Checked;

    }

    curButton.addEventListener("click",function(e){
        if(!check())
            e.preventDefault();
    });
});