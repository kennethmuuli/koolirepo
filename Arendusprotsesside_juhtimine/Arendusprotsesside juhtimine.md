# Arendusprotsesside juhtimine tundide märkmed

## Ressursid
- Naermiseks: https://toggl.com/blog/page/3?post_type=post&s=comics
- PHP Manual: https://www.php.net/manual/en/index.php (language reference)
- Kaspari repo: https://github.com/Kasparsu/kta22elearnphp

<details>
  <Summary>11/05/2023</Summary>

  1) Autentimisest juttu
  2) Failide üleslaadimine
    - Kuhu need lähevad? Selle jaoks tuleb lisada vormile lisa tükk `enctype="multipart/form-data"`
    - Liiga suur pilt andis error koodiks 1. Baas suurus 2MB.
    - Faili salvestus, fail salvestatakse algselt ainult hetkeks siin:
    ````
    public function store(){
        dd($_POST, $_FILES);
        $post = new Post();
        $post->title = $_POST['title'];
        $post->body = $_POST['body'];
        $post->save();
        header('Location: /admin/posts');
    }
    ````
      - Et fail salvestuks tuleb see ära liigutada kasutades funktsiooni `move_uploaded_file`, näiteks: `move_uploaded_file($_FILES['image']['tmp_name'], 'public/uploads' . $_FILES['image']['name']);`
      - nime jätmine originaal nimeks on halb mõte, kuna uus sama nimega fail kirjutaks selle üle

</details>

<details>
  <Summary>28/04/2023</Summary>

  1) Andmebaasi päringute lihtsustamine, andmebaasi päringute class (DB)
  2) Andmebaasi mudelite loomine (Models)
  3) Lugemiseks vaatamiseks, e-mailide valideerimisest:
    - https://www.youtube.com/watch?v=xxX81WmXjPg
    - https://david-gilbertson.medium.com/the-100-correct-way-to-validate-email-addresses-7c4818f24643
  4) Jäin maha, tunni lõpus Kaspari gitist tiritud sisu alla

</details>

<details>
  <Summary>27/04/2023</Summary>

  1) Materjale:
    - https://en.wikipedia.org/wiki/Shebang_(Unix)
    - https://learn.microsoft.com/en-us/windows/powertoys/
    - https://www.php.net/manual/en/types.comparisons.php
  2) PHP ja andmebaaside kasutamine:
    - Tarvilik ennekõike välja valida, millist andmebaasi kasutada.
    - Mõned andmebaasid:
      - https://www.postgresql.org/download/
      - https://www.mysql.com/
      - https://mariadb.org/
      - https://sqlite.org/index.html
    - Andmebaaside haldustööriistad:
      - SQL Clients:
        - https://medevel.com/17-sql-client-open-source/
        - https://www.jetbrains.com/datagrip/
  3) Andmebaasi ülesseadmine:
    - Installisime DataGripi, lõime "posts" tabeli ja enablisime php-le (php.inis) extensioni pdo_sqlite
    - PDO manual https://www.php.net/manual/en/book.pdo.php
    - Connecting the database (PDO Example): https://www.w3schools.com/php/php_mysql_connect.asp
  4) Andmebaasist andmete saamine:
    - 

</details>

<details>
  <Summary>13/04/2023</Summary>

  1) Teemad: traits, interfaces, magic methods, mitme PHP faili kasutus, PHP kasutamine veebis
    - magic methods lisa infot: https://www.php.net/manual/en/language.oop5.magic.php
  2) Autoloading: https://en.wikipedia.org/wiki/SOLID
  3) Composer: https://getcomposer.org/ `composer install`
  4) Kodune ülesanne, lugemiseks:
    - https://www.php-fig.org/psr/psr-4/
    - https://www.php-fig.org/psr/psr-1/
    - https://www.php-fig.org/psr/psr-12/
    - https://phptherightway.com/

</details>

<details>
  <Summary>13/04/2023</Summary>

  Kommentaariks: Kuna arendusprotsessi juhtimisest pole eriti pikalt midagi rääkida siis keskendume hoopis veidi rohkem PHP-le.

  1) Algselt loodud C ja HTMLi ühenduslüliks. Circa versioon 5-st võiks öelda, et PHPst oli välja kujunendud täiesti omaette programmeerimiskeel.
    - Huvitav fakt, versioon 6-st hüpati lihtsalt üle. See pidi tulema välja, kuid tehti enne lansseeringut otsus, et seda ei lastagi välja.
  2) PHPl on olemas väga hea dokumentatsioon: https://www.php.net/docs.php
  3) Miks PHP? Kui teistes keeltes saab teha tehniliselt väga palju asju siis PHP on ainult serveri poolne keel, millega saab teha kahte asja, veebilehti ja käsurea programme. Sellest annab märku ka asjaolu, et PHPs, erinevalt teisest keeltes on veebiraamistike kümneid, mis on kõik väga head.
    - PHP = PHP Hypertext Preprocessor (recursive acronym on siin sõna otses mõttes programmeerijate nali)
  4) PHPl puudub installer (s.t. ka wingetis seda pole), see tuleb Zipina alla tõmmata paigutada õigesse kausta.
    - **PHP Install:**
      - https://windows.php.net/download#php-8.2 (VS16 x64 Non Thread Safe (2023-Apr-12 09:14:08))
      - unzip + cut all
      - /c/
      - uus kaust "php" + paste
      - käsureal kasutamiseks tuleb lisada sellele path
        - search edit system environment variables
        - environment variables
        - system variables "Path"
        - Edit
        - New, lisa path -> OK, OK, OK
        - *Pathi muutmisel vajab terminal restarti*
        - saad edukat installi lihtsalt kontrollida `php -v` käsuga
  5) Lõime uue "learnphp" repo
  6) PHP märkmed: 
    - PHP on algselt olnud template keel ja see on siiani kasutatav.
    - kui fail sisaldab ainult PHPd siis lõpumärke see ei vaja. Kui tahad HTMLi vahele siis vajab, näide:
      ````
      <?php
        echo "hello world";
      ?>
      <h1>Hello PHP</h1>
      <?php
          echo "hello world";
      ?>
      ````
    - Pole treppimise tundlik
    - käivitamiseks kaks varianti:
      - käsureal `php failinimi.php`
      - built in serves, s.t. veebibrauseris (default) `php -S localhost:<aadressi number>`
      - loogiliste blokkide loppu oodatakse semikoolonit
    - kommentaarid:
      - `//` line comment
      - `/**/` block comment
    - muutujad:
      - `$` märgistatud kohustuslikult alati
      - pole tyybi tundlikud
      - jatkasin kommentaaridega index.php failis, kiirem...

</details>

<details>
  <Summary>30/03/2023</Summary>

  1) Tööriistad:
    - Toggl - time-tracking
    - Management:
      - Jira
      - Trello
      - Asana
      - AzureDevOPS

  2) Arendusmetoodikad:
    - https://www.slideshare.net/hareshkarkar/overview-of-agile-methodology
    - https://www.youtube.com/watch?v=a-BOSpxYJ9M
    - Waterfall vs Agile
      - https://agilemanifesto.org/
      - Scrum
      - Kanban
      - RUP
      - XP jne

</details>