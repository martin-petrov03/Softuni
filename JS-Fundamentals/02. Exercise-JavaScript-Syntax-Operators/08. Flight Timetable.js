function solve(arr){
    let typeStr = arr[0];
    let name = arr[1];
    let time = arr[2];
    let flightNum = arr[3];
    let gateNum = arr[4];
    
    console.log(`${typeStr}: Destination - ${name}, Flight - ${flightNum}, Time - ${time}, Gate - ${gateNum}`);
}
solve(['Departures', 'London', '22:45', 'BR117', 42]);