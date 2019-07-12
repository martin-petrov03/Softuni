function attachEvents() {
    $('.button:nth-child(1)').click(function(){
        let links = $('a.button').toArray();
        console.log(links);
        for(let i = 1; i <= links.length; i++){
            $(`.button:nth-child(${i})`).attr('class', 'button');
        }
        $('.button:nth-child(1)').attr('class', 'button selected');
    });
    $('.button:nth-child(2)').click(function(){
        let links = $('a.button').toArray();
        console.log(links);
        for(let i = 1; i <= links.length; i++){
            $(`.button:nth-child(${i})`).attr('class', 'button');
        }
        $('.button:nth-child(2)').attr('class', 'button selected');    
    });
    $('.button:nth-child(3)').click(function(){
        let links = $('a.button').toArray();
        console.log(links);
        for(let i = 1; i <= links.length; i++){
            $(`.button:nth-child(${i})`).attr('class', 'button');
        }
        $('.button:nth-child(3)').attr('class', 'button selected');
    });
}