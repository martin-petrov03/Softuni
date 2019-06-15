function getNext() {
    function hailStoneSeq(n){
        var seq=[n]
    
        while(n!=1){
            if(n%2==0) n/=2
            else n=(n*3)+1
    
            seq.push(n)
        }
    
        return seq.join(' ')
    }
    let inputNumber = Number(document.getElementById('num').value);
    let result = hailStoneSeq(inputNumber);
    let spanResult = document.getElementById('result');
    spanResult.textContent = result + ' ';
}