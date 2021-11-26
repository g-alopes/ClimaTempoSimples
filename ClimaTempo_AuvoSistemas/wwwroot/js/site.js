// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function capturarPrevisaoSemanal() {
    var id = $('#cidades').find(":selected").val();
    var nome = $('#cidades').find(":selected").text();
    var url = $("#loaderPartialView").data('request-url');

    $.ajax(
        {
            type: 'GET',
            url: url,
            data: {
                Id: id,
                Nome: nome
            },
            dataType: 'html',
            cache: false,
            async: true,
            success: function (data) {
                $('#partialViewPrevisaoCidade').html(data);
            }
        });
}
