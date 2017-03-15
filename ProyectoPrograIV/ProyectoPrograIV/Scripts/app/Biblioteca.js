$(document).on("ready", function () {
    ObtenerTodosUsuarios();
    ObtenerTodosAutores();
})

//Obtener todos
function ObtenerTodosUsuarios() {
    var item = "";
    $('#tblLista tbody').html('');
    $.getJSON('/api/Usuarios', function (data) {
        $.each(data, function (key, value) {
            item += "<tr><td>" + value.UsuID + "</td><td>" + value.UsuNombre + "</td><td>" + value.UsuGenero + "</td><td>" + value.UsuCorreo + "</td><td>" + value.UsuTelefono + "</td><td>" + value.UsuRol + "</td></tr>";
        });
        $('#tblLista tbody').append(item);
    });
};

function ObtenerTodosAutores() {
    var item = "";
    $('#tblListaAutores tbody').html('');
    $.getJSON('/api/Autores', function (data) {
        $.each(data, function (key, value) {
            item += "<tr><td>" + value.AutID + "</td><td>" + value.AutNombre + "</td><td>" + value.AutGenero + "</td><td>" + value.AutDireccion + "</td><td>" + value.AutTelefono + "</td></tr>";
        });
        $('#tblListaAutores tbody').append(item);
    });
};
