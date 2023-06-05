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
### 5. [Web stranica](#web-stranica)
### 6. [Info](#info)

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

U admin aplikaciji, admin ima mogućnost da vidi sve igrice koje su trenutno upisane u bazu podataka.
Kada se main prozor učita, izvrši se metoda loadData.

loadData je metoda koja u listu dodaje podatke koji su u tabeli games u bazi podataka.

Prvo se vrši konekcija na bazu.
Nakon toga, u listu se dodaju potrebne kolene za prikaz jedne igrice.

````c#

game_list.Columns.Add("Id", 120);
            game_list.Columns.Add("Name", 180);
            game_list.Columns.Add("Category", 200);
            game_list.Columns.Add("Picture", 180);
            game_list.Columns.Add("Price", 60);
            game_list.View = View.Details;

````

Kada imamo strukturu same liste, potrebno je preko sql naredbe da selektujemo sve igrice iz tabele.

` cmd.CommandText = "SELECT * FROM games";`

Nakon toga preko for petlje dodajemo igrice u kolone.

````c#

 for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["game_id"].ToString());
                listitem.SubItems.Add(dr["game_name"].ToString());
                listitem.SubItems.Add(dr["game_category"].ToString());
                listitem.SubItems.Add(dr["game_picture"].ToString());
                listitem.SubItems.Add(dr["game_price"].ToString());
                game_list.Items.Add(listitem);



            }


````


loadData metoda se takođe izvršava ako admin klikne na dugme Refresh View u admin aplikaciji.

````c#
public void loadData()
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            DataTable dt;
            MySqlDataAdapter da;
            MySqlCommand cmd;

            game_list.Columns.Add("Id", 120);
            game_list.Columns.Add("Name", 180);
            game_list.Columns.Add("Category", 200);
            game_list.Columns.Add("Picture", 180);
            game_list.Columns.Add("Price", 60);
            game_list.View = View.Details;

            cmd = new MySqlCommand();
            cmd.Connection = mySqlconnection;
            cmd.CommandText = "SELECT * FROM games";

            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["game_id"].ToString());
                listitem.SubItems.Add(dr["game_name"].ToString());
                listitem.SubItems.Add(dr["game_category"].ToString());
                listitem.SubItems.Add(dr["game_picture"].ToString());
                listitem.SubItems.Add(dr["game_price"].ToString());
                game_list.Items.Add(listitem);



            }
        }
````


<a href="update"></a>
## Update

button1_Click metoda se izvršava kada admin izabere neku igricu iz padajuće liste, unese barem jedan podatak
koji želi da izmeni i klikne na dugme Update game.

button1_Click prvo vrši konektovanje sa bazom. 

Izmena podataka se vrši tako što se prvo proveri da li je novi podatak koji je potreban da se unese
unešen u text box.
Primer: ako admin želi da promeni ime igrice. Preko if petlje se proverava da li je polje prazno.
Ako nije prazno, preko sql naredbe se vrši promena u bazi. 

````c#

  if (!string.IsNullOrEmpty(gameName.Text))
            {
                string updateName = "UPDATE games SET game_name= '" + gameName.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateName, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

````

Admin ima mogućnost da promeni i sliku igrice. Kao i kod Add Game, potrebna nam je downloadImageFromUrl
metoda koja skida sliku sa linka koju joj prosledimo.

````c#

  public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return image;
        }

````

Ukoliko je izvršena promena, preko messageBox se obaveštava admin da je igrica ažurirana.

````c#

 private void button1_Click(object sender, EventArgs e)
        {
            int updatedFields = 0;

            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();
            string gameNum = gameList.SelectedValue.ToString();
            int game = Int32.Parse(gameNum);


            if (!string.IsNullOrEmpty(gameName.Text))
            {
                string updateName = "UPDATE games SET game_name= '" + gameName.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateName, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

            if (!string.IsNullOrEmpty(gameCategory.Text))
            {
                string updateCategory = "UPDATE games SET game_category= '" + gameCategory.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateCategory, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

           

            if (!string.IsNullOrEmpty(gamePrice.Text))
            {
                string updateGamePrice = "UPDATE games SET game_price= '" + gamePrice.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateGamePrice, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

            if(!string.IsNullOrEmpty(gamePictureUrl.Text))
            {
                System.Drawing.Image image = DownloadImageFromUrl(gamePictureUrl.Text.Trim());

                string rootPath = @"C:\xampp\htdocs\game_shop\assets";
                string fileName = System.IO.Path.Combine(rootPath, gamePictureName.Text + ".jpg");
                image.Save(fileName);
                updatedFields++;
            }

            if (!string.IsNullOrEmpty(gamePictureName.Text))
            {
                string updatePictureName = "UPDATE games SET game_picture= '" + gamePictureName.Text + ".jpg" + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updatePictureName, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

            if (updatedFields > 0)
            {
                MessageBox.Show("Game updated!");
                string sql = "SELECT * FROM `games`";
                loadCombo(sql, "game_name", "game_id");
                gameName.Text = "";
                gameCategory.Text = "";
                gamePrice.Text = "";
                gamePictureUrl.Text = "";
                gamePictureName.Text = "";


            }
            else
            {
                MessageBox.Show("Game not updated");
            }

            

        }

````

 





<a href="delete"></a>
## Delete

deleteBtn_Click metoda se izvršava kada korisnik iz padajuće liste izabere igricu, i klikne
na dugme Delete game.

deleteBtn_Click metoda prvo vrši konekciju na bazu.

`string game = this.gameList.GetItemText(this.gameList.SelectedItem);`

game je izabrana igrica iz padajuće liste. 

Ukoliko je admin siguran da želi obrisati igricu iz baze, u sql naredbi prosleđujemo gore deklarisan string game,
i ispisuje se poruka da je igrica obrisana.

```c#
  string delete = "DELETE FROM games WHERE game_name = " + "\"" + game + "\"";
                MySqlCommand cmd = new MySqlCommand(delete, mySqlconnection); 
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("Game deleted");
```               

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
createaccountBtn_Click metoda se izvršava kada admin unese sva potrebna polja i klikne na dugme Create account.

Prvo se vrši konekcija na bazu. Ukoliko je neka od polja ostalo prazno, preko MessageBox se ispisuje poruka
da su polja prazna.
Kada su podaci uneti, prvo se vrši provera da li su polja za password i confirm password ista.

Ako jesu, proverava se da li admin sa tim imenom već postoji u bazi.

`string check = "SELECT COUNT(*) FROM admin WHERE admin_username = @name";`

Ukoliko postoji, izbacuje se poruka o grešci.

Ako ne postoji, vrši se unos podataka u bazu podataka u tabelu admin.

`string register = "INSERT INTO admin VALUES ('',@value1,@value2)";`

@value1 parametar je ime admina. <br>
@value2 parametar je šifra admina. <br>

Ako je sve prošlo kako treba, ispisuje se poruka da je nalog uspešno kreiran.

````c#

 private void createAccountBtn_Click(object sender, EventArgs e)
        {


             if(adminUsername.Text =="" && adminPassword.Text=="" && adminConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (adminPassword.Text == adminConfirmPassword.Text)
            {
                string con = "server=localhost;user=root;database=game_shop;password=";
                MySqlConnection mySqlconnection = new MySqlConnection(con);
                mySqlconnection.Open();
                string check = "SELECT COUNT(*) FROM admin WHERE admin_username = @name";
                MySqlCommand checkCmd = new MySqlCommand(check, mySqlconnection);
                checkCmd.Parameters.AddWithValue("@name", adminUsername.Text);
                int userExist = Convert.ToInt32(checkCmd.ExecuteScalar());

                if(userExist == 0)
                {
                    string register = "INSERT INTO admin VALUES ('',@value1,@value2)";
                    MySqlCommand cmd = new MySqlCommand(register, mySqlconnection);
                    cmd.Parameters.AddWithValue("@value1", adminUsername.Text);
                    cmd.Parameters.AddWithValue("@value2", adminPassword.Text);
                    cmd.ExecuteNonQuery();
                    mySqlconnection.Close();

                    MessageBox.Show("Your Account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Admin with that name already exist.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            else
            {
                MessageBox.Show("Passwords does not match, please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


````

<br/>

<a href="web-stranica"></a>
# Web stranica
<br/>
Web stranica ima mogućnost prikaza elemenata iz baze podataka. <br/>
Stranica se osvežava momentalno nakon napravljenih izmena u bazi podataka <br/>
Korisnici i administratori nemaju mogućnost pristupa administrativnom delu sistema sa veb sajta. <br/>

<br/>

![web1.jpg](/assets/web1.jpg) <br/>
![web2.jpg](/assets/web2.jpg) 

<br/>

<a href="info"></a>
# Info
Softversko inženjerstvo - projekat <br/>
Filip Kujundžić, Stefan Buljić <br/>
VTŠ Subotica 2023 <br/>
