

function a() {
    var nombre = document.getElementById("txtName");
    var lugar = document.getElementById("txtlugar");
    var fecha = document.getElementById("txtfecha");
    var hora = document.getElementById("txthora");


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
        alert(res);
    });
};