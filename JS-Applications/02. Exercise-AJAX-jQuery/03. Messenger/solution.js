function attachEvents(){
    let url = `https://messenger-71631.firebaseio.com/messages.json`;
    $('#submit').click(function(){
        let name = $('#author').val();
        let message = $('#content').val();
        
        let messageObj = {
            "author": name, 
            "content":message, 
            'timestamp': Date.now()
        };
        
        $.ajax({
            method: 'POST',
            url,
            data: JSON.stringify(messageObj),
            success: () => {
                console.log('Send...');
            }
        });
    });
    $('#refresh').click(function(){
        $.ajax({
            method: 'GET',
            url,            
            success: (data) => {
                let textarea = $('#messages');
                textarea.val('');
                for(let message of Object.entries(data)){
                    let author = message[1].author;
                    let content = message[1].content;

                    let line = `${author}: ${content}\n`;
                    textarea.append(line);
                }
            }
        });
    });
}