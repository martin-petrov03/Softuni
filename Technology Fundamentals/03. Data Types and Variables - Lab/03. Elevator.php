<?php
    $people = intval(readline());
    $capacity = intval(readline());
    
    $courses = ceil($people / $capacity);
    echo $courses;
?>