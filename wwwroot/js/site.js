// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    
    $('#quotes-list').DataTable({
        "paging": false,
        "searching": false,
        "info": false,
        "columnDefs": [
            { "orderable": false, "targets": [2, 3, 4, 5] }
        ]
    });


    $('#select-material').on("change", function () {
        let material = $('#select-material').val();
        setMaterialBackground(material);
    });

    var setMaterialBackground = function (material) {
        
        let className = '';

        $('#material-box').removeClass('material-pine');
        $('#material-box').removeClass('material-oak');
        $('#material-box').removeClass('material-veneer');
        $('#material-box').removeClass('material-rosewood');
        $('#material-box').removeClass('material-laminate');

        if (material == 'Pine') { className = 'material-pine'; }
        if (material == 'Oak') { className = 'material-oak'; }
        if (material == 'Veneer') { className = 'material-veneer'; }
        if (material == 'Rosewood') { className = 'material-rosewood'; }
        if (material == 'Laminate') { className = 'material-laminate'; }

        $('#material-box').addClass(className);
    }

    let material = $("#details-material").data("material-type");
    setMaterialBackground(material);
});
