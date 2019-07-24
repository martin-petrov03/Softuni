function onlineShop(selector) {
    let form = `<div id="header">Online Shop Inventory</div>
    <div class="block">
        <label class="field">Product details:</label>
        <br>
        <input placeholder="Enter product" class="custom-select">
        <input class="input1" id="price" type="number" min="1" max="999999" value="1"><label class="text">BGN</label>
        <input class="input1" id="quantity" type="number" min="1" value="1"><label class="text">Qty.</label>
        <button id="submit" class="button" disabled>Submit</button>
        <br><br>
        <label class="field">Inventory:</label>
        <br>
        <ul class="display">
        </ul>
        <br>
        <label class="field">Capacity:</label><input id="capacity" readonly>
        <label class="field">(maximum capacity is 150 items.)</label>
        <br>
        <label class="field">Price:</label><input id="sum" readonly>
        <label class="field">BGN</label>
    </div>`;
    $('.wrapper').append(form);
    let totalPrice = 0;
    let capacity = 0;
    $('.custom-select').mouseout(function() {
        if($('.custom-select').val() !== ''){
            $('#submit').removeAttr( "disabled");
        }
    });
    $('#submit').click(function submit(){
        let productName = $('.custom-select');
        let productPrice = $('#price');
        let productQuantity = $('#quantity');

        let $li = $('<li>');
        $li.text(`Product: ${productName.val()} Price: ${+productPrice.val()} Quantity: ${+productQuantity.val()}\n`);
        $('.display').append($li);
        
        if(capacity + +productQuantity.val() <= 150){
            totalPrice += +productPrice.val();
            capacity += +productQuantity.val();
            if(capacity === 150){
                $('#capacity').val('full');
                $('#capacity').attr('class', 'fullCapacity');
                $('#capacity').attr("disabled", true);
                $('#sum').attr("disabled", true);
                $('.custom-select').attr("disabled", true);
            }else{
                $('#capacity').val(capacity);
            }
            $('#sum').val(totalPrice);
            productName.val('');
            productPrice.val(1);
            productQuantity.val(1);
            $('#submit').attr("disabled", true);
        }
    });  
}
