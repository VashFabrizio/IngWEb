function registro() {
    var dni = document.getElementById("dni");
    var nombre = document.getElementById("nombre");
    var direccion = document.getElementById("direccion");
    var telefono = document.getElementById("telefono");
    var contraseña = document.getElementById("contraseña");
    var type = document.getElementById("type");
    var id = document.getElementById("id");
    document.getElementById("spinner").style.visibility = "visible";
    document.getElementById("btn").disabled = true;
    

    var modelEvento = {};
    modelEvento.dni = $(dni).val();
    modelEvento.nombre = $(nombre).val();
    modelEvento.direccion = $(direccion).val();
    modelEvento.telefono = $(telefono).val();
    modelEvento.contraseña = $(contraseña).val();
    modelEvento.user_type = $(type).val();


    $.ajax({
        type: "POST",
        data: JSON.stringify(modelEvento),
        url: "/Registro/UserRegister",
        contentType: "application/json"
    }).done(function (res) {
        alert(res);
        document.getElementById("btn").disabled = false;
        document.getElementById("spinner").style.visibility = "hidden";
        id.reset();
        });
    
};