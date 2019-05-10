<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form>
            <label for="inputNum">N:</label><input type="text" name="input" id="inputNum">
            <input type=""submit" />
        </form>
        <?php
            if(isset($_GET['input'])){
                $n = $_GET['input'];
                for($i = 1; $i <= $n; $i++){
                    if($i % 2 == 0){
                        echo $i . ' ';
                    }
                }
            }
        ?>
    </body>
</html>
