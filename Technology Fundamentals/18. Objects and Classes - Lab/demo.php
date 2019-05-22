<?php
    class Pet
    {
        private $name;
        private $breed;
        private $age;
        
        public function __construct($name, $breed, $age){
            $this->name = $name;
            $this->breed = $breed;
            $this->age = $age;
        }
        public function getCatName(){
            return $this->name;
        }
        public function getCatBreed(){            
            return $this->breed;
        }
        public function getCatAge(){
            return $this->age;
        }
        private function setCatName(){
            $this->name = $name;
        }
        private function setCatBreed(){
            $this->breed = $breed;
        }
        private function setCatAge(){
            $this->age = $age;
        }
        public function __toString(){
            return "Name: " . $this->getCatName() . PHP_EOL . "Breed: " . $this->getCatBreed() . PHP_EOL . "Age: " . $this->getCatAge() . PHP_EOL;
        }
    }
    echo "Enter name: ";
    $name = readline();
    echo "Enter breed: ";
    $breed = readline();
    echo "Enter age: ";
    $age = intval(readline());
    
    
    $arr=[];
    $pet1 = new Pet($name, $breed, $age);
    $arr[] = $pet1;
    foreach($arr as $item){
        echo $item . PHP_EOL;
    }
    //echo "Name: " . $pet1->getCatName() . PHP_EOL;
    //echo "Breed: " . $pet1->getCatBreed() . PHP_EOL;
    //echo "Age: " . $pet1->getCatAge() . PHP_EOL;
?>

