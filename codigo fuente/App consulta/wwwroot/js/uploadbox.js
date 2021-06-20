//----------------------------- AJAXA POST PARA CARGAR ARCHIVOS -----------------------------
var root;

var funcAdjunto = {
    loadCreateAdjunto: function () {
        $('body').on('submit', '.formAdjunto', function (e) {
            e.preventDefault();
            var formulario = $(this).closest('form');
            var idUpload = formulario.attr("data_id");
            var id2 = formulario.attr("data_id2");
            var name = formulario.attr("data_nombre");
            // Serialize your form
            var formData = new FormData(formulario[0]);
            var time = funcAdjunto.getFormatDate();
            formData.append("time", time);


            $('#infoAdjuntoEjec_' + idUpload).empty();
            $('#uploadingAdjuntoEjec_' + idUpload).html('Cargando <img src="' + root + 'images/ajax-loader.gif">');
            $('#btnAdjuntoEjec_' + idUpload).attr('disabled', 'disabled');

            $.ajax({
                type: "POST",
                url: formulario.attr('action'),
                data: formData,
                dataType: 'json',
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response == '') {
                        $('#nameAdjuntoEjec_' + idUpload).val('');
                        $('#fileAdjuntoEjec_' + idUpload).val('');
                        $('#fileAdjuntoEjec_' + idUpload).next('.custom-file-label').html('Seleccionar Archivo');

                        funcAdjunto.updateAdjuntos(id);
                    }
                    else {
                        $('#infoAdjuntoEjec_' + idUpload).html(response.nombre);
                        $('#infoAdjuntoEjec_' + idUpload).attr("href", "../UploadedFiles/" + response.nombre)
                        $('#inputadjunto_' + idUpload).val(response.nombre);
                        $('#btnAdjuntoEjec_' + idUpload).html("Remplazar "+name);
                        $('#btnAdjuntoEjec_' + idUpload).removeClass("btn-primary");
                        $('#btnAdjuntoEjec_' + idUpload).addClass("btn-success");

                        $('#infoAdjuntoEjec_' + idUpload).attr("href", "../../Adjuntos/"+id2+"/" + response.nombre)
                     
                        
                    }
                    $('#uploadingAdjuntoEjec_' + idUpload).empty();
                    $('#btnAdjuntoEjec_' + idUpload).removeAttr('disabled');
                },
                error: function (error) {
                    $('#uploadingAdjuntoEjec_' + idUpload).empty();
                    $('#btnAdjuntoEjec_' + idUpload).removeAttr('disabled');
                    $('#infoAdjuntoEjec_' + idUpload).html("Error al cargar el archivo.");
                    $('#infoAdjuntoEjec_' + idUpload).attr("href", "/")
                }
            });

        });
    },
    getFormatDate: function () {
        var dt = new Date();
        var day = dt.getDate();
        var month = dt.getMonth() + 1;
        var hour = dt.getHours();
        var minute = dt.getMinutes();
        var seconds = dt.getSeconds();
        if (day < 10) { day = "0" + day; }
        if (month < 10) { month = "0" + month; }
        if (hour < 10) { hour = "0" + hour; }
        if (minute < 10) { minute = "0" + minute; }
        if (seconds < 10) { seconds = "0" + seconds; }
        return dt.getFullYear() + "_" + month + "_" + day + "-" + hour + "_" + minute + "_" + seconds;
    },
    loadDeleteAdjunto: function () {
        $('body').on('click', '.confirDeleteAdj', function (e) {
            $('#ModalConfirm').modal('hide');
            var idAdjunto = $(this).data('idejec');
            var idEjec = $("#idejecucion").val();
            var fullurl = root + "EjecucionAdjunto/Delete/";
            $.post(fullurl, { id: idAdjunto },
                function (response) {
                    if (response == '') {
                        funcAdjunto.updateAdjuntos(idEjec);
                    }
                    else {
                        $('#infoAdjuntoEjec').html(response);
                    }

                }).fail(function () {
                    $('#infoAdjuntoEjec').html("No fue posible borrar el adjunto.");
                });
        });

    },
    updateAdjuntos: function (id) {
        $('#ejecAdjunto').html('<div class="loading"><img src="' + root + 'images/loadingcircle.gif" ></div>');
        var fullurl = root + "Ejecucions/EditPopAdjuntos/"
        $.get(fullurl, { 'idEjecucion': id })
            .done(function (data) {
                $('#ejecAdjunto').html(data);
            }).fail(function () {
                $('#ejecAdjunto').html("No fue posible recuperar los adjuntos de la ejecución.");
            });;
    },
    //Load functions
    loadConfirmDeleteAdjunto: function () {
        $('body').on('click', '.delete-adjunto', function (e) {
            var id = $(this).data('id');
            $('#ModalConfirText').html('¿Está seguro de que desea borrar este archivo adjunto?');

            $('#ModalConfirmButton').data('idejec', id)
                .addClass('confirDeleteAdj');

            $('#ModalConfirm').modal('show');
        });
    },
    buttonCargarclick: function () {
        $('body').on('click', '.btn-upload', function (e) {

            var idUpload = $(this).attr("data_id");
            button = $('#fileAdjuntoEjec_' + idUpload);

            button.click();

        })
    },

    filechanged: function () {
        $('body').on('change', '.fileUploadAdjuntoEjec', function (e) {

            var formulario = $(this).closest('form');

            formulario.submit();

        })
    },
    init: function () {
        console.log("Adjunto Script load");
        root = $('#Root').val();
        funcAdjunto.loadCreateAdjunto();
        funcAdjunto.loadConfirmDeleteAdjunto();
        funcAdjunto.loadDeleteAdjunto();
        funcAdjunto.buttonCargarclick();
        funcAdjunto.filechanged();
    }
};


//************************************** ON READY **********************************************
$(function () {
    funcAdjunto.init();

    $('.modal').on("hidden.bs.modal", function (e) {
        if ($('.modal:visible').length) {
            $('body').addClass('modal-open');
        }
    });
});

