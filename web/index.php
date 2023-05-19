<?php
include_once 'db.php';
$q ="SELECT * FROM games";

$result = mysqli_query($connection, $q) or die(mysqli_error($connection));

if (mysqli_num_rows($result) > 0)
{

    while ($record = mysqli_fetch_array($result))
    {
        echo "<p> $record[game_name] </p>";
        echo "<img src=\"../assets/$record[game_picture]\">";
    }

    mysqli_free_result($result);
} else {
    echo "Nema podataka u bazi!";
}


mysqli_close($connection);