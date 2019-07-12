function search() {
   let searched = $('#searchText').val();
   let lists = $(`#towns li:contains(${searched})`)
   .css('font-weight', 'bold');
   let counter = lists.length;   
      
   $('#result').text(`${counter} matches found`);
}