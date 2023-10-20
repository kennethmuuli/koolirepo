# Andmemudelitele rakenduste loomine tundide märkmed

## Ressursid
- https://www.jetbrains.com/phpstorm/
- https://laravel.com/
- https://laravel.com/docs/10.x#your-first-laravel-project


<details>
    <Summary>05/25/2023</Summary>
    1) Tänapäeval uus liikumine, mis põhineb mõttel, kui FE teeme JSiga siis miks me selles ka BE ei tee.
    2) https://expressjs.com/ ; https://adonisjs.com/ ; https://nextjs.org/docs ; https://nuxt.com/ ; https://kit.svelte.dev/docs/server-only-modules ; https://koajs.com/
    3) Tunnis -> 
        - https://expressjs.com/en/starter/installing.html
        - Lisasime listen f port muutuja ette `http://localhost:`, et tuvastaks lingi.
        - Serveri käivitamiseks `npm index.js`
        - Koodi muutmisel (nagu enamus rakendustes v.a. PHPs) muutused ei kajastu enne kui serveri uuesti käivitad
            - Viimasest murest lahtisaamiseks (PHP laadsemaks tegemiseks) on igas keeles erinevaid häkke. Node puhul Nodemon pakett. -> https://www.npmjs.com/package/nodemon
                - Käivitamiseks mugavus käsk `npx`
                - Alternatiivselt package.jsonisse scriptide alla `"start": "nodemon"` -> `npm run start`
        - Templiitimise tarbeks on olemas terve hunnik valikuid: pug.js ;twig.js ; handlebars.js ; mustache.js ; nunjucks.js jne
        - Votsime kasutusele nunjucks jsi -> https://mozilla.github.io/nunjucks/getting-started.html
            - .njk / .nunjucks failidega peab arvestama, et see ei toota out of the box, tuli prefs/settingsis emmet otsida ja lisada include language viide, antud juhul nunjucks = html
            


</details>

<details>
  <Summary>12/05/2023</Summary>

    1) Millal peaks terminali restartima. Kui env pathi muudad siis peaks terminali resama. Teistel keeltel üldiselt tuleb pakette installides silmaspidada, et local server ilmselt vajab resa, kui oli parasajagu lahti ja pole spetsiaalset tööriista serveri käivitamise kontrolliks
    2) .env faili taastamine example alusel või kui sul mingi koopia olemas sellest (NB! taaskord seda ära avalikult kusagil sisustatud kujul jaga)
        - APPKEY läheb siis ka kaduma kui taastad examplest, seda on lihtne uuesti geneda läbi artisani või lausa local serveri käima laskmisel selle tarbeks eraldi tool kohe su katkises veebis olemas.
    3) shift + shift shortcut (search files by name) voimaldab kiirelt navigeerida, tihtilugu mujual IDEdes on see hoopis ctrl + p
    4) Raakisime route konfliktidest, nende lahendamiseks olemas muidu ka tooriist `php artisan route:list` -> naitab koiki rakenduses saadaval olevaid route (jalgida tuleb aadresse ja asukohti/nimesid, kuna viimane jaab peale)
    5) PHPStormi peek definition on ctrl + click pohine
    6) Andmebaasi ylesse seadmine:
        - envi failis muudame: 
            - DB_CONNECTIONit vastavalt soovile, ntks mySQL -> sqlite
            - DB_DATABASE vastavalt soovile, congif/database.phps info olemas | meie puhul kommenteerisime selle lihtsalt valja, sest sellel default olemas, mis ise annab pathi ja loob kausta oigesse kohta
            - kontrollime kas koik tootab `php artisan migrate` tehes ara vajalikud migratsioonid andmebaasi
            - saab kasutada phpstormi database ja seada ylesse data source, kuid kasutasin antud juhul datagripi ja seadsin datasource seal ylesse
                - need saaks koik korraga tagasi votta kasutades `php artisan migrate:rollback` kasuga
                - `php artisan migrate:fresh` kustutab ara sinu DBst koik tabelid, ning loob koik tabelid uuesti JA teeb uuesti migratsioonid
                - `php artisan migrate:refresh` sarnane freshile aga ei kusuta ara koiki tabeleid vaid jooksutab koikidele migratsioonidele down kaskluse, s.t. viib algseisu tagasi ja jooksutab selle jargselt migratsioonid
            - kui tahan enda tabelit (naiteks postitused) siis:
                - loome mudel `php artisan make:model <ModelName> --all`
                - saad alati rohkem infot helpiga -> `php artisan make:model --help`
                - peale seda napime uut migrationit, lisame valjad, mida soovime ja jooksutame uuesti migrate kasku
    7) Dummy data loomine, factories, kuidas luua ja seeder, kui palju neid luua
        - factory:
            - Laravel kasutab FakerPHP raamistiku, mis genereerib dummy datat
        - peale factory ja seedi yles seadmist jooksutame kasu `php artisan db:seed PostSeeder`
        - kuna DatabaseSeeder on default sellel seed kasul siis voime lisada sellise rea selle run funktsioonile `$this->call(PostSeeder::class);` ja nyyd kutsutakse ka PostSeeder sealt valja
    8) gitignore faile voib olla ka mitmeid


</details>

<details>
  <Summary>11/05/2023</Summary>

    1) Blog projekti loomine, kasutades neid juhised -> https://laravel.com/docs/10.x#your-first-laravel-project
        - viskas errorit, veateatest saime teada, et php.inis oli enablemata `fileinfo`
        - siis oli probleem juba loodud projektikaustaga, tegime lihtsalt `rm -r <projektikausta nimi>` ja uuesti esimene käsk
        - projekt pysti ja siis tegin init commiti ara, et oleks muutuseid naha kenasti vs algse projektiga
    2) Tirisin alla ka PHPStormi, et seda IDE proovida
        - Kaspar disablis inlay-hintidest maha parametersi näitamise AGA see on muidu üli kasulik asi, palju mugavam kirjutada
    3) Käisime läbi kataloogide sisu kõrgel tasandil
        - Enamus tööst appi all toimub controllerite ja modelite kaustades
        - Bootstrap siin EI viita CSS raamistikule vaid koodile, mis jooksutatakse rakenduse käivitamisel "bootstrapping smth"
        - ORM -> objekt relational model, voimaldavad andmebaaside seoseid kirjeldada ja mudida koodi tasandil
        - public kataloog taaskord sisaldab index.php ja on avalikult nähtav osa, sellega peidetakse ara kogu muu sisu
            - .htaccess veebiserveri seadistuse jaoks (loodud iseenesest Apache jaoks, kuid saab pmst kasutada ka teiste jaoks)
            - robots.txt moeldud robotite kontrolliks, naitaks blokeeri robotitel lehtesid vaadata
        - resources, tooriistade tarbeks, naiteks Vite, mida juba vaatasime, kuid seal asuvad ka meie vaated 'views' kaust
            - Laravel ise kasutab Blade templiitimiseks
        - env fail alati git ignore, kuna sisaldab tundliku infot, kui tahad seda nn malli jagada siis täienda alati uute väärtuste lisamisel envi ja env exampleit ja väärtusta selle failis muutujad dummy väärtustega
        - artisan, laraveli terminal tööriist, mis tuleb kaasa koos Laravelliga, väga asjalik asi
        - KASUTUSELE LÄHEVAD MEIL PÕHILISELT: .env ning andmebaasi, route ja app model ja app controlleri kaustad
    4) Artisani jooksutamiseks `php artisan`, pead olema projekti root kataloogis. Mõned olulisemad kasud:
        - `php artisan serve` - käivitab ja serveerib meie rakenduse
        - `make`
    5) Blade kasutamise näidis:

        ````

        {{--    <?php for($i = 0; $i<10; $i++) ?>--}}
        {{--        <li><?=$i?></li>--}}
        {{--    <?php endfor; ?>--}}

        {{--PHP tagide asemel @--}}
        {{--    @for($i = 0; $i<10; $i++)--}}
        {{--        <li><?=$i?></li>--}}
        {{--    @endfor--}}

        {{--Muutujad saab markeerida "{{ X }}" hoopis--}}
        @for($i = 0; $i<10; $i++)
            <li>{{$i}}</li>
        @endfor

        ````

    6) Laravellil on VÄGA hea dokumentatsioon. The Basics tasub läbi lugeda.

    7) Tutvuda sellega https://laravel.com/docs/10.x/blade ja sellega https://laracasts.com/series/laravel-8-from-scratch - kodutöö
    



</details>