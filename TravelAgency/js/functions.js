$('.dropdown-toggle').dropdown();
$('.dropdown-menu').find('form').click(function (e) {
    e.stopPropagation();
});

function marcar(e) {
    document.getElementById(e).setAttribute('class', 'error');
    document.getElementById(e).setAttribute('onblur', 'this.setAttribute("class","error");');
    document.getElementById(e).setAttribute('onfocus', 'this.setAttribute("class","");');
}
function desmarcar(e) {
    document.getElementById(e).setAttribute('class', '');
}

function validarReservacion() {
    desmarcar("txtPartida");
    desmarcar("txtDestino");
    txt=document.getElementsByTagName('input');

        if (!(document.getElementById('txtPartida').value.match(/^[a-z A-Z,]+$/))) {
            marcar('txtPartida');
        }
    if (!(document.getElementById('txtDestino').value.match(/^[a-z A-Z]+$/))) {
        marcar('txtDestino');
    }
}