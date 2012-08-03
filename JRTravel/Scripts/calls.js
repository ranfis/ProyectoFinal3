﻿$(function () {
    $(".collapse").collapse()
    $('.carousel').carousel({
        interval: 3000
    })
    $('.modal').modal('hide')
    $('.msgm').modal('show')
    $('.btn').tooltip()
    $('td').tooltip()
    $("#dialog").dialog()

    $("#datepickerPartida").datepicker({
        minDate: +2,
        maxDate: "+1M +10D",
        showOtherMonths: true,
        selectOtherMonths: true,
        dateFormat: "mm/dd/yy"
    })
    $("#datepickerRetorno").datepicker({
        minDate: +3,
        maxDate: "+1M +10D",
        showOtherMonths: true,
        selectOtherMonths: true,
        dateFormat: "mm/dd/yy"
    })
    $.datepicker.regional['es'] = {
        closeText: 'Cerrar',
        prevText: '<Ant',
        nextText: 'Sig>',
        currentText: 'Hoy',
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
        dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
        weekHeader: 'Sm',
        dateFormat: 'dd/mm/yy',
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: false,
        yearSuffix: ''
    }
    $.datepicker.setDefaults($.datepicker.regional['es'])
});