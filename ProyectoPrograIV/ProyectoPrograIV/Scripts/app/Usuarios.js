$(document).on("ready", function () {
    ObtenerTodos();
})

//Obtener todas los estudiantes
function ObtenerTodos() {
    var item = "";
    $('#tblLista tbody').html('');
    $.getJSON('/api/Usuarios', function (data) {
        $.each(data, function (key, value) {
            item += "<tr><td>" + value.UsuID + "</td><td>" + value.UsuNombre + "</td><td>" + value.UsuGenero + "</td><td>" + value.UsuCorreo + "</td><td>" + value.UsuTelefono + "</td><td>" + value.UsuRol + "</td></tr>";
        });
        $('#tblLista tbody').append(item);
    });
};
