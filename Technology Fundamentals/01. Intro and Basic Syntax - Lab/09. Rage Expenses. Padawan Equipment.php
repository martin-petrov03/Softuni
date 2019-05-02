<?php
    $lost_game_count = floatval(readline());
    $headset_price = floatval(readline());
    $mouse_price = floatval(readline());
    $keyboard_price = floatval(readline());
    $display_price = floatval(readline());
    
    $trashed_headset = round( $lost_game_count / 2, 1, PHP_ROUND_HALF_DOWN);
    $trashed_mouse = round( $lost_game_count / 3, 1, PHP_ROUND_HALF_DOWN);
    $trashed_keyboard = round( $lost_game_count / 6, 1, PHP_ROUND_HALF_DOWN);
    $trashed_display = round( $lost_game_count / 12, 1, PHP_ROUND_HALF_DOWN);
    
    $trashed_headset = intval($trashed_headset);
    $trashed_mouse = intval($trashed_mouse);
    $trashed_keyboard = intval($trashed_keyboard);
    $trashed_display = intval($trashed_display);
    
    $lost_money = $headset_price * $trashed_headset + $mouse_price * $trashed_mouse + $keyboard_price * $trashed_keyboard + $display_price * $trashed_display;
    
    //echo "trashed headset -> $trashed_headset \r\n";
    //echo "trashed mouse -> $trashed_mouse \r\n";
    //echo "trashed keybord -> $trashed_keyboard \r\n";
    //echo "trashed display -> $trashed_display \r\n";
    
    $lost_money = sprintf("%0.2f", $lost_money);
    echo "Rage expenses: $lost_money lv.";
?>