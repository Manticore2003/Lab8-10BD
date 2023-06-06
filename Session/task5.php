<?php
session_start();
$_SESSION['count']++;
$_SESSION['arrayAnswer'][]= $_POST['answer4'];
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
    <form action="result.php" method="post" class="quiz">
        <p>Вопрос №5</p>
        <p>Экзамен по какому предмету сдавали студенты в фильме «Операция «Ы» и другие приключения Шурика»?</p>

        <input type="radio" id="answ1" name="answer5" value="1" >
        <label for="answ1">Физика</label> </br>

        <input type="radio" id="answ2" name="answer5" value="2" >
        <label for="answ2">Химия</label> </br>

        <input type="radio" id="answ3" name="answer5" value="3" >
        <label for="answ3">Математика</label> </br>

        <input type="radio" id="answ4" name="answer5" value="4" >
        <label for="answ4">География</label> </br>

        <input type="submit" name="Submit" class = "next" value="Далее">
    </form>
</body>
</html>


