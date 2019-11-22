
function a() {
    var name = document.getElementById("name");
    var pass = document.getElementById("pass");

    console.log(name.value);
    console.log(pass.value);
    if (name.value == "123" && pass.value == "123") {
        var url = $("#RedirectTo").val();
        window.location.href = url;
    }
    else {
        alert("Ingrese los datos nuevamente");
    }
}