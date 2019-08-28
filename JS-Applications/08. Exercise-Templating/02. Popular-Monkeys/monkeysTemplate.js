$(async () => {    
        const template = await $.get('MonkeyTemplate.hbs');
        const compiledTemplate = Handlebars.compile(template);

        const context = {
            monkeys
        };

        $('.monkeys').append(compiledTemplate(context));  
});

function loadMoreInfo(id){    
    $(`#${id}`).toggle();
}