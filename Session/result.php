<?php
session_start();
$_SESSION['arrayAnswer'][]= $_POST['answer5'];

$score=0;
if($_SESSION['arrayAnswer'][0]=="2")
    $score++;
if($_SESSION['arrayAnswer'][1]=="1")
    $score++;
if($_SESSION['arrayAnswer'][2]=="3")
    $score++;
if($_SESSION['arrayAnswer'][3]=="1")
    $score++;
if($_SESSION['arrayAnswer'][4]=="1")
    $score++;


if($score<3)
    $descript='Вы плохо знаете советскую классику';
else
    $descript='Так держать!';

echo "<div class='quiz'>Результат: " .$score."/".$_SESSION['count']. "</br>". $descript."</div>";
?>

<!DOCTYPE html>
<html>

<head>
    <title>Викторина</title>
    <meta charset="utf-8">
<style>
  <?php echo file_get_contents("sessionCSS.css"); ?>
</style>
</head>
<body>

</body>
</html>
