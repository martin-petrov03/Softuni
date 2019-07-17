//config jquery slider
$(document).on('ready', function() {      
    $(".regular").slick({
    dots: true,
    infinite: true,
    slidesToShow: 4,
    slidesToScroll: 4
    });
});

//config date-time picker
$('#datetimepicker').datetimepicker();

//config sakura
$(window).load(function(){
    $('body').sakura();
});