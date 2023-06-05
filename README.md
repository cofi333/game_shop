# Sadržaj 
### 1. [Instalacija](#instalacija)
### 2. [Specifikacija projekta](#specifikacija-projekta)
### 3. [Baza podataka](#baza-podataka)
### 4. [Funkcionalnosti](#funkcionalnosti)
  1. [Create](#create)
  2. [Read](#read)
  3. [Update](#update)
  4. [Delete](#delete)
  5. [Create admin](#create-admin)
### 5. Web stranica

<br/>

<a href="instalacija"></a>
# Instalacija
Projekat u sebi sadrži i web stranicu napisanu u php8 jeziku, pa je veoma važno da bude kloniran unutar nekog servera.
<br/>
- Pokrenite lokalni server `xampp` ili `wampp`
- Klonirajte repozitorijum u `htdocs` za xampp ili `www` za wampp server
- Otvorite phpmyadmin i importujte `game_shop.sql` fajl
- Pokrenite projekat u visual studio sa `.sln` fajlom ili otvorite kompajnilarni `.exe` fajl
- `.exe` fajl možete pronaći na sledećoj lokaciji: <br/> `~/game_shop/softersko_inzenjerstvo_projekat/bin/Release/net6.0-windows/softersko_inzenjerstvo_projekat.exe`

<br/>

<a href="specifikacija-projekta"></a>
# Specifikacija projekta
Zadatak ovog projekta je razvoj sistema za jednu prodavnicu igrica koja se sastoji od web sajta i admin aplikacije. Preko web sajta, korisnici mogu da vide prikaz svih igrica koja
prodavnica sadrži. Admin aplikacija nam pruža mnoge mogućnosti a neke od njih su:
  1. unos novih igrica
  2. brisanje igrica
  3. mogućnost promene podataka igrice
  4. mogućnost kreiranja novog admin naloga
  5. prikaz svih igrica iz baze podataka

<br/>

<a href="baza-podataka"></a>
# Baza podataka
![baza.jpg](/assets/baza.jpg)

<br/>

<a href="funkcionalnosti"></a>
# Funkcionalnosti
Aplikacija se zasniva na CRUD operacijama nad bazom podataka <br/>
Pored toga, admin ima mogućnost da direktno sa panela poseti veb stranicu, otvori bazu podataka sa slikama ili bazu podataka veb prodavnice

<br/>

Administratoru se za svaku opciju kreira zasebna windows forma, što omogućava čist i pregledan kod, <br/>
pri čemu su sve funkcionalnosti nezavisne jedna od druge. 

<br/>

<a href="create"></a>
## Create

addBtn_Click metoda se poziva kada admin unese sve potrebne podatke i klikne na dugme Insert game. Metoda prvo vrši konekciju sa bazom. Kada smo uspešno povezani sa bazom,

`string insert = "INSERT INTO games VALUES(@value0,@value1,@value2,@value3,@value4)";`

upisuje podatke u bazu. @value su podaci koje admin unese preko text boxova. <br>
@value0 parametar je id igrice. <br>
@value1 parametar je ime igrice. <br>
@value2 parametar je kategorija igrice. <br>
@value3 parametar je ime slike. <br>
@value4 je cena igrice. <br>

Ova metoda takođe omogućuje adminu da postavi sliku same igrice. Da bi admin bio u mogućnosti da skine sliku
koristi se DownloadImgeFromUrl metoda.

DownloadImageFromUrl metodi je potrebno da se prosledi parametar imageUrl. Kao što i ime kaže, potrebno je proslediti link sa koje će metoda preuzeti sliku u folder assets.

Lokacija na kojoj će se slika čuvati možemo promeniti u ovoj liniji koda:
`string rootPath = @"C:\xampp\htdocs\game_shop\assets";`

`string fileName = System.IO.Path.Combine(rootPath, gamePictureName.Text + ".jpg");`

fileName je ime slike koje admin zadaje preko gamePictureName text boxa.

Nakon toga, ukoliko je sve prošlo kako treba, adminu se ispisuje poruka da je igrica dodata i polja za unos postaju prazna. Ukoliko je došlo do greške, ispisuje se da igrica nije uneta.

<br/>

````c#
private void addBtn_Click(object sender, EventArgs e)
{
      string con = "server=localhost;user=root;database=game_shop;password=";
      MySqlConnection mySqlconnection = new MySqlConnection(con);
      mySqlconnection.Open();
      
      System.Drawing.Image image = DownloadImageFromUrl(gamePictureUrl.Text.Trim());
      
            string rootPath = @"C:\xampp\htdocs\game_shop\assets";
            string fileName = System.IO.Path.Combine(rootPath, gamePictureName.Text + ".jpg");
            image.Save(fileName);
            string insert = "INSERT INTO games VALUES(@value0,@value1,@value2,@value3,@value4)";
            MySqlCommand cmd = new MySqlCommand(insert, mySqlconnection);
            cmd.Parameters.AddWithValue("@value0", game_id.Text);
            cmd.Parameters.AddWithValue("@value1", gameName.Text);
            cmd.Parameters.AddWithValue("@value2", gameCategory.Text);
            cmd.Parameters.AddWithValue("@value3", gamePictureName.Text + ".jpg");
            cmd.Parameters.AddWithValue("@value4", gamePrice.Text);
            int i = cmd.ExecuteNonQuery();
            
            if (i == 0)
            {
                MessageBox.Show("Game is not insterted.");
            }
            
            else
            {     
                gameName.Text = "";
                gameCategory.Text = "";
                gamePictureUrl.Text = "";
                gamePictureName.Text = "";
                gamePrice.Text = "";
                MessageBox.Show("Game is inserted");
            }
            
            mySqlconnection.Close();
 }
 ````
 <br/>

<a href="read"></a>
## Read

<a href="update"></a>
## Update

<a href="delete"></a>
## Delete

deleteBtn_Click metoda se izvršava kada korisnik iz padajuće liste izabere igricu, i klikne
na dugme Delete game.

deleteBtn_Click metoda prvo vrši konekciju na bazu.

`string game = this.gameList.GetItemText(this.gameList.SelectedItem);`

game je izabrana igrica iz padajuće liste. 

Ukoliko je admin siguran da želi obrisati igricu iz baze, u sql naredbi prosleđujemo gore deklarisan string game,
i ispisuje se poruka da je igrica obrisana.

`  string delete = "DELETE FROM games WHERE game_name = " + "\"" + game + "\""; <br/>
                MySqlCommand cmd = new MySqlCommand(delete, mySqlconnection); <br>
                cmd.ExecuteNonQuery(); <br>
                MessageBox.Show("Game deleted");` ,

loadCombo metoda omogućava automatsko prikazivanje nove liste iz baze.
Potrebno je proslediti sql naredbu, ime igrice i id.

````c#

        private void loadCombo(string sql, string DisplayMember, string ValueMember)
        {

            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;
            

            try
            {
                mySqlconnection.Open();
                cmd = new MySqlCommand();
                cmd.Connection = mySqlconnection;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                gameList.DataSource = dt;
                gameList.DisplayMember = DisplayMember;
                gameList.ValueMember = ValueMember;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                mySqlconnection.Close();

            }
        }

````

loadCombo metodu potrebno je pozvati kada je admin uspešno izbrisao igricu iz baze.


````c#

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();
            string game = this.gameList.GetItemText(this.gameList.SelectedItem);
            
           

            DialogResult Message;
            Message = MessageBox.Show("Are you sure you want to delete this game?", "Game delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Message == DialogResult.No)
            {
                return;
            }
            else
            {
                string delete = "DELETE FROM games WHERE game_name = " + "\"" + game + "\"";
                MySqlCommand cmd = new MySqlCommand(delete, mySqlconnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Game deleted");
            }


            string sql = "SELECT * FROM `games`";
            loadCombo(sql, "game_name", "game_id");
        }


````





<a href="create-admin"></a>
## Create admin

<br/>

<a href="web-stranica"></a>
# Web stranica
<br/>
Web stranica ima mogućnost prikaza elemenata iz baze podataka. <br/>
Stranica se osvežava momentalno nakon napravljenih izmena u bazi podataka <br/>
Korisnici i administratori nemaju mogućnost pristupa administrativnom delu sistema sa veb sajta. <br/>
