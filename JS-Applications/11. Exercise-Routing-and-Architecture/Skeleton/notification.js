const notifications = (() => {
    $(document).on({
        ajaxStart: () => $('#loading').fadeIn(),
        ajaxStop: () => $('#loading').fadeOut()
    });

    function showSuccess(message){
        let successBox = $('#info');
        successBox.text(message);

        successBox.fadeIn();
        successBox.fadeOut(5000);
    }

    function showError(error){
        let errorBox = $('#error');
        errorBox.text(error);

        errorBox.fadeIn();
        errorBox.fadeOut(5000);
    }
    
    return {
        showSuccess,
        showError
    }
})();