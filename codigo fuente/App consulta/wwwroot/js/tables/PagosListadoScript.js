//*********************************** VARIABLES ******************************************
var root;
var dataGrid;
var source = "";

//*********************************** funcLE ******************************************

var funcLE = {


    instanceDataGrid: function () {
        dataGrid = $("#gridContainer").dxDataGrid({
            dataSource: source,
            selection: {
                mode: "none",
                showCheckBoxesMode: "always",
                selectAllMode: "allPages"
            },
            noDataText: "No hay datos disponibles.",
            export: {
                enabled: false,
                fileName: "Listado_personas_" + moment().format("DD-MM-YYYY_hh-mm-ss"),
                allowExportSelectedData: true
            },

            stateStoring: {
                enabled: false,
                type: "localStorage",
                storageKey: "storage"
            },
            loadPanel: {
                enabled: true
            },

            paging: {
                pageSize: 50
            },

            scrolling: {
                mode: "virtual"
            },
            height: '42vh',
            width: '100%',
            columnFixing: {
                enabled: false
            },
            
            wordWrapEnabled: true,
            columnHidingEnabled: true,
            rowAlternationEnabled: true,
            showRowLines: true,
            grouping: {
                contextMenuEnabled: true,
                expandMode: "rowClick"
            },
            groupPanel: {
                emptyPanelText: "haga click derecho en una columna para agruparla",
                visible: true
            },
            pager: {
                showPageSizeSelector: true,
                allowedPageSizes: [10, 20, 50, 100, 1000]
            },
            columnChooser: {
                enabled: true
            },
            allowColumnReordering: false,
            allowColumnResizing: true,
            columnAutoWidth: false,
            showBorders: true,
            filterRow: {
                visible: true,
                applyFilter: "auto"
            },
            searchPanel: {
                visible: true,
                width: 160,
                placeholder: "Buscar..."
            },
            headerFilter: {
                visible: true
            },
            columns: [

               
                {
                    dataField: "id",
                    caption: "Id Pago",
                    alignment: "left",
                    width: '100',
                    hidingPriority: 11,
                },
                {
                    dataField: "mes",
                    caption: "Mes",
                    alignment: "left",
                    width: '100',
                    hidingPriority: 9,
                },
               
                {
                    hidingPriority: 8,
                    dataField: "fecha",
                    caption: "Fecha",
                    alignment: "right",
                    dataType: "date",
                    width: '150',
                    calculateFilterExpression: function (value, selectedFilterOperations, target) {
                        if (target === "headerFilter" && value === "weekends") {
                            return [[getOrderDay, "=", 0], "or", [getOrderDay, "=", 6]];
                        }
                        return this.defaultCalculateFilterExpression.apply(this, arguments);
                    }
                },
               
                {
                    hidingPriority: 7,
                    dataField: "valor",
                    caption: "Valor",
                    width: '150',
                    alignment: "right",
                    format: "currency",
                    editorOptions: {
                        format: "currency",
                        showClearButton: true

                    },
                    headerFilter: {
                        dataSource: [{
                            text: "$0",
                            value: ["Anticipos", "<", 1]
                        }, {
                            text: "$1 - $50.000",
                            value: [["Anticipos", ">=", 1], ["Anticipos", "<", 50000]]
                        }, {

                            text: "$50.000 - $100.000",
                            value: [["Anticipos", ">=", 50000], ["Anticipos", "<", 100000]]
                        }, {

                            text: "$100.000 - $1.000.000",
                            value: [["Anticipos", ">=", 100000], ["Anticipos", "<", 1000000]]
                        }, {
                            text: "Mas de  $1.000.000",
                            value: ["Anticipos", ">=", 1000000]
                        }]
                    }
                },
                {
                    dataField: "estado",
                    caption: "estado",
                    alignment: "left",
                    width: '150',
                    hidingPriority: 6


                },
                {
                    dataField: "nombreusuario",
                    caption: "Pagador",
                    alignment: "left",
                    width: '240',
                    hidingPriority: 5


                },

               

                {
                    dataField: "Opciones",
                    hidingPriority: 10,
                    caption: "Opciones",
                    alignment: "center",
                    allowHeaderFiltering: false,
                    width: '100',
                    cellTemplate: function (container, options) {

                        var idPago = options.data.id;
                        var nombre = options.data.nombre;
                        var contenido = '<a target="_blank" href="/Persona/DetallesPago/' + idPago + '" title="Detalles del pago ' + idPago + '" class="btn btn-listado btn-outline-info btn-xs ml-1" ><i class="fas fa-file-alt"></i></a>'
                        

                        $("<div class='preventSelection'>")
                            .append(contenido)
                            .appendTo(container);
                    }

                }
            ],
            summary: {
                totalItems: [{
                    column: "mes",
                    summaryType: "count",
                    showInColumn: "mes",
                    displayFormat: "Total: {0}",
                },
                {
                    column: "valor",
                    valueFormat: "$ #,##0.##",
                    summaryType: "sum",
                    showInColumn: "valor",
                    displayFormat: "Pagado: {0}",
                }],

            },

            onToolbarPreparing: function (e) {
                var dataGrid = e.component;
                e.toolbarOptions.items.unshift({
                    location: "after",
                    widget: "dxButton",
                    options: {
                        icon: "refresh",
                        onClick: function () {
                            dataGrid.refresh();
                        }
                    }
                });
            }
        }).dxDataGrid('instance');
    },

    init: function () {
        // Carga las variables de configuración.
        idpersona = $('#idpersona').val();
        root = $('#Root').val();
        source = "../ListadoPagosAjax?Id=" + idpersona;


        funcLE.instanceDataGrid();
    }
};

var registrarPago = {
    registrar : function () {

        $('body').on('submit', '#formpago', function (e) {

            e.preventDefault();
            var formulario = $(this);
            // Serialize your form
            var ruta = formulario.attr('action');
           

            
            $.post(ruta, formulario.serialize())
                .done(function (data) {

                    if (data == "true") {
                        $('#modalPago').modal('hide')
                        $("#gridContainer").dxDataGrid("instance").refresh();
                        DevExpress.ui.notify("Pago registrado correctamente", "success", 600);
                        $('.btn-upload').removeClass("btn-success");
                        $('.btn-upload').addClass("btn-primary");
                        $('#inputadjunto_upload_comprobante').val("");
                        $('#inputadjunto_upload_cedula').val("");
                        $('#infoAdjuntoEjec_upload_cedula').empty();
                        $('#infoAdjuntoEjec_upload_cedula').removeAttr("href", "");
                        $('#infoAdjuntoEjec_upload_comprobante').empty();
                        $('#infoAdjuntoEjec_upload_comprobante').removeAttr("href", "");




                    } else if (data == "false") {
                        DevExpress.ui.notify("Imposible registrar el pago, verifique la información e intente nuevamente", "error", 600);
                    } else {
                        DevExpress.ui.notify(data, "warning", 600);
                    }
                });
            });


        },
    button_registrar: function () {
        $('body').on('click', '.btn-registrarPago', function (e) {

            $('#formpago').submit();

        });

    },

    init: function () {
        // Carga las variables de configuración.
        idpersona = $('#idpersona').val();
        root = $('#Root').val();
        source = "../ListadoPagosAjax?Id=" + idpersona;


        registrarPago.registrar();
        registrarPago.button_registrar();
    }
};


//************************************** ON READY **********************************************
$(function () {

    DevExpress.localization.locale("es-US");
    funcLE.init();

    registrarPago.init();
});