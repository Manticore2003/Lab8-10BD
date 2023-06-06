<?php
    session_start();
    $_SESSION['count']++;
    $_SESSION['arrayAnswer'][]= $_POST['answer2'];
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
    <form action="task4.php" method="post" class="quiz">
        <p>Вопрос №3</p>
        <p>Что означает слово «Кю» в фильме «Кин-дза-дза!»?</p>

        <input type="radio" id="answ1" name="answer3" value="1" >
        <label for="answ1">Спичка</label> </br>

        <input type="radio" id="answ2" name="answer3" value="2" >
        <label for="answ2">Привет</label> </br>

        <input type="radio" id="answ3" name="answer3" value="3" >
        <label for="answ3">Ругательное слово</label> </br>

        <input type="radio" id="answ4" name="answer3" value="4" >
        <label for="answ4">Ничего</label> </br>

        <input type="submit" name="Submit" class = "next" value="Далее">
    </form>
</body>
</html>


