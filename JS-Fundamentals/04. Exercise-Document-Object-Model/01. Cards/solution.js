function solve() {
    Array.from(document.getElementsByTagName('img')).forEach((img) => {
        img.addEventListener('click', getCardValue);
    });
    function getCardValue(element) {
        let card = element.target;

        card.scr = './images/whiteCard.jpg';
        //card.style.background-color = 'white';
        card.removeEventListener('click', getCardValue);

        let parent = card.parentNode;
        let span = document.getElementById('result').children;        
        if(parent.id === 'player1Div'){
            span[0].textContent = card.name;
        } else if(parent.id === 'player2Div'){
            span[2].textContent = card.name;
        }

        let leftScore = span[0].textContent;
        let rightScore = span[2].textContent;
        if(leftScore !== '' && rightScore !== ''){
            let winner;
            let looser;
            if(Number(rightScore) < Number(leftScore)){
                winner = document.querySelector(`#player1Div img[name="${leftScore.textContent}"]`);
                looser = document.querySelector(`#player2Div img[name='${rightScore.textContent}']`);  
            } else{                
                winner = document.querySelector(`#player2Div img[name="${rightScore.textContent}"]`);
                looser = document.querySelector(`#player1Div img[name='${leftScore.textContent}']`);
                console.log('player2Div');
            }
            winner.style.border = '2px solid green';
            looser.style.border = '2px solid darkred';
            document.getElementById('history').textContent += `[${leftScore} vs ${rightScore}]`;
        }
        
        //result.appendChild();
    }
}