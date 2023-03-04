# Versioonihaldusealused

Õppejõud: Kaspar Martin Suursalu

## Kodutööd
- Vaata see läbi: https://www.youtube.com/watch?v=qpdYRPL3SVE
- Ülesanne: 1) tee uus giti projekt 2) loo mingi fail 3) tee seal failis muudatus ja niivisi iga päev kuuaega järjest 4) ja iga nädalavahetus (uuel esmaspäeval) tee uus branch ja järgmise nädala commitid teete kõik sinna branchi 5) kuuaega hiljem on teil githubis kena repository (4-5 branchi) 6) igas branchis 7 commiti enamasti

## Ressursid
- https://www.asciitable.com/
- https://www.compart.com/en/unicode
- Käskude ülevaade: https://builtin.com/data-science/bash-commands
- Linuxi Distributions (eelseadistatud Linuxi installatsioonid): https://www.puttygen.com/linux-distros (Kaspari soovitus Elementary OS)
- markdownguide.org/cheat-sheet/ + markdownguide.org/baisc-syntax/ + https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet
- **17.02.2023 märkmed osas kirjas veidi rohkem juttu merge conflictidest**

## Programmid
- Windows Terminal
- Git
  - Git Bash on Bosix compliant

## Levinud käsud
**Liikumine**
- `cd` + argument = change directory, kataloogidesse sisse liikumiseks, siinjuures ntks:
  -  `cd Downloads` on relatiivne liikumine (ainult sõlutvalt hetke kaustast/"auskohast")
  -  `cd C://Users/u-469/Downloads` on absoluutne liikumine (kust iganes, kuhu iganes)
  -  tühjalt, s.t. ilma argumendita toob `cd` gitBashis sind tagasi user kausta, kust iganes
- `ls` = list, näitab mis sisaldub hetke kataloogis (windowsis töötab samaks asjaks ka `dir`)
- `--help` = pea iga käskluse järgi toob välja võimalikud lipukesed antud käsklusele ja võimalikud argumendid, näiteks `ls --help`. Lipukesi on kahte tüüpi:
  - pikad, mis algavad `--` ja on välja kirjutatud, näiteks `ls --all`
  - lühendid, mis algavad `-` ja on ühe tähelised ning suuruse tundlikud (teevad seejuures sama asja), näiteks `ls -a`
- ![image](https://user-images.githubusercontent.com/115208151/216589697-6964a003-9864-41c4-a88a-dd998f46e01f.png)
  - `./` viitab kõikidele eelnevatele kataloogidele
  - `../` viitab eelnevale kataloogile, näiteks võimalik liikuda tagasi kasutades `cd ..`
- Üles, alla nooltega käsureal on võimalik liikuda varasemate käskluste vahel
- `pwd` annab välja täispika asukoha, kus sa parasjagu oled

**Kaustade haldus**
- `mkdir` + argument(name) = make directory, loo kataloog praegusesse kataloogi, seejuures (head praktikad):
  - kasuta väikseid tähti
  - tühikute asemel _ (tühikud unusta ära)
    - Kui ilmtingimata tarvis, siis kasuta "folder cool"
  - kirjastiilid (huvitav teada):
    - camelCase, väikese alguse tähega algav, kõik ülejäänud sõnad suured
    - snake_case, eraldatud kõik sõnad alamkriipsuga, kõik väikeste tähtedega
    - StudlyCaps, kõik sõnad suure tähega, kokkukirjutatud
  - kuidas vältida kirjavigu? Kirjutage võimalikult vähe, näiteks:
    - kirjutan `cd` ja ühe tähe D klõpsin tabi (üritab auto completeda), toob välja sobivad
    - lisan tähti, toob lähemale ja niivisi kuni jõuab ainult üheni, mis sobib, kuid kirjavigu vähem
    - näidis: ![image](https://user-images.githubusercontent.com/115208151/216592318-e66af503-1b98-4e6c-8b16-a37ed750bceb.png)

**Failide haldus**
- `touch` + argument = loob faili, ntks: `touch hello.txt` | failid pmst jaotuvad kaheks, teksti failid - mõeldud tekstiga tõlgendamiseks, ja binaarsed failid - ei ole mõeldud tekstifailiga tõlgendamiseks
- `mv` 
  - + argument (faili, kataloogi nimi) + argument (faili, kataloogi uus nimi) = move, antud kujul liigutab faili samasse kataloogi ja nimetab selle ümber (algne fail kaob ära)
  - `mv` + argument (faili, kataloogi nimi) ja argument (sihtkoht) liigutab faili
- `cp` 
  - + argument (faili, kataloogi nimi) + argument (faili, kataloogi uus nimi) = copy paste, kopeerib uue nimega faili samasse kausta, kuid algne fail jääb ka alles
  - + argument (faili, kataloogi nimi) ja argument (sihtkoht) kopeerib faili sihtkohta faili
- `rm` = remove, eemaldab sihi täielikult ja kohe **väga hoolikalt tuleb kasutada**, s.t. et faili kõvaketta ruum lubatakse vabaks ja mingi hetk see kirjutatakse üle
  - `rm hello.txt` eemaldab faili "hello.txt"
  -  `rm -r learnterminal` eemaldab kataloogi "learnterminal"
  -  `rm -rf` sõidab üle sisuliselt kõik küsimused ja kustutab kõik, mis ta ketta saab / võimalik maha võtta kogu C ketas **eriliselt ohtlik kui ei tea, mida ja miks teed**
- `cat` + argument = trükib välja faili sisu (tirib välja kogu sisu)
- `less` + options + argument = trükib välja limiteeritud pikkuses sisu

**GITi käsud**
- `git init` - loo tühi git repositoorium hetke kausta
-  `code .` - avab visual studio code (või mis igane IDE sul gitiga installimisel lisatud sai)
-  `git status` - näitab ära praeguse olukorra seisu (see töötab alati, isegi kui graafiline liides peaks lolliks minema), järgnev näidiseks:
```javascript
$ git status
On branch main //näitab ära praeguse branchi

No commits yet //ühtegi commiti pole tehtud 

Untracked files: //näitab, mis faile veel ei ole reposse sisse arvestatud
  (use "git add <file>..." to include in what will be committed)
        readme.md

nothing added to commit but untracked files present (use "git add" to track) //koht, kus git toob sulle tihtilugu nö. spikri ette
```

- `git add <filename>` - lisab faili mida nimetad committi (staging)
  - `git rm --cached <filename>` eemaldab faili commitist (from staging)
  - `*.<filetype>` naiteks `*.md` - lisab kõik konkreetse lõpuga failid
  - `git add .` - lisab kõik failid konkreetses alamkataloogis
  - `git add --all` - lisab kõik failid olenemata, kus alamkataloogis, me oleme
- `git commit` - lisab kõik seni stagetud failid (git add)
- `git commit -m "<commiti selgitav kommentaar/sõnum>` - lisab kõik seni stagetud failid (git add), koos kommentaariga
- `git config --global user.name "<username>"` - autoriseerimise tarbeks kasutajanime seadistamine
- `git config --global user.email "<e-mail>"` - autoriseerimise tarbeks e-maili seadistamine
- `git log` - annab infot, mis commitid on tehtud ja kus sa hetkel asud
- `git clone <repo link> <optional: kaust kuhu taha selle luua>` - kloneerib repo arvutisse
- `git push` lükkab asju ülesse ja `git pull` tirib neid repost alla
- `git branch` - näitab meile, mis branchid meil olemas on
- `git branch <branchinimi>` - loob uue branchi (see ei liiguta sind veel sinna branch) **PS! See ei lisa antud branchi GitHubi, see tuleb eraldi pushida olles konkreetses branchis.**
  - Uue branchi pushimiseks on käsk `git push --set-upstream origin <branchinimi>`
- `git checkout <branchinimi>` - vahetab branchi vastavalt nimetatud branchile
- `git merge <branchinimi>` - ühendab olemasolevasse branchi märgitud branchi

***

<details>
  <summary>17.02.2023 märkmed</summary>
  
- committist võib mõelda justkui save game-st enda koodile (enne staging)
- default editori muutmine käsurealt - https://docs.github.com/en/get-started/getting-started-with-git/associating-text-editors-with-git
- "init commit" on traditsiooniliselt initsialiseeriv (s.t. esimene) commit
- Kuidas käsurealt vaadata eelmist commit seisu?:
  - Vaatamiseks: `git log` võta sealt commit hash `git checkout <hash>` ja tagasi saab käsuga `git checkout main`
- visual studio codes pluginate all on "Git Lens" ja "Git Blame" üsna asjalikud pluginad
- giti ühendamine:
  - lood gitis repo (ühtegi täiendavat valikut ei tee)
  - siis git annab ise käsud ette (vaata alla):
  
```
git remote add origin git@github.com:kennethmuuli/learngit_versioonihaldus.git
git branch -M main
git push -u origin main
```

- ole ettevaatlik kui SSH juba püsti seatud. Kui algne git remote läheb valesti siis sellega annab üle kirjutada `git remote set-url origin <https link>`
- "branch" on just kui koopia sinu save gamest, kasutades sama analoogiat edasi
- "Actionid" on sisuliselt variant jooksutada koos commitidega erinevaid programme
  
**MERGE CONFLICT**

Merge konflikti on näha ka logist, näitab headis ainult ühte sulle:
```
  commit 0fdfbd86be9ae9cf375504462ec6d6a1c1e2143e (HEAD -> cool_branch)
Author: Kenneth Muuli <kenneth.muuli@gmail.com>
Date:   Fri Feb 17 16:51:56 2023 +0200

    cool_branch teine muudatus

commit 227295e9872acc2438f8b0bab83b760eb18a4a23 (origin/main, origin/cool_branch)
Author: Kenneth Muuli <kenneth.muuli@gmail.com>
Date:   Fri Feb 17 16:33:19 2023 +0200

    Added a change to cool_branch
```

Pilt visual studios (valikud ühe või teise branchi muutus õige, mõlemad õiged, või kirjuta üldse uued):
  ![image](https://user-images.githubusercontent.com/115208151/219688676-1983abc4-d45f-446f-820a-189bc0af2037.png)

Seejuures üldiselt niivisi asju ei mergeta kokku. Mis tavaliselt tehakse on, et lahendatakse branchil probleemid enne ära ja siis tehakse merge. Selle nimi on **Rebase**
  
`git add --patch` näitab mis muutus `?` näitab selle võimalusi

![image](https://user-images.githubusercontent.com/115208151/219692340-e055b8d1-bea6-479b-bb58-734d4cecfa96.png)

`git rebase <branchinimi>` - kust tahad rebase teha?
  
`git rebase --continue` võimaldab üks haaval käia läbi vigade ja teha vajalikud muutused
  
`git rebase --interactive` või `git rebase -i main` võimaldab teha muutuseid branchile enne commitimist, näiteks kui tead, et kõik okei aga tahad midagi muuta
  
**Git rebase mõte on asjas selles, et näpukaid ja kõike selliseid asju saab teha varasemas commitis.**
  
</details>

***

<details>
  <summary>03.02.2023 märkmed</summary>
  
### 03.02.2023
**MIKS KASUTADA LINUXIT, MÕNED PÕHJUSED:**
*Soovitan võtta Linuxi võtta kasutusele võimalikult varakult, kui soov arendajana karjääri teha.*
- Maailmas on tegelikult kõige rohkem Linuxi masinaid (serverid)
- Android on Linux
- Linuxis kõige suurem tarkvara arendajate tugi
- Linuxi käsurida kõige enam levinud
- PS! GitBash emuleerib suuresti Linuxi käsurida

**GIT BASH**

![image](https://user-images.githubusercontent.com/115208151/216586861-aeb2fad5-7bd6-4250-868b-12256cbeac89.png)

`u-469@T238-24 MINGW64` kasutajanimi - arvutinimi - emulaatorinimi

`~` = kasutajakataloog
</details>
