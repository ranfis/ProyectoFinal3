function marcar(e) {
    document.getElementById(e).setAttribute('class', 'error');
    document.getElementById(e).setAttribute('onblur', 'this.setAttribute("class","error");');
    document.getElementById(e).setAttribute('onfocus', 'this.setAttribute("class","");');
}
function desmarcar(e) {
    document.getElementById(e).setAttribute('class', '');
}

function validarReservacion() {
    //alert(document.getElementById("txtPartida"));
    //desmarcar("txtPartida");
    /*
    desmarcar("txtDestino");
    desmarcar("datepickerOrigen");
    desmarcar("datepickerDestino");

    if (!(document.getElementById('txtOrigen').value.match(/^[a-z A-Z,]+$/))) {
    marcar('txtOrigen');
    }
    if (!(document.getElementById('txtDestino').value.match(/^[a-z A-Z]+$/))) {
    marcar('txtDestino');
    }*/
}