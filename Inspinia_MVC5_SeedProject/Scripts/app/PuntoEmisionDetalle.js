﻿var contador = 0;
$('#AgregarPuntoEmisionDetalle').click(function () {

    var DocumentoFiscal = $('#dfisc_Id').val();
    var RangoInicio = $('#pemid_RangoInicio').val();
    var RangoFinal = $('#pemid_RangoFinal').val();
    var FechaLimite = $('#pemid_FechaLimite').val();

    var RangoInicioLength = $('#pemid_RangoInicio').val().length;
    var RangoFinalLength = $('#pemid_RangoFinal').val().length;

    //RangoInicial
    var divisiones = RangoInicio.split("-", 4);
    var ultimo = divisiones[3]
    var rango = parseInt(ultimo)

    //RangoFinal
    var divisiones1 = RangoFinal.split("-", 4);
    var ultimo1 = divisiones1[3]
    var rango1 = parseInt(ultimo1)

    
    if (DocumentoFiscal == '') {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#ErrorEstructuraRangoCreate').text('');
        $('#validacionDocumentoFiscalCreate').after('<ul id="ErrorDocumentoFiscalCreate" class="validation-summary-errors text-danger">Campo Documento Fiscal requerido</ul>');

    }
    else if (RangoInicio == '')
    {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#ErrorEstructuraRangoCreate').text('');
        $('#validacionRangoInicioCreate').after('<ul id="ErrorRangoInicioCreate" class="validation-summary-errors text-danger">Campo Rango Inicio requerido</ul>');
    }
    else if (RangoFinal == '')
    {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#ErrorEstructuraRangoCreate').text('');
        $('#validacionRangoFinalCreate').after('<ul id="ErrorRangoFinalCreate" class="validation-summary-errors text-danger">Campo Rango Final requerido</ul>');
    }
    else if (rango1 < rango) {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#ErrorEstructuraRangoCreate').text('');
        $('#validacionRangoFinalCreate').after('<ul id="ErrorRangoFinalCreate" class="validation-summary-errors text-danger">El Rango Final no puede ser menor al Rango Inicial</ul>');
    }
    else if (RangoFinalLength < RangoInicioLength) {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#ErrorEstructuraRangoCreate').text('');
        $('#validacionRangoFinalCreate').after('<ul id="ErrorEstructuraRangoCreate" class="validation-summary-errors text-danger">El formato de rangos debe ser el mismo</ul>');
    }
    else if (FechaLimite == '') {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#ErrorEstructuraRangoCreate').text('');
        $('#validacionFechaLimiteCreate').after('<ul id="ErrorFechaLimiteCreate" class="validation-summary-errors text-danger">Campo Fecha Limite requerido</ul>');
    }
    else {
        contador = contador + 1;
        copiar = "<tr data-id=" + contador + ">";
        copiar += "<td>" + $('#dfisc_Id option:selected').text() + "</td>";
        copiar += "<td hidden id='dfisc_IdCreate'>" + $('#dfisc_Id option:selected').val() + "</td>";
        copiar += "<td id = 'pemid_RangoInicioCreate'>" + $('#pemid_RangoInicio').val() + "</td>";
        copiar += "<td id = 'pemid_RangoFinalCreate'>" + $('#pemid_RangoFinal').val() + "</td>";
        copiar += "<td id = 'pemid_FechaLimiteCreate'>" + $('#pemid_FechaLimite').val() + "</td>";
        copiar += "<td>" + '<button id="removePuntoEmisionDetalle" class="btn btn-danger btn-xs eliminar" type="button">-</button>' + "</td>";
        copiar += "</tr>";
        $('#tblPuntoEmisionDetalle').append(copiar);

        var PuntoEmisionDetalle = GetPuntoEmisionDetalle();
        $.ajax({
            url: "/PuntoEmision/SavePuntoEmisionDetalle",
            method: "POST",
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ PuntoEmisionDet: PuntoEmisionDetalle }),
        })
        .done(function (data) {
            //Mensajes
            $('#ErrorEstructuraRangoCreate').text('');
            $('#ErrorDocumentoFiscalCreate').text('');
            $('#ErrorRangoInicioCreate').text('');
            $('#ErrorRangoFinalCreate').text('');
            $('#ErrorFechaLimiteCreate').text('');
            //Input
            $('#dfisc_Id').val('');
            $('#pemid_RangoInicio').val('');
            $('#pemid_RangoFinal').val('');
            $('#pemid_FechaLimite').val('');

        });
    }
    
});

function GetPuntoEmisionDetalle() {    

    var PuntoEmisionDetalle = {        
        dfisc_Id: $('#dfisc_Id').val(),
        pemid_RangoInicio: $('#pemid_RangoInicio').val(),
        pemid_RangoFinal: $('#pemid_RangoFinal').val(),
        pemid_FechaLimite: new Date($('#pemid_FechaLimite').val()),
        pemid_Id: contador
    }
    return PuntoEmisionDetalle
};

$(document).on("click", "#tblPuntoEmisionDetalle tbody tr td button#removePuntoEmisionDetalle", function () {
    $(this).closest('tr').remove();
    idItem = $(this).closest('tr').data('id');
    var PuntoEmisionDetalle = {
        pemid_Id: idItem,
    };
    $.ajax({
        url: "/PuntoEmision/RemovePuntoEmisionDetalle",
        method: "POST",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ PuntoEmisionDet: PuntoEmisionDetalle }),
    });
});

$(document).ready(function () {
    $("#pemid_RangoInicio")[0].maxLength = 20;
    $("#pemid_RangoFinal")[0].maxLength = 20;
})