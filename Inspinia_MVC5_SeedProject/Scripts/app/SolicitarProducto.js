﻿
function SolicitarProducto(bod_Id, bod_Nombre, suc_Descripcion, prod_Codigo, prod_Descripcion, prod_Marca, bodd_CantidadExistente, bodd_CantidadMinima) {
    $('#txt1').val(suc_Descripcion);
    $('#txt2').val(bod_Nombre);
    $('#txt3').val(prod_Descripcion);
    $('#txt4').val(prod_Marca);

    $('#btnGuardarSalida').click(function () {
        $("#ErrorValidacionGeneral").remove();
        $("#errorDescripcionRol").remove();
        
        var CantidadSolicitada = $('#txt5').val();
        var CantidadDisponible = bodd_CantidadExistente - CantidadSolicitada
        if (CantidadSolicitada == '') {
            $("#ErrorValidacionGeneral").remove();
            $('#validationCantidad').text('');
            $('#errorCantidad').text('');
            $('#validationCantidad').after('<ul id="ErrorValidacionGeneral" class="validation-summary-errors text-danger">Favor de Enviar una cantidad</ul>');
        }
        else if (CantidadDisponible <= bodd_CantidadMinima) {
            $('#validationCantidad').text('');
            $('#errorCantidad').text('');
            $('#validationCantidad').after('<ul id="ErrorValidacionGeneral" class="validation-summary-errors text-danger">No puede pedir esa Cantidad</ul>');
        }
        else {
            $.ajax({
                url: "/ConsultarExistenciaProductos/InsertPedido",
                method: "POST",
                dataType: 'json',
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ IDBodega: bod_Id, IDProducto: prod_Codigo, CantidadSolicitada: CantidadSolicitada }),
                success: function (json) {
                },
                error: function () {
                    //window.location.href = "Index/ConsultarExisteciaProductos";
                    $('#validationDescripcionRol').after('<ul id="ErrorValidacionGeneral" class="validation-summary-errors text-danger">No se pudo añadir la pantalla, contacte con el administrador</ul>');
                }
            })
            .done(function (data) {
                if (data == '') {
                    $('#PedidoExitoso').after('<ul id="errorDescripcionRol" class="validation-summary-errors text-danger">No se pudo eviar la solicitud de Producto</ul>')
                }
                else {

                }
            })
            $('#SolicitarProductomodal').modal('hide');
            var fecha = new Date();
            $('#PedidoExitoso').after('<ul id="errorDescripcionRol" class="validation-summary-errors text-danger">Solicitud de Pedido realiazada Satisfactoriamente ' + "Hora: " + fecha.getHours() + ",\nMinuto: " + fecha.getMinutes() + ",\nSegundos: " + fecha.getSeconds() + ",\nDía: " + fecha.getDate() + ",\nMes: " + (fecha.getMonth() + 1) + ",\nAño: " + fecha.getFullYear() + '</ul>')
            $('#txt5').val("");
        }
    })
    $('#btnCerrar').click(function () {
        $('#txt5').val("");
    })
    
}
