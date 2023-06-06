<?php
    session_start();
    $_SESSION['count']++;
    $_SESSION['arrayAnswer'][]= $_POST['answer1'];
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
    <form action="task3.php" method="post" class="quiz">
        <p>Вопрос №2</p>
        <p>Как звали главного жулика в фильме "12 стульев"?</p>

        <input type="radio" id="answ1" name="answer2" value="1" >
        <label for="answ1">Остап Бендер</label> </br>

        <input type="radio" id="answ2" name="answer2" value="2" >
        <label for="answ2">Виктор Баринов</label> </br>

        <input type="radio" id="answ3" name="answer2" value="3" >
        <label for="answ3">Филипп Саломонович</label> </br>

        <input type="radio" id="answ4" name="answer2" value="4" >
        <label for="answ4">Кузька</label> </br>

        <input type="submit" name="Submit" class = "next" value="Далее">
    </form>
</body>
</html>


