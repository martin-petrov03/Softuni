<?php
   $pounds = intval(readline());   
   $dollars = sprintf("%0.3f", intval($pounds * 1.31));
   echo $dollars;
?>