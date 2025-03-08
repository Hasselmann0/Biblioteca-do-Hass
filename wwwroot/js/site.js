$(document).ready(function () {

    $('#Emprestimos').DataTable({
        language : {
            
                "decimal":        "",
                "emptyTable":     "Tabela sem dados",
                "info":           "_START_ - _END_ em um total de _TOTAL_ entradas",
                "infoEmpty":      "Mostrando 0 de 0 em um total de 0 entradas",
                "infoFiltered":   "(filtered from _MAX_ total entries)",
                "infoPostFix":    "",
                "thousands":      ",",
                "lengthMenu":     "Mostrar _MENU_ Entradas",
                "loadingRecords": "Carregando ...",
                "processing":     "",
                "search":         "Procurar :",
                "zeroRecords":    "Zero itens encontrados",
                "paginate": {
                    "first":      "Primeiro",
                    "last":       "Último",
                    "next":       "Próximo",
                    "previous":   "Anterior"
                },
                "aria": {
                    "orderable":  "Order by this column",
                    "orderableReverse": "Reverse order this column"
                }
        }
    });

    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 5000)

});