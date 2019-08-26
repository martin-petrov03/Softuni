function showDetails(id){
    $(`#${id}`).toggle();
}
$(async () => {
    try{
        const contactsListHTML = await $.get('contacts-list.hbs');
        const contactsInfoHTML = await $.ajax({
            method: 'GET',
            url: './contacts-info.hbs'
        });
        Handlebars.registerPartial('contactsInfo', contactsInfoHTML);

        const template = Handlebars.compile(contactsListHTML);
        let context = {contacts};
        
        const renderedHTML = template(context);
        
        $('body').append(renderedHTML);
    }
    catch(err){
        console.error(err);
    }
})