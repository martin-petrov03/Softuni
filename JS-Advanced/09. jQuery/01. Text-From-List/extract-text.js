function extractText() {
   let lists = $('li').toArray().map((element) => element.textContent);
   $('#result').text(lists.join(', '));
}