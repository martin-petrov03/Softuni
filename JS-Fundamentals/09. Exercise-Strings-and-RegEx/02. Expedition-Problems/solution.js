function solve() {
  let string = document.getElementById('str').value;
  let text = document.getElementById('text').value;
  let regex = `/${string}(?<message>.*?)${string}/mg`;

  text = text.toString();
  let message = regex.exec(text);  
  console.log(message);
}