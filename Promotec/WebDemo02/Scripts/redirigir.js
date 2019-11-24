
function a() {
    var name2 = document.getElementById("name");
    var pass2 = document.getElementById("pass");

    var modelUSer = {};
    modelUSer.dni = $(name2).val();
    modelUSer.contraseña = $(pass2).val();

    $.ajax({
        type: "POST",
        data: JSON.stringify(modelUSer),
        url: "/Login/Verify",
        contentType: "application/json"
    }).done(function (res) {
        
        if (res == "success") {
            var url = $("#RedirectTo").val();
            window.location.href = url;
        }
        else {
            alert("Ingrese los datos nuevamente");
        }
       
    });

}
