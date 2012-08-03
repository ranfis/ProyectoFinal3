function marcar(e) {
    document.getElementById(e).setAttribute('class', 'error');
}
function desmarcar(e) {
    document.getElementById(e).setAttribute('class', '');
}

function validarLogin() {
    desmarcar("txtUser");
    desmarcar("txtPass");
    resultado = true;
    if (!(document.getElementById('txtUser').value.match(/^[A-Za-z0-9._-]+$/))) {
        marcar('txtUser');
        resultado = false;
    }
    if (!(document.getElementById('txtPass').value.match(/^[A-Za-z0-9._-]+$/))) {
        marcar('txtPass');
        resultado = false;
    }
    return resultado
}

function validarRegistro() {
    desmarcar("txtCorreo");
    desmarcar("txtNombreUsuario");
    desmarcar("txtClave");
    desmarcar("txtNombres");
    desmarcar("txtApellidos");

    resultado = true;
    if (!(document.getElementById('txtCorreo').value.match(/^[A-Za-z0-9._-]+@[A-Za-z]+\.com$/))) {
        marcar('txtCorreo');
        resultado = false;
    }
    if (!(document.getElementById('txtNombreUsuario').value.match(/^[A-Za-z0-9._-]+$/))) {
        marcar('txtNombreUsuario');
        resultado = false;
    }
    if (!(document.getElementById('txtClave').value.match(/^[A-Za-z0-9._-]+$/))) {
        marcar('txtClave');
        resultado = false;
    }
    if (!(document.getElementById('txtNombres').value.trim().match(/^[a-z A-Z]+$/))) {
        marcar('txtNombres');
        resultado = false;
    }
    if (!(document.getElementById('txtApellidos').value.trim().match(/^[a-z A-Z]+$/))) {
        marcar('txtApellidos');
        resultado = false;
    }
    return resultado
}

function validarReservacion() {
    desmarcar("txtPartida");
    desmarcar("txtDestino");
    desmarcar("datepickerPartida");
    desmarcar("datepickerRetorno");
    
    resultado = true;
    if (!(document.getElementById('txtPartida').value.match(/^[A-Za-z() áéíóú,]+$/))) {
        marcar('txtPartida');
        resultado = false;
    }
    
    if (!(document.getElementById('txtDestino').value.match(/^[A-Za-z() áéíóú,]+$/))) {
        marcar('txtDestino');
        resultado = false;
    }
    
    if (!(document.getElementById('datepickerPartida').value.match(/^[0-9]{2}[/][[0-9]{2}[/][0-9]{4}$/))) {
        marcar('datepickerPartida');
        resultado = false;
    }
    
    if (!(document.getElementById('datepickerRetorno').value.match(/^[0-9]{2}[/][[0-9]{2}[/][0-9]{4}$/))) {
        marcar('datepickerRetorno');
        resultado = false;
    }
    
    return resultado
}