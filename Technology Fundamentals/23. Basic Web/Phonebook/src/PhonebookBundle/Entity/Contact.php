<?php
namespace PhonebookBundle\Entity;
class Contact {
    private $name;
    private $number;
    
    function getName() {
        return $this->name;
    }
    
    public function getNumber() {
        return $this->number;
    }
    
    private function setName($name) {
        $this->name = $name;
    }

    private function setNumber($number) {
        $this->number = $number;
    }


}
