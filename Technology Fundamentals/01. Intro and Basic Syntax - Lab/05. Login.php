<?php
    $username = readline();
    $password = readline();
    
    $counter = 0;
    while($password != strrev($username)){
        $counter++;
        if($counter >= 4)
            break;
        echo "Incorrect password. Try again.\r\n";
        $password = readline();
    }
    if($password == strrev($username) && $counter < 4){
        echo "User $username logged in.";
    }else{
        echo "User $username blocked!";
    }
?>