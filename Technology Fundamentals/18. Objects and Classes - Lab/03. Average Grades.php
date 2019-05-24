<?php
    class Student
    {
        private $name;
        private $listOfGrades;        
        private $average;
                
        public function __construct($name, $listOfGrades, $average){
            $this->setName($name);
            $this->setListOfGardes($listOfGrades);
            $this->setAverage($average);
        }
        public function getName(){
            return $this->name;
        }
        public function getAverage(){
            return $this->average;
        }
        public function getListOfGardes(){
            return $this->listOfGrades;
        }
        
        private function setAverage($average){
           $this->average = $average;
        }
        private function setName($name){
            $this->name = $name;
        }
        private function setListOfGardes($listOfGrades){
            $this->listOfGrades = $listOfGrades;
        }
        
        public function __toString(){
            if($this->getAverage() >= 5){                
                $grade = number_format($this->getAverage(), 2);
                return $this->getName() . " -> " . $grade . PHP_EOL;
            }
            return "";
        }
    }
    $studentsCount = intval(readline());   
    $people = [];   
    for($i = 0; $i < $studentsCount; $i++){
        $input = readline();
        $command = explode(" ", $input);
        $name = $command[0];
        $grades = [];
        for($j = 1; $j < count($command); $j++){
            $current_grade = $command[$j];            
            $grades[] = $current_grade;
        }
        $average = array_sum($grades) / (count($command) - 1);
        //var_dump($grades);
        //echo $average . " ";
        $student = new Student($name, $grades, $average);
        $people[] = $student;
        
    }
    //var_dump($people);
    usort($people, function(Student $student1, Student $student2) use($people){
        $name1 = $student1->getName();
        $name2 = $student2->getName();
        $average1 = $student1->getAverage();
        $average2 = $student2->getAverage();
        if($name1 === $name2){
            return $average2 <=> $average1;
        }
        return $name1 <=> $name2;
    });
    foreach($people as $student){
        echo $student;
    }
?>