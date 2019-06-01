function solve(weekDay, place, time) {
    time = Number(time);
    price = 0;
    if (weekDay === "Monday" || weekDay === "Tuesday" || weekDay === "Wednesday" || weekDay === "Thursday" || weekDay === "Friday") {
        if (place === "Fitness") {
            if (time >= 8 && time < 15) {
                price = 5;
            } else if (time >= 15 && time <= 22) {
                price = 7.5;
            }
        } else if (place === "Sauna") {
            if (time >= 8 && time < 15) {
                price = 4;
            } else if (time >= 15 && time <= 22) {
                price = 6.5;
            }
        } else if (place === "Instructor") {
            if (time >= 8 && time < 15) {
                price = 10;
            } else if (time >= 15 && time <= 22) {
                price = 12.5;
            }
        }
    } else if (weekDay === "Saturday" || weekDay === "Sunday") {
        if (place === "Fitness") {
            if (time >= 8 && time <= 22) {
                price = 8;
            }
        } else if (place === "Sauna") {
            if (time >= 8 && time <= 22) {
                price = 7;
            }
        } else if (place === "Instructor") {
            if (time >= 8 && time <= 22) {
                price = 15;
            }
        }
    }
    console.log(price);
}
solve('Monday', 'Sauna', 15.30)