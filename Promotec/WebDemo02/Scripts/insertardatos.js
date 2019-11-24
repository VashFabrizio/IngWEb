

function a() {
    var nombre = document.getElementById("txtName");
    var lugar = document.getElementById("txtlugar");
    var fecha = document.getElementById("txtfecha");
    var hora = document.getElementById("txthora");
    var id = document.getElementById("form");

    document.getElementById("spinner").style.visibility = "visible";
    document.getElementById("btn").disabled = true;

    var modelEvento = {};
    modelEvento.nombre = $(nombre).val();
    modelEvento.lugar = $(lugar).val();
    modelEvento.fecha = $(fecha).val();
    modelEvento.hora = $(hora).val();

   
    $.ajax({
        type: "POST",
        data: JSON.stringify(modelEvento),
        url: "/Registrar/PostMethod",
        contentType: "application/json"
    }).done(function (res) {
        document.getElementById("btn").disabled = false;
        document.getElementById("spinner").style.visibility = "hidden";
        id.reset();
        alert(res);
    });
};