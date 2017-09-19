$(document).ready(function () {
    $("#searchTxtID").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/AdminSearch/LiveSearch",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.productName, value: item.productName };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });


    $("#searchTxtIdUser").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Search/LiveSearch",
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.productName, value: item.productName };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });
})
