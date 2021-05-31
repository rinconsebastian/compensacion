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
            height: '72vh',
            width: '100%',
            columnFixing: {
                enabled: false
            },
            
            wordWrapEnabled: false,
            columnHidingEnabled: false,
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
                    caption: "Cédula",
                    alignment: "left",
                    width: '110',
                    hidingPriority: 9
                },
                {
                    dataField: "nombre",
                    caption: "Nombre",
                    alignment: "left",
                    width: '200',
                    hidingPriority: 9
                },
                {
                    dataField: "edad",
                    caption: "Edad",
                    alignment: "left",
                    width: '65',
                    hidingPriority: 4


                },

                {
                    dataField: "sexo",
                    caption: "Sexo",
                    alignment: "left",
                    width: '70',
                    hidingPriority: 1,
                    visible: false

                },
                {
                    dataField: "correo",
                    caption: "Correo",
                    alignment: "left",
                    width: '120',
                    hidingPriority: 3,
                    visible: false

                },
                {
                    dataField: "telefono",
                    caption: "Teléfono",
                    alignment: "left",
                    width: '120',
                    hidingPriority: 2,
                    visible: false
                },
                {
                    dataField: "actividad",
                    caption: "Actividad",
                    alignment: "left",
                    width: '210',
                    hidingPriority: 1
                },
                {
                    dataField: "playa",
                    caption: "Playa",
                    alignment: "left",
                    width: '70',
                    hidingPriority: 7
                },

                {
                    dataField: "ambulante",
                    caption: "Ambulante",
                    alignment: "center",
                    width: '100',
                    hidingPriority: 5
                },

                {
                    dataField: "confianza",
                    caption: "Confianza",
                    alignment: "left",
                    width: '150',
                    hidingPriority: 6
                },
                {
                    dataField: "pagos",
                    caption: "Pagos",
                    alignment: "left",
                    width: '65',
                    hidingPriority: 4


                },

                {
                    dataField: "Opciones",
                    hidingPriority: 10,
                    caption: "Opciones",
                    alignment: "center",
                    allowHeaderFiltering: false,
                    width: '50',
                    cellTemplate: function (container, options) {

                        var idEnc = options.data.id;
                        var nombre = options.data.nombre;
                        var contenido = '<a href="/Details/' + idEnc + '" title="Detalles encuestador ' + nombre + '" class="btn btn-listado btn-outline-info btn-xs ml-1" ><i class="fas fa-file-alt"></i></a>'
                        

                        $("<div class='preventSelection'>")
                            .append(contenido)
                            .appendTo(container);
                    }

                }
            ],
            summary: {
                totalItems: [{
                    column: "id",
                    summaryType: "count",
                    showInColumn: "id",
                    displayFormat: "Total: {0}",
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
        root = $('#Root').val();
        source = "ListAjax";


        funcLE.instanceDataGrid();
    }
};

//************************************** ON READY **********************************************
$(function () {

    DevExpress.localization.locale("es-US");
    funcLE.init();
});