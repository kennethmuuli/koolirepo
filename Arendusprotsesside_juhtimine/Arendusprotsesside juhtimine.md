# Arendusprotsesside juhtimine tundide märkmed

## Ressursid
- Naermiseks: https://toggl.com/blog/page/3?post_type=post&s=comics
- PHP Manual: https://www.php.net/manual/en/index.php (language reference)
- Kaspari repo: https://github.com/Kasparsu/kta22elearnphp

<details>
  <Summary>13/04/2023</Summary>

  1) Teemad: traits, interfaces, magic methods, mitme PHP faili kasutus, PHP kasutamine veebis
    - magic methods lisa infot: https://www.php.net/manual/en/language.oop5.magic.php
  2) Autoloading: https://en.wikipedia.org/wiki/SOLID
  3) Composer: https://getcomposer.org/
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