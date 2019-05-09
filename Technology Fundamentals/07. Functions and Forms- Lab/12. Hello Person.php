<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
    <form>
        Name: <input type="text" name="person" />
        <input type="submit" />
    </form>
        <?php
            function ReturnString(){
                if(isset($_GET['person'])){ 
                    $name = $_GET['person'];
                   
                    ?><p>Hello, <?= $name ?>!</p><?php          
                }
            }
            ReturnString();
        ?>
    </body>
</html>
