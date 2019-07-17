$('#bookHourBtn').click(function(event){
    event.preventDefault();
    event.stopPropagation();
    let username = $('#username').val();
    let lecturer = $('#lecturer :selected').text();
    let date = $('#datetimepicker').val();
    
    const usernameRegex = /^[A-Za-z0-9_]{3,25}$/gm;
    //validate
    if(usernameRegex.test(username) && lecturer.length > 0 && lecturer !== 'Lecturer name' && date !== ''){
        $.notify('Consultation added', 'success');
        addNewConsultation(lecturer, date);
    }else{
        $.notify('Try again', 'error');
    }
});
function addNewConsultation(lecturer, date){
    $('.education article:nth-child(3) .box-body ul').append(`<li><span>${lecturer} - ${date.split(' ')[0].split('/')[1]}/${date.split(' ')[0].split('/')[2]} - ${date.split(' ')[1]}</span><i class="fas fa-chevron-circle-right"></i></li>`);
    increaseCount();    
}
function increaseCount(){
    let score = +document.querySelectorAll('.box-footer span')[0].textContent;
    document.querySelectorAll('.box-footer span')[0].textContent = score + 1;
}