function solve(a, b) {
    if (b) {
        solve(b, a % b);
    } else {
        console.log(Math.abs(a));
    }
}
solve('15', '5');