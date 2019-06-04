function solve(){
  let input = document.querySelector('#input').innerHTML;
  input = input.split('.');
  let text = input.filter(v=>v!='');
  console.log(text);
  if(text.length <= 3){
      let formatedText = document.createElement('p');
      formatedText.textContent = text;      
          
      let divOutput = document.getElementById('output');
      divOutput.appendChild(formatedText);
  } else{
      let length = text.length;
      let times = Math.floor(length / 3);
    
      for(let i = 0; i < times; i++){
        let articleElement = document.createElement('p');
        for(let i = 0; i < 3; i++){
          let formatedText = document.createElement('p');
          formatedText.textContent = text[i];
          articleElement.append(formatedText.innerHTML);
          articleElement.append('. ');      
        }        
        console.log(articleElement);
        let articlesElement = document.getElementById('output');
          articlesElement.appendChild(articleElement);
      }  
      for(i = 0; i < length - 3 * times; i++){
        let articleElement = document.createElement('article');
        let formatedText = document.createElement('p');
        formatedText.textContent = text[text.length - 1];
        articleElement.appendChild(formatedText);
        let articlesElement = document.getElementById('output');
          articlesElement.appendChild(articleElement);
      }
      console.log(length - 3 * times);
  }
}