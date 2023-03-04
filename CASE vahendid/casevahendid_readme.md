# CASE (Computer-aided software engineering) vahendid tundide märkmed

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

***

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
  
