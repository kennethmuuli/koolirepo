# CASE (Computer-aided software engineering) vahendid tundide märkmed

## Hindamiseks
- Panna püsti samasugune to-do app nagu tegime Sveltes AGA teises raamistikus
- ntks Vite -> git init -> eemaldage demo kood, puhas plats -> uus commit -> ja siis jätkake

## Ressursid
- bash profile set up - https://phoenixnap.com/kb/change-bash-prompt-linux
  - Starship (https://starship.rs/guide/#%F0%9F%9A%80-installation)
- moned kasurea installi tooriistad:
  - Scoop (scoop.sh) / vaiksem ja lihtsam
  - Chocolatey (https://chocolatey.org/install) / suurem ja rohkem tarkvara sees
- thefuck commandline autocorrect, Googleda (Python ja pip vajalikud)
- npm - https://www.npmjs.com/ - veebiarenduse paketid?
- visual studio codes live preview, et naha lives enda htmli
- Kui panna ykskoik mis tehnoloogia nimetuse ja juurde "awesome list" saab katte kohe hunniku vaga vaartuslike ressursse, tuleb GITi link valja
- Vite, üks parimaid CASE vahendite automatiseerimise tööriist
- Tasuta tööriistu veel õpilasele: https://www.jetbrains.com/shop/eform/students
- Väga asjalik ressurss ühelt keelelt teisele hüppamiseks: https://learnxinyminutes.com/

***

<details>
  <Summary>30/3/2023</Summary>

  1) Veidi juttu routeritest, raamistikel enda omad. Vue.js-enda oma, Sveltel enda oma jne. Mõte neil on teha lehtede vahel navigatsioon, kuigi tegelikult on tegemist ikkagist ühe HTMLiga.
    - näiteks: https://router.vuejs.org/ + https://kit.svelte.dev/docs/routing jne.
    - neid nimetatakse tihitpeale "single-page" applicationiks, mitte disainist vaid tagatoast tuleb see sõna.
    - PROS:
      - aeglase netiühenduse korral, kuna kõik laetakse korraga sisse siis sirvimise kogemus on palju kiirem -> laetakse ainult sisu.
    - CONS:
      - kui vaadata allikat (source) siis tekib probleeme SEO-ga, kuna enamus leheküljest laetakse hiljem, s.t. põhi sisu pole algses lähtekoodis (mis brauserile saadetakse).
      - seni robotid ei vaata JavaScripti, vaatavad vaid HTMLi -> ilmselt on see tasapisi muutumas
  2) State Management, sisuliselt on see justkui ideoloogia. 
    - Probleem: Costum eventide kinni püüdmine olukorras, kus komponendid on üksteise sisse pakitud/peidetud (näide oli: sidepanel, profile, gravatar, gravatar edit modal).
    - Selle vastu ongi loodud state management, mille iva seisneb sellest, et lehe seisu hoitakse tervikuna ühes kohas.
    - State Management/Arhitektuuri mustrid: Flux, Vuex jne
    - Rohkem infot: https://vueschool.io/lessons/introduction-to-pinia?friend=vuerouter&utm_source=pinia&utm_medium=link&utm_campaign=homepage
  3) Keeled (https://en.wikipedia.org/wiki/C_(programming_language))
    - KLASSIKUD:
      - C keel mõistlik käsile võtta, öeldakse, et see on kõige aluseks. Väga lähedane riistavara ja kõrgelt optimiseeritav.
      - Assembly keeled (sellest järgmine binaarne), üldiselt super keeruline, mugavusi pole, kuid otsene kontroll protsessori töö üle.
      - C++ https://en.wikipedia.org/wiki/C%2B%2B, meeletult efektiivne ja lubab täielikult kontrollida mälu ja riistvara. Mängu maailma ajaloolin keel.
      - Mille järgi keeli klassifitseeritakse?
        - Kas muutujatele tuleb tüüp ette anda? (näiteks JS ei nõua, C# nõuab), strong typing vs weak typing
        - Alternatiiv objekt orienteeritusele on protseduaalsed keeled 
        - Kompileeritud, näiteks C ja C++ (ei eelda midagi ette, valmis raual jooksma nö.) või interpreteeritud keel, näiteks Javascript (keel tuleb eelnevalt alla installeerida, muidu see ei tööta)
      - C#, Microsofti loodud keel, mis võtab veidi malli C-st ja C++-ist, kuid see on täielikult objekt orienteeritud - uuemad versioonid lubavad ka cross-platform asju teha
        - vähem efektiivne kui C ja C++
        - vahepeal tekkis lõhe, dotNet Framwork (Windowsile) ja dotNet Core (cross-platform) - kuid see suuresti nüüdseks lahenenud
      - Java (sealt varastas Microsoft palju oma koodist), C#-ga peaaega vahetatav loogika poolest, oskad ühte, oskad teist.
        - 2000 oli väga populaarne
        - jookseb kõikidel OSidel (Java virtuaalmasina abiga), peamine selling point, kuid tänaseks see tava parktika ja see edu suuresti kadunud - probleem aga sellest, et see virtuaalmasin pole kunagi sama efektiivne, ta on aeglasem
        - corpodele meeldib asjaolu, et nende käest saab osta supporti (haldust, tööriistu jne)
      - JavaScript
      - PHP (pole enam tegelikult ainult skriptimise keel)
        - PHP on mõeldud kaheks asjaks, veebilehtede tegemiseks ja käsurea programmide tegemiseks (desktop, mobiilsed aplikatsioonid ja mängud kõik suht no go)
        - alates v5-st sai sellest korralik programmeerimiskeel, mis v7-v8-ga oluliselt parandas ka kiirust ja funktsionaalsust
        - veebi teeb see väga hästi
      - Ruby (Ruby on Rails on veebiraamistik Ruby peal)
        - Oli kunagi populaarne, enam mitte
        - Peamiselt arendus ülesanneteks kasutamisel
        - Rubyst on pärit kõva tarkvara testimine (alguse saanud sealt)
      - Python
        - Korralik keel, polegi midagi öelda
        - Üks populaarsemaid ja levinumaid keeli, seda on lihtne õppida
        - Objekt orienteeritud keel, kompileeritud
        - Sellega annab suht mida iganes teha, kuid peamiselt kasutatakse andmete protsessimiseks ja arvutusteks, tänapäeval näiteks AI neural networkide tarbeks kasutatakse tihti seda
    - UUED KEELED:
      - Rust, mis tahab C++ tahab asendama hakata (Linuxi Kernelile isegi tehtud sellega esimesi tükke)
        - Memory safe ja thread safe - kui asju õigesti teha siis pole võimalik teha memory leak buge ega data erase
        - Võimas ja kiire (C++ ja C-st kiirem isegi mitmetel juhtudel) ning see läheb progejatele päris hästi peale
        - Samas see ei ole lihtne keel, mida õppida, kuid see on väga hästi dokumenteeritud
        - Justkui objekt orienteeritud, kuid inheritance puudub.
      - Golang, eesmärk oli maksimaalselt ära kasutada mitmetuumalisi protsessoreid kui viimased turule ilmusid
      - Swift, Apple progemiskeel, enne swifti nad kasutasid Objective-C-d (edasiarendus eelmisest)
      - Kotlin, Java alternatiiv (JetBrainsi loodud) ja jooksebki Java virtuaalmasinal, uuendus Javale
      - Zig, tahab asendada täielikult C-d ja C++i, väidetavalt meeletult kiire isegi võrreldes C, C++ ja Rustiga. Sellest on vähe olnud kuulda, kuna see pole veel ametlikult välja lastud.
      - Carbon, üritab asendada C++ konkreetselt
  4) Naltsi kah, esoteerilised keeled:
    - https://en.wikipedia.org/wiki/Esoteric_programming_language
    - https://esolangs.org/wiki/Main_Page
    - vigil, trumpscript, befunghe 93 jne

</details>

<details>
  <Summary>17/3/2023</Summary>
  
  1) Svelte dev tools (googleda) - see lisab plugin, mis on developer toolide tarbeks. Peale installi tekib lisa tool inspecti alla "Svelte". image.png
  2) Hea JS artikkel koodi lihtustamisest - https://medium.com/poka-techblog/simplify-your-javascript-use-map-reduce-and-filter-bd02c593cc2d
  3) Static hosting, netlify / surge
    - Tegime hosting surge-ga (https://surge.sh/)
    - Commands:
      - `npm install surge`, veebis `npm install --global surge` aga me panime lokaalselt ainult ühele projektile külge
      - `npx surge` sisse logimiseks ja alustamiseks (esimene kord palus teha logini)
      - ülesse seadmisel esimene kord vaata üle ka faili path (küsib setupis), oluline, et suunad ta kausta, kus su HTML ja assetid (meil oli "dist" kaust naiteks)
      - lõime ka `npm run deploy` käsu ja sisuks sai `"deploy": "npm run build && surge ./dist tenuous-knot.surge.sh"`
      - surge dokumentatsioon: https://surge.sh/help/
    - Lõime modali komponendi ja listi komponendid


  </details>

<details>
  <Summary>3/3/2023</Summary>

Tööriistade kasutamine:
1) Varem task runnerid, tehnoloogiad, mis aitavad kasutada teisi tööriistu, sisuliselt automatiseerimise tööriist.
2) Siis tuli webpack, mis oli nö. ette kokku pandud tööriistade süsteem. Keeruline ja nõuab palju konfigureerimist eelnevalt.
3) Uuemad tööriistade süsteemid nagu näiteks Parcel, on läinud sisuliselt 0 konfiguratsiooni peale. Häda aga on selles, et kui sa tahaksid, midagi ümber konfigureerida, siis selle saavutamine on väga keeruline. Tihtilugu nõuab eraldi pluginate loomist selle tarbeks.
4) Kõige populaarsem praegu on Vite. Sarnaselt Parcelile on see madala konfiguratsiooni vajadusega out of the package AGA kui tarvis konfigureerida siis sellega on seda võimalik üsna lihtsalt teha. https://vitejs.dev/guide/

Vite & Svelte
  - package.jsonis näha mõned sisse ehitatud käsud
  - natukene javaScriptist: https://github.com/Kasparsu/kta22elearnsvelte
    - `npm i -D sass` -D lisab selle devDependencies hulka repos
  - BULMA CDN ehk Content Delivery Network, sisuliselt on see veebileht, kuhu on failid ylesse pandud AGA
    - Server, kus need asuvad on ylesse pandud igale poole maailma. Sisule juurepaasu soovides vaadatakse, kust maailmast poordumine tuleb ja yhendutakse lahimasse serverisse.
    - CDN jatab ka meelde, millise failiga CSS laeti, mis tahendab, et algne lehe laadimine on veidi aeglasem aga kogu ylejaanud sess ja laadimised on praegu kiirem, kuna taiendavaid laadimisi toimub vahem
    - NPMiga seda tehes on samas eeliseks, et koik kasutamata osad jaetakse buildist valja, s.t. et kogu rakendus ise on potentsiaalselt palju vaiksem kui kasutuses vahe osiseid
  - Kui IDE ei tunnista mingit koodi siis tavaliselt extension puudu, app.sveltei CSSi kirjutamiseks naiteks oli vaja "Svelte for VS Code" pluginat.
  
  
</details>
  

<details>
  <Summary>2/18/2023</Summary>

* https://en.wikipedia.org/wiki/Computer-aided_software_engineering
* IDE ehk integrated development environment
* bash profile (avamiseks, voi loomiseks kui see puudub `code ~/.bash_profile ` voimaldab seadistada personaalseid eelistusi gitile:
  - naiteks, kust algab pihta navigatsioon
  - seal seab seadistada ka enda kombinatsioon k2skude lyhendieid, naiteks: `la ="ls -la"`
  - moistlik endale alati pysti panna git fire k2su lyhend. **Googleda**
    - alternatiiviks ka ette seadistatud profiilid, naiteks starship https://starship.rs/guide/#%F0%9F%9A%80-installation
* `winget search <whattosearch, e.g. pyhton>` - kasulik ja self-explanatory käsk (ilmselt töötab ka teistel package manageridel)
* edit system environment variables > environment variables > path (kui tarvis pathe ise sisse kirjutada)
* juttu veebimaailmas:
  - kogu see maailm istub html, css ja javascripti (a.k.a ECMAScript) peal, seejuures **Java ja Javascript on kaks taiesti erinevat asja, ainus seos on neil nimes ja molemad on OOP keeled**
  - nendega on labiv probleem, asjaolus, et alustaladena on neid ysna keeruline muuta (mitte, et muutuseid ei tehtaks) aga reeglina kulub brauseritel vaga pikalt aega, et neid uuendusi toetama hakata
  - html ja css on ysna featuuride vaesed ning nendega "lahedamaid" asju teha ei saa. Seetottu on tekkinud terve hulk "pre-processed" (nimetus tuleneb asjaolust, et veebibrauseid ei oska nendega midagi teha, need nouavad eraldi tooriista, mis tolgendab source faili yheks cssiks ymber) keeli nagu naiteks "Sass/scss", "lesscss", "stylus", "postcss" jne.
  - javascriptil on seevastu olemas hoopis templating keeled, naiteks "Nunjucks", "mustache.js"
  - emmet on yldlevinud plugin htmli kirjutamiseks, vaga asjalik kui endale selgeks teha.
  - node on programm, mis voimaldab arvutis jooksutada javascripti ilma brauserita
  
**Veebirakenduste arenduse kuld**
Emmeti käsud:
  
- `!` empty boilerplate + Tabiga saab algsel genemisel selle pohimuutujad kohe labi hypata ja muuta
- `lorem<number>*<number>` annab numbriga märgitud sõnade arvu x numbriga märgitud ridadel (empty on lihtsalt 30 sona)
- `div{}*<number>` loob {tekstiga} x arvu dive
- `div.<klassinimi>` loob klassiga divid
- `div#<id nimetus` loob # idga divid
               
Raamistikud ja keeled:
- CSS Raamistikud, naiteks: tailwindcss (+daisyui), bootstrap - need pakkuvad etteloodud klasse, millega on voimalik asju juhtida
- Javascripti tegemiseks on asenduseks olemas samuti pre-processed keeled nagu (Coffeescript, mis depracated) ja Typescript (muutujatega), mille mote seisneb selles, et voimaldada muudelt keeltelt yle tulnud arendajatel lihtsamini javascripti (muutujateta) kirjutada. Seejuures Typescriptil on tegelikult tanaseks olemas ka oma kompilaator, seega see pole tegelikult enam paris pre-processed keel.
- Omaette on javascripti raamistikud:
  - top 3: 
    - Angluar.js (iganenud aga laialt veel kasutuses);
    - React.js (hetkel koige levinum ja populaarsem);
    - Vue.js;
  - ja ustulnukad:
    - Svelte.js (sarnane Vue-le, ei pane enda source koodi kaasa vaid tolgendab selle puhtaks js-iks, seega tulemus on palju ohem);
    - Solid.js (sarnane Reactile, muidu mote sama nagu Svelte.js-il kuid teine asi vorreldes Sveltega on see meeletult kiire);

</details>
  
