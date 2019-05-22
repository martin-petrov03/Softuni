<?php
    class People
    {
        private $name;
        private $id;
        private $age;
        
        public function __construct($name, $id, $age){
            $this->setName($name);
            $this->setId($id);
            $this->setAge($age);
        }
        public function getName(){
            return $this->name;
        }
        public function getId(){
            return $this->id;
        }
        public function getAge(){
            return $this->age;
        }
        
        private function setName($name){
            $this->name = $name;
        }
        private function setId($id){
            $this->id = $id;
        }
        private function setAge($age){
            $this->age = $age;
        }
        
        public function __toString(){
            return "$this->name with ID: $this->id is $this->age years old.";
        }
    }
    $command = readline();
    $people = [];
    while($command != "End"){
        $command = explode(" ", $command);
        $name = $command[0];
        $id = $command[1];
        $age = $command[2];
        
        $person = new People($name, $id, $age);
        $people[] = $person;
        $command = readline();
    }
    usort($people, function(People $person1, People $person2) use($people){
        $age1 = $person1->getAge();
        $age2 = $person2->getAge();
        
        return $age1 <=> $age2;
    });
    foreach($people as $person){
        echo $person . PHP_EOL;
    }
?>