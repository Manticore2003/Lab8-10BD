<?php
session_start();
$_SESSION['count']++;
$_SESSION['arrayAnswer'][]= $_POST['answer3'];
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
    <form action="task5.php" method="post" class="quiz">
        <p>Вопрос №4</p>
        <p>Продолжите название фильма:"Любовь и "</p>

        <input type="radio" id="answ1" name="answer4" value="1" >
        <label for="answ1">Голуби</label> </br>

        <input type="radio" id="answ2" name="answer4" value="2" >
        <label for="answ2">Ненависть</label> </br>

        <input type="radio" id="answ3" name="answer4" value="3" >
        <label for="answ3">Пташки</label> </br>

        <input type="radio" id="answ4" name="answer4" value="4" >
        <label for="answ4">Cтрасть</label> </br>

        <input type="submit" name="Submit" class = "next" value="Далее">
    </form>
</body>
</html>


