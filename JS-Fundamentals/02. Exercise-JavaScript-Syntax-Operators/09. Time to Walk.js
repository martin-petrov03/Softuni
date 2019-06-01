function solve(steps, oneStepLenght, speed) {
    steps = Number(steps);
    oneStepLenght = Number(oneStepLenght);
    speed = Number(speed);
    let distance = steps * oneStepLenght;
    let speedForMeterinSecond = speed / 3.6;
    let timeSec = Math.round(distance / speedForMeterinSecond);
    let extraTime = Math.floor(distance / 500);
    timeSec += extraTime * 60;

    let hours = 0;
    let seconds = timeSec % 60;
    let minutes = (timeSec - seconds) / 60;
    while (minutes >= 60) {
        hours++;
        minutes -= 60;
    }
    if (hours < 10) {
        hours = ("0" + hours);
    }
    if (minutes < 10) {
        minutes = ("0" + minutes);
    }
    if (seconds < 10) {
        seconds = ("0" + seconds);
    }
    console.log(`${hours}:${minutes}:${seconds}`);
}
solve(4000, 0.6, 5);