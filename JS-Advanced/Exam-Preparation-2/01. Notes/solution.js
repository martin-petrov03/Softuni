function addSticker(){
    let title = $('.title');
    let text = $('.content');
   if(title.val() && text.val()){
        let $note = $('<li>');
        $note.attr('class', 'note-content');
        let $closeBtn = $('<a>');
        $closeBtn.attr('class', 'button');
        $closeBtn.text('x');
        let $h2Element = $('<h2>');
        $h2Element.text(title.val());
        let $hr = $('<hr>');
        let $pElement = $('<p>');
        $pElement.text(text.val());

        $note.append($closeBtn);
        $note.append($h2Element);
        $note.append($hr);
        $note.append($pElement);
        $('#sticker-list').append($note);
        $closeBtn.click(function(){
            $note.remove();
        });
    }
    title.val('');
    text.val('');
}