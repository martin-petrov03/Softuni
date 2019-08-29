function attachEvents(){
    $('#btnLoadTowns').on('click', loadData);

    function loadData(){
        let townsArr = $('#towns').val().split(', ');
        
        //get template
        const template = $('#towns-template').html();

        //compile template
        const compiledTemplate = Handlebars.compile(template);
        
        //create context
        const context = {
            townsArr
        };

        //append to html
        $('#root').html(compiledTemplate(context));
    }
}