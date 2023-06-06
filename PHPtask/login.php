<?php
    $users = [
        "Ivan@gmail.com" => ["password" => "ivan777", "fullname" => "Абрамов Иван Дмитриевич"],
        "Vladislav@gmail.com" => ["password" => "vladcool", "fullname" => "Романов Владислав Витальевич"],
        "Petr@gmail.com" => ["password" => "petya666", "fullname" => "Рогожин Пётр Алексеевич"],
        "Vladimir@gmail.com" => ["password" => "volodya123", "fullname" => "Путин Владимир Владимирович"]
    ];

    $username = $_POST['username'];
    $password = $_POST['password'];

    if (isset($users[$username])) {
        if ($users[$username]['password'] == $password) {
            echo "Добро пожаловать, " . $users[$username]['fullname'] . "!";
        } else {
            echo "Неверный пароль!";
        }
    } else {
        echo "Вы не зарегистрированы!";
    }
?>
