function solve(examPoints, homeworkCompleted, totalHomework){
    examPoints = Number(examPoints);
    homeworkCompleted = Number(homeworkCompleted);
    totalHomework = Number(totalHomework);
    if(examPoints >= 0 && examPoints <= 400 && homeworkCompleted >= 0 && totalHomework >= homeworkCompleted && totalHomework > 0){

    let maxExamPts = 400;
    let maxCoursePts = 100;

    //input
        let bonusHomework = false;
        if(homeworkCompleted === totalHomework){
            bonusHomework = true;
        }
        
        let totalCoursePoints =  90 / 100 * examPoints;
        totalCoursePoints /= maxExamPts;
        totalCoursePoints *= 100;
        if(bonusHomework){
            totalCoursePoints += 10;
        }
        if(totalCoursePoints <= 100){
        let grade = 3 + 2 * (totalCoursePoints - maxCoursePts / 5) / (maxCoursePts / 2);

        if(grade < 3){
            grade = 2;
        } else if(grade > 6){
            grade = 6;
        }

        if(examPoints === maxExamPts){
            grade = 6;
        }
        console.log(grade.toFixed(2));
    }
    }
}
console.log(solve(200, 10, 10));