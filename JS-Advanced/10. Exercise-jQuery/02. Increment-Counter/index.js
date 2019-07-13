function increment(selector) {
   let textarea = $('<textarea>');
   textarea.val(0);
   textarea.addClass('counter');
   textarea.attr('disabled', true);

   let incrementBtn = $('<button>Increment</button>');
   incrementBtn.attr('class', 'btn');
   incrementBtn.attr('id', 'incrementBtn');   

   let addBtn = $('<button>Add</button>');
   addBtn.attr('class', 'btn');
   addBtn.attr('id', 'addBtn');   

   let ul = $('<ul>');
   ul.attr('class', 'results');

   incrementBtn.click(function (){
        textarea.val(+$('.counter').val() + 1);
    });
   addBtn.click(function(){
        let li = $('<li>');    
        li.text(textarea.val());
        $('.results').append(li);
   });
   $(selector).append(textarea);
   $(selector).append(incrementBtn);
   $(selector).append(addBtn);
   $(selector).append(ul);
}
