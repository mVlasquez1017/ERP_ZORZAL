﻿$('#btnCreateNumeracionDetalle').click(function () {
    var DocumentoFiscal = $('#dfisc_Id').val();
    var RangoInicio = $('#txtRangoInicial').val();
    var RangoFinal = $('#txtRangoFinal').val();
    var FechaLimite = $('#txtFechalimite').val(); 

    //Split Rango Inicial
    var divisiones = RangoInicio.split("-", 4);
    var ultimo = divisiones[3]
    var rango = parseInt(ultimo)

    //Split Rango Final
    var divisiones1 = RangoFinal.split("-", 4);
    var ultimo1 = divisiones1[3]
    var rango1 = parseInt(ultimo1)

    //Longitud de la cadena
    var Length = 19;
    var RangoInicioLength = RangoInicio.length;
    var RangoFinalLength = RangoFinal.length;

    //ValidaciónFecha
    //var pemid_FechaLimiteEmision = $("#txtFechalimite").val();
    //var p = new Date(pemid_FechaLimiteEmision);
    //console.log(p);
    ////Current date
    //var GetCurrentDate = new Date();
    //console.log(GetCurrentDate);


    if (DocumentoFiscal == '')
    {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionDocumentoFiscalCreate').after('<p id="ErrorDocumentoFiscalCreate" style="color:red">Campo Documento Fiscal requerido</p>');
    }
    else if (RangoInicio == '') {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionRangoInicioCreate').after('<p id="ErrorRangoInicioCreate" style="color:red">Campo Rango Inicial requerido</p>');
    }
    else if (RangoInicioLength < Length) {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionRangoInicioCreate').after('<p id="ErrorRangoInicioLengthCreate" style="color:red">Campo Rango Inicio debe  tener 19 caracteres</p>');
    }
    else if (RangoFinal == '') {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionRangoFinalCreate').after('<p id="ErrorRangoFinalCreate" style="color:red">Campo Rango Final requerido</p>');
    }
    else if (rango1 <= rango) {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionRangoFinalCreate').after('<p id="ErrorRangoFinalSplitCreate" style="color:red">El Rango Final debe ser mayor al Rango Inicial</p>');
    }
    else if (RangoFinalLength < Length) {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionRangoFinalCreate').after('<p id="ErrorRangoFinalLengthCreate" style="color:red">El Rango Final debe tener el mismo formato de Rango Inicial</p>');
    }
    else if (FechaLimite == '') {
        $('#ErrorDocumentoFiscalCreate').text('');
        $('#ErrorRangoInicioCreate').text('');
        $('#ErrorRangoFinalCreate').text('');
        $('#ErrorRangoInicioLengthCreate').text('');
        $('#ErrorRangoFinalSplitCreate').text('');
        $('#ErrorRangoFinalLengthCreate').text('');
        $('#ErrorFechaLimiteCreate').text('');
        $('#validacionFechaLimiteCreate').after('<p id="ErrorFechaLimiteCreate" style="color:red">Campo Fecha Limite requerido</p>');
    }
       
    else {
        var PuntoEmisionDetalle = GetPuntoEmisionDetalle();
        $.ajax({
            url: "/PuntoEmision/SaveCreateNumeracion",
            method: "POST",
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ CreatePuntoEmisionDetalle: PuntoEmisionDetalle }),
        })
        .done(function (data) {
            if (data == 'El registro se guardo exitosamente') {
                location.reload();
            }
        });
    }
    

    function GetPuntoEmisionDetalle() {
        var PuntoEmisionDetalle = {
            pemi_Id: $('#txtpemi_Id').val(),
            dfisc_Id: $('#dfisc_Id').val(),
            pemid_RangoInicio: $('#txtRangoInicial').val(),
            pemid_RangoFinal: $('#txtRangoFinal').val(),
            pemid_FechaLimite: new Date($('#txtFechalimite').val())
        }
        return PuntoEmisionDetalle
    };
});



//Datepicker
$(function () {
    var StartDate = new Date();
    $("#txtFechalimite").datepicker({
        dateFormat: 'mm/dd/yy',
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
        minDate: StartDate,
        maxDate: '+3Y',
        prevText: 'Ant',
        nextText: 'Sig',
        changeMonth: true,
        changeYear: true,
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic']
    }).datepicker('setDate', new Date());

});


//Mostrar Mensaje:Campo requerido en tiempo real
$("#dfisc_Id").change(function () {
    var dfisc_Id = $("#dfisc_Id").val();
    if (dfisc_Id != '') {
        $('#ErrorDocumentoFiscalCreateEventoChange').text('');
    }
    else {
        $('#ErrorDocumentoFiscalCreateEventoChange').text('');
        $('#validacionDocumentoFiscalCreate').after('<p id="ErrorDocumentoFiscalCreateEventoChange" style="color:red">Campo Documento Fiscal requerido</p>');
    }
});

$("#txtRangoInicial").change(function () {
    var pemid_RangoInicio = $("#txtRangoInicial").val();
    if (pemid_RangoInicio != '') {
        $('#ErrorRangoInicioCreateEventoChange').text('');
    }
    else {
        $('#validacionRangoInicioCreate').after('<p id="ErrorRangoInicioCreateEventoChange" style="color:red">Campo Rango Inicio requerido</p>');
    }
});

$("#txtRangoFinal").change(function () {
    var pemid_RangoFinal = $("#txtRangoFinal").val();
    if (pemid_RangoFinal != '') {
        $('#ErrorRangoFinalCreateEventoChange').text('');
    }
    else {
        $('#validacionRangoFinalCreate').after('<p id="ErrorRangoFinalCreateEventoChange" style="color:red">Campo Rango Final requerido</p>');
    }

});

$(document).ready(function () {
    //Máximo de caracteres_Rangos
    $("#txtRangoInicial")[0].maxLength = 20;
    $("#txtRangoFinal")[0].maxLength = 20;

    var CurrentDate = new Date();

    $("#btnModalGuardarNumeracion").click(function () {
        $("#PuntoEmision tbody tr").each(function () {
            //Documento Fiscal
            var DocumentoFiscal = $(this).children("td:eq(1)").text();
            console.log("DocumentoFiscal: " , DocumentoFiscal);

            //FechaLimiteEmision
            var FechaLimiteEmision = $(this).children("td:eq(5)").text();
            var f = new Date(FechaLimiteEmision);
            console.log("FechaLimiteEmision: ", f);

            //if (f > CurrentDate) {
            //    console.log('FechaMayor');
            //}
            //else {
            //    console.log('FechaMenor');
            //}

         

            //if (DocumentoFiscal > 3) {
            //    console.log('Vigente');
            //}
            //else {
            //    console.log('No vigente');
            //}


        });
    });
});

