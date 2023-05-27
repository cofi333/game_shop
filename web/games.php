<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./style/index.css">
    <title>Games</title>
    <link rel="icon" type="image/x-icon" href="./img/favicon.png">
</head>
<body>
<header>
        <div class="navlogo">
            <a href="index.html"><img src="./img/logo.png" alt="logo.png"></a>
            <h2>Game Shop</h2>
        </div>
        <nav class="navigation">
            <ul class="navitems">
                <li><a href="#">GAMES</a></li>
                <li><button>REGISTER</button></li>
                <li><button>LOGIN</button></li>
            </ul>
        </nav>
    </header>

    <main id="gameMain">
        <div class="games">
            <?php
                include_once 'db.php';
                $q ="SELECT * FROM games";
                $result = mysqli_query($connection, $q) or die(mysqli_error($connection));
                if (mysqli_num_rows($result) > 0)
                {
                    while ($record = mysqli_fetch_array($result))
                    {
                        echo '<div class="game">';
                        echo "<p> $record[game_name] </p>";
                        echo "<img src=\"../assets/$record[game_picture]\">";
                        echo "<p> $ $record[game_price]</p>";
                        echo '</div>';
                    } 
                    mysqli_free_result($result);
                } else {
                    echo '<p id="errorMsg">' . "Trenutno nema dostupnih igara" . '</p>';
                }
                mysqli_close($connection);
            ?>
        </div>
    </main>

    <footer>
        <p>Filip Kujundžić</p>
        <p>Stefan Buljić</p>
        <p>Softversko inženjerstvo 2023</p>
        <p>VTŠ Subotica</p>
    </footer>
    
</body>
</html>


