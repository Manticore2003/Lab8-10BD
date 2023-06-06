<?php
header("Content-Type: text/plain; charset=UTF-8");

if ($_SERVER['REQUEST_METHOD'] == 'POST') {   

    if (isset($_POST['sex']) && isset($_POST['height'])) {
        $sex = $_POST['sex'];
        $height = (int)$_POST['height'];

        if ($sex === 'man' || $sex === 'woman') {
            $ideal_weight = calculate_ideal_weight($sex, $height);
            echo "Идеальный вес для $sex с ростом $height см: $ideal_weight кг";
        } else {
            echo "Ошибка: неверное значение пола";
        }
    } else {
        echo "Ошибка: недостаточно данных";
    }
} else {
    echo "Ошибка: неверный метод запроса";
}

function calculate_ideal_weight($sex, $height) {
    if ($sex === 'man') {
        return $height - 100 - ($height - 150) / 4;
    } else {
        return $height - 100 - ($height - 150) / 2;
    }
}