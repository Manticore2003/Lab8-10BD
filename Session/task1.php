<?php
    session_start();
    $_SESSION['count']=1;
    $_SESSION['arrayAnswer']= array();
?>
<!DOCTYPE html>
<html>
<head>
    <title>Викторина</title>
    <meta charset="utf-8">
<style>
  <?php echo file_get_contents("sessionCSS.css"); ?>
</style>
    <script src="checkForm.js"></script>
</head>

<body>
    <form action="task2.php" method="post" class="quiz">
        <p>Вопрос №1</p>
        <p>В каком фильме повествуется о новогоднем чуде с путанницей квартир в разных городах?</p>

        <input type="radio" id="answ1" name="answer1" value="1" >
        <label for="answ1">Белое солнце пустыни</label> </br>

        <input type="radio" id="answ2" name="answer1" value="2" >
        <label for="answ2">Ирония судьбы</label> </br>

        <input type="radio" id="answ3" name="answer1" value="3" >
        <label for="answ3">Женатый холостяк</label> </br>

        <input type="radio" id="answ4" name="answer1" value="4" >
        <label for="answ4">Служебный роман</label> </br>

        <input type="submit" name="Submit" class = "next" value="Далее">
    </form>
</body>
</html>

