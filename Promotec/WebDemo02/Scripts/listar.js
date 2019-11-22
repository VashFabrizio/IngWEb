
$.get("Listar/listartodo", function (data, status) {

    var contenido = " ";
    contenido += "<table id='miTabla' class='table table-hover'>";
    contenido += "<thead>";
    contenido += "<tr>";
    contenido += "<td>nombre</td>";
    contenido += "<td>lugar</td>";
    contenido += "<td>hora</td>";
    contenido += "</tr>";
    contenido += "</thead>";
    contenido += "<tbody>";



    for (var i = 0; i < data.length; i++) {
        contenido += "<tr>";
        contenido += "<td>" + data[i].nombre + "</td>";
        contenido += "<td>" + data[i].lugar + "</td>";
        contenido += "<td>" + data[i].hora + "</td>";
        contenido += "</tr>";
    }

    contenido += "</tbody>";
    contenido += "</table >";

    document.getElementById("miTabla").innerHTML = contenido;

});