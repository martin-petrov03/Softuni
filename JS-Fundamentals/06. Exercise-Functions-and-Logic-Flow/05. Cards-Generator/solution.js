function solve() {
    function gcd_rec(a, b) {
        if (b) {
            return gcd_rec(b, a % b);
        } else {
            return Math.abs(a);
        }
    }
    //function appedndResult(){
        let num1 = Number(document.getElementById('num1').value);
        let num2 = Number(document.getElementById('num2').value);

        let result = gcd_rec(num1, num2);
        let resultSpan = document.getElementById('result');
        resultSpan.textContent = result;
    //}
    //appedndResult();
}