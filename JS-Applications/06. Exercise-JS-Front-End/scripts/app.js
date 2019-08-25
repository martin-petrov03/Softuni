(function attachEvents(){
    $('.dropify').dropify();
    $('#btn-facebook').on('click', loadFacebook);
    $('#btn-google').on('click', loadGooglePlus);
    
    function loadFacebook(){
        swal({
            title: "Live this site?",
            text: "If you click 'OK' you will be redirected to 'https://facebook.com'",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-primary",
            cancelButtonText: "Cancel",
            confirmButtonText: "OK",
            closeOnConfirm: true,
            closeOnCancel: true
          },
          function(isConfirm){
              if(isConfirm){
                    window.location.href = 'https://facebook.com';
              }else{
                    swal("Canceled!", "Your imaginary file has been deleted.", "error");
              }
          });
    }
    function loadGooglePlus(){
        swal({
            title: "Live this site?",
            text: "If you click 'OK' you will be redirected to 'https://plus.google.com'",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-primary",
            cancelButtonText: "Cancel",
            confirmButtonText: "OK",
            closeOnConfirm: true,
            closeOnCancel: true
          },
          function(isConfirm){
              if(isConfirm){
                    window.location.href = 'https://plus.google.com';
              }else{
                    swal("Canceled!", "Your imaginary file has been deleted.", "error");
              }
          });
    }
})();