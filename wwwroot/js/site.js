$(function () {
    console.log("This document is ready");
    $(document).on("click", ".edit-product-button", function () {
        console.log("You just clicked button number" + $(this).val());

        //store product id to a var
        var productId = $(this).val();

        $.ajax({
            type: 'json',
            data: {
                "id": productId
            },
            url: '/product/ShowOneProductJson',
            success: function (data) {
                console.log(data)

                //filling in the modal form
                $("#modal-input-id").val(data.id);
                $("#modal-input-name").val(data.name);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);
            }
        })


    });
    $("#save-button").click(function () {
        //collect all the data from the json field and condense it into a json object which will be sent to controller
        var Product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description":$("#modal-input-description").val()
        };
        console.log("saved...");
        console.log(Product);

        //save the updated data using the controller
        $.ajax({
            type: 'json',
            data: Product,
            url: '/product/ProcessEditPartial',
            success: function (data) {
                console.log(data);
                $("#card-number-" + Product.Id).html(data).hide().fadeIn(2000);
            }
        })
    })
});

