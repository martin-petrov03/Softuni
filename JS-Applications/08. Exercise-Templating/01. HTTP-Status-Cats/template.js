$(() => {
    renderCatTemplate();

    async function renderCatTemplate() {
        const template = await $.get('catsTemplate.hbs');  
        const compiledTemplate = Handlebars.compile(template);

        const context = {
            cats
        };

        $('#allCats').append(compiledTemplate(context));
    }
});

function loadMoreInfo(status){
    $(`#${status}`).toggle();
}