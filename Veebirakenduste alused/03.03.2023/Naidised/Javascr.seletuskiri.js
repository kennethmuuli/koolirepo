// JavaScript Document
JavaScriptis kirjutatud programmi tekst koosneb lausetest ja kommentaaridest. Lausetes võib kasutada muutujaid, avaldisi, operaatoreid, funktsioone, objekte jms. Laused lõpevad semikooloniga. Programmi tekstis ignoreeritakse tühikuid ja tabulaatoreid, nii  et neid võib sinna panna vastavalt vajadusele. JavaScripti tekstis kasutatakse ümar, kandilisi ja loogelisi sulge. Et  mitmesugused JavaScripti abil töödeldavad andmed oleksid veebilehe  laadimisel kohe käepärast, pannakse JavaScripti teks sageli HTML siltide HEAD vahele. Soovi korral saab HTML dokumenti paigutada mitu siltide SCRIPT vahel epandud JavaScripti programmi.

Andmetüübid.
JavaScripti programmides võivad andmetena esineda arvud, stringid ja loogikaväärtused. Lisaks tunneb JavaScript väärtusi null ja määramatus. Stringid on jutumärkide vahele paigutatud märgijadad. Jutumärgid võivad olla ühe- või kahekordsed. Vahel on vaja kasutada kaht jutumärkide komplekti, sellisel juhul koosneb üks komplekt ühe-, teine kahekordsetest jutumärkidest. 
Kursori viimiseks järgmisesse ritta kasutatakse kombinatsiooni \n, kombinatsioone \' ja \" 'vastavalt apostroofi ja jutumärgi jaoks stringis. Arvudena võib kasutada kaheksand-, kümnend- ja kuueteistkümnend- süsteemi arve. Kümnendsüsteemiarvudena saab kasutada täis-ja ujukoma arve näiteks 35 ja 3,5. Nullist väiksemad ujukomaarvud pannakse kirja ilma 0 koma ees näiteks ,9.

Muutujad.
Muutujate nimed peavad JavaScriptis algama tähe, $ või _(allkriipsuga) var
Muutujate juures on oluline nende kehtivuspiirkond-skoop. Globaalseid muutujaid saab kasutada veebilehe kõikides JavaScripti programmides, kohalikke (local) muutujaid ainult selles funktsioonis, milles nad deklareeriti.

Operaatorid e tehtemärgid.
+ - */ 
%-jagamise jäägi leidmine
++ kasvutegur 1 võrra
-- vähendus 1 võrra
- unaarne negatsioon e märgi muutmine.
<> <= >= == !=
Loogiline JA (&&) väljastab väärtuse true, kui mõlemad operandid on tõesed.
Loogiline VÕI (||) väljastab väätuse true, kui 1 operandidest on tõene. Loogiline EI (!) väljastab väärtuse true, kui operand on väär (FALSE). 
Operaator += liidab vasakpoolsele muutujale parempoolse operandi väärtuse.  Analoogilised operaatorid on -=, *= ja /=.
Operaatoreid + ja += kasutatakse veel stringide liitmiseks.

Laused.

Tingimuslaused 
if-else,
switch, 
for-lause (loop) kordab selles olevat käsku nii kaua, kuni selles olev tingimus saab täidetud.
do-while lause kordab lauset nii kaua, kuni selle while tingimus on tõene.

Objekti käsitlemise laused
for...in lauset kasutatakse selles paikneva korralduse rakendamiseks objekti kõikidele omadustele või massiivi kõikidele elementidele.
with lause võimaldab funktsiooni üldistada.

Funktsioonid.

Funktsioonid on lausete grupp, mis viib läbi sellesse koondatud tegevusi.

Massiiv (Array)

on andmeelementide kogum, kus igal andmeelemendil on oma nummerdatud positsioon, numeratsioon algab nullist.

DOM- dokumendi objekti mudel- veebibrauser käsitleb ja jätab meelde HTML-lehe sisumudeli. (DOM on W3C standard)
DOM edastab informatsiooni, mida Javascript vajab veebilehe elementidega suhtlemiseks, DOM laseb Javascriptil suhelda ja muuta lehe HTML-i.
Et JS saaks suhelda lehe sisuga, vajab ta meetodit suhtlemiseks lehe sõlmpunktidega (nodes). Selleks on kaks peamist võimalust:
getElementById() ja getElementsByTagName().

Leidmaks elementi ID põhjal tähendab leida ta unikaalse ID kaudu, mis talle on omistatud.

document.getElementByID('header')  
(otsi sellelt lehelt silti ID-ga 'header'). Sõna dokument lauses document.getElementByID('header') on võtmesõna, mis viitab kogu dokumendile.
 Käsk getElementByID() on meetodi nimi ja 'header' on string ehk ID-nimi, mis on meetodi jaoks argument.
 Tingimata ei pea string olema meetodiga vahetult seotud, võib kasutada muutujaid, mis otsivad ID-d:
 
 var lookFor = 'header';
 var fondNode = document.getElementByID(lookFor);
 
 
getElementsByTagName()
Vahel on vaja tegevus suunata mitmele objektile. Näiteks on vaja leida kõik lingid lehel, mis on adresseeritud lehest väljapoole ja panna nad avanema uues       aknas. Sel juhul on vaja elementide loetelum mitte ühe elemendi ID-d. Käsk  getElementsByTagName() võimaldabki seda. Et leida kõik lingid lehel, sisestatakse:
var pageLinks = document.getElementsByTagName('a'); // otsi selle dokumendi iga <a> tag-i (silti) ja talleta tulemus muutujas pageLinks.
getElementsByTagName() meetod tagastab sõlmpunktide loetelu. Loetelu põhimõte meenutab massiivi; võib saada ligipääsu ühele elemendile kasutades indeksi määrangut, leida elementide koguarvu, kasutades length väärtust, või loop'ida läbi loetelu kasutades for loop'i.

getElementByID() ja getElementsByTagName() võib vajadusel koos kasutada. Võib kasutada kogu dokumendi ulatuses, aga ka mingi konkreetse div sees.
DOM struktuur: parent, child, sibling.  
<html>
<head>
title>A web page</title>
</head>
<body class="home">
<h1 id="header">A headline</h1>
<p> Some <strong> important </strong> text </p>
</body>
</html>

Sisu lisamine lehele.
DOM kasutamine sisu lisamiseks lehele on tüütu töö. See tähendab, et on vaja luua iga sisu sõlmpunkt ja siduda see lehega, näiteks, kui on vaja lisada <div> element mõne teise elemendi ja tekstiga, on vaja iga element eraldi ja seada ta õigesse suhtesse teiste elementidega. Kuid on olemas ka lihtsam meetod: innerHTML väärtus.
 See innerHTML väärtus ei ole DOM''i standartne osa, vaid HTML5-ga seotud osa. Antud juhul: <p> Some <strong> important </strong> text </p>,  <p> siltide jaoks on innerHTML Some <strong> important </strong> text.
 Kood, millega JavaScript käsitseks seda HTML võiks olla selline
 // leia kõikide <p> siltide (tag) loetelu lehel
 var pTags = document.getElementsByTagName('p');
 //leia esimene <p> silt lehel
 var theP = pTags[0];
 alert(theP.innerHTML);
 
 Sellisel juhul muutuja theP esitab esimese paragrahvi sisu, viimane koodirida avab alertboxi, mis näitab koodi selle <p> tagi sees.
 Nii saab ka sõlmpunktide sisu muuta innerHTML-i väärtust kasutades:
 var headLine = document.getElementById('header');
 headLine.innerHTML = 'JavaScript was here!';
 Sellisel juhul vahetub headeri sisu ülaloleva teksti vastu.
 
 DOM-il on puudusi. Sõlmpunktidega vaheline liikumine on aeganõudev protsess, samuti tagide leidmiseks ja käitlemiseks on  kõigest paar eelpoolvaadeldud meetodit. Näiteks, kui on vaja leida tage klassinime alusel, nagu JavaScripti abil loodud  lideshow''s, kus pildid saavad klassinime, pole DOM kõige lihtsam meetod.
 Komplikatsioone tekitab ka see, et peamised veebilehitsejad tõlgitsevad DOM-i erinevalt. (näit. tekstikäsitluses)





 JavaScript Library
 See on kollektsioon päevast-päeva korduvaid koode, mis teevad lihtsaks üldiste lahenduste loomise, asetades juba valmis   funktsioonid lehe koodi.
 Konkreetne näide: jQuery  (http://docs.jquery.com/Downloading_jQuery
Viimane versioon: Current Release
Eelised: väike failisuurus; ei eelda erilisi eelteadmisi Javascripti osas, kasuks tuleb vaid CSS-i tundmine; paljukordselt testitud ja töökindel; lai arendajate võrgustik; tasuta; palju elu lihtsustavaid pluginaid.


Teised libraryd: 
Yahoo User Interface Library (http://developer.yahoo.com/yui/
Prototype (http://www.prototypejs.org/) Orienteeritud DOM kasutamise lihtsustamisele
Dojo Toolkit (http://dojotoolkit.org/) Väga suur kollektsioon väga erinevatele lahendustele
Mootools (http://mootools.net/)
(http://script.aculo.us/) animatsioon jmt.

Et lisada jqery.js fail oma lehele, tuleb päisesse (head) lisada skriptilõik:
<script type="text/javascript" src="js/jquery.js"></script> // eeldusel, et fail asub kaustas js

Selektorid  http://docs.jquery.com/selectors

jQuery suudab suurepäraselt töötada CSS-selektoritega, näiteks h1 selektor, mis rakendab stiili igale <h1> sildile (tag), aga ka klassiselektoriga vastavale klassile.
jQueryga saab valida ühe või rohkem elemente kasutades käsku jQuery object:
$('selector')
Saab kasutada peaaegu kõiki CSS2.1 ja paljusid CSS3 selektoreid, kui luuakse jQuery objekti (isegi juhul kui veebilehitseja ei mõista mõnd CSS 3 selektorit). Näiteks, kui tahate valida tagi ID nimega 'banner', kirjutatakse selline kood:

$('#banner')   # tähendab, et määratlete ID-d.

Kui elemendid on valitud, saab neile määrata tegevusi, näiteks kui tahate muuta HTML-i elemendi sees, võib kirjutada nii:

$('#banner').html('<h1>Javascript was here</h1>');  //chapter 5/selectors.html

ID-selektoridVõib valida iga lehe elemendi, mille puhul on kasutatud ID-d, kasutades jQuery ja CSS ID-selektorit.
Oletame, et lehel on selline HTML:
<p id="message">Special message</p>
Et valida see element, kasutades DOM meetodit, tuleb kirjutada nii:
	var messagePara = document.getElementById('message');
jQuery meetodil kirjutatakse sama sõnum nii:
	var messagePara = $('#message');
Erinevalt DOM meetodist ei kasutata mitte ainult ID nime, vaid kasutatakse ka CSS-i süntaksit defineerimaks ID selektorit ('#message'), # nagu CSS stiilis ID määratlemisel.

jQueryl on ka oma asendusvariant getElementsByTagName() meetodile:
DOM meetod, et valida kõik <a> sildid lehel:
	var linksList = document.getElementsByTagName('a');
jQuery puhul kirjutatakse nii:
	var linksList = $('a');
	
KLASSI SELEKTORID

DOM ei oma sisemist meetodit leida kõiki elemente klassi järgi, mis tegelikult on javaskriptijatele sagedane ülesanne.
Oletame, et eesmärgiks on teha rippmenüü, oletame, et on vaja valida lingid mingi kindla klassinimega; jQuery pakub võimaluse valida kõik elemendid sama klassinimega, kasutades CSS klassi selektorit:
	$('.submenu')  // punkt (period) klassi nime ees.
Näiteks, et peita kõik elemendid klassinimega .submenu, võib kirjutada nii:
	$('.submenu').hide();
	
KEERULISED SELEKTORID	
jQuery võimaldab kasutada ka keerulisi selektoreid täpselt osundamaks valitavatele objektidele.

Kasvavad selektorid (descendent selectors) on osutamaks tagile teise tagi sees, näiteks kui on järjestamata loetelu linkidest ja lisatud ID nimi navBar loetelu <ul> tagile: <ul id="navBar">
jQuery lause $('a') selekteerib kõik <a> tagid lehel. Kui aga soovite valida ainult järjestamata loetelus sisalduvaid linke, näeb keeruline selektor välja selline:
	$('#navBar a');  
	
Lapseselektorid (Child selectors)
Nende sihtmärgiks on sildid, mis on teiste siltide lapsed. Näiteks, et valida <p> silt, mis on <body> elemendi laps, tuleb kirjutada nii: 
	$('body > p')
	
Adjacent siblings (sama taseme vendade (õdede)) selektorid lubavad valida objekti (tag) teise objekti (tag) järel.
Oletame, et teil on loodud nähtamatu objekt, mis ilmub, kui klikite tab'i. HTML-is võib tab olla esitatud heading tag'ina, näiteks <h2> ja nähtamatu objekt on <div> tag, mis järgneb headerile. Et teha see <div> tag nähtavaks, on vaja ta selekteerida, seda on lihtne teha jQuery ja adjacent sibling selektoriga:
	$('h2 + div')  et luua see adjacent sibling selector, lisatakse + kahe selektori vahele, valitakse parempoolne selektor, kuid ainult juhul, kui see on kohe peale vasakut selektorit.
	
Tunnuse selektor (attribute selectors) võimaldab valida objekte teatud atribuutidega ning kontrollida, kas need atribuudid vastavad spetsiifilistele väärtustele. Tunnuse selektoriga võib näiteks leida<img>objektid,millel on alt väärtus võiisegi leida <img> objekt mingi kindla alt tekstilise väärtusega. Või näiteks leida kõik lehel sisalduvad lehest välja adresseeritud lingid ja lisada neile koodi, mis näiteks avaks kõik lingid uuel lehel. Atribuudi selektor lisatakse peale elemendi nime, mille atribuuti valida tahetakse. Näiteks <img> objekti, millel on olemas altatribuut,valimisekstuleb kirjutada kood:
	$('img[alt])'
	
[atribuut] valib elemendid, millele on lisatud HTML-is spetsiifilised atribuudid. Näiteks
	$(a[href]) leiab kõik <a> objektid, millel on href atribuudi väärtus.
	[attribute=value] valib elemendid, millel on eriline atribuut spetsiifilise väärtusega. 
Näiteks, et leida textboxi form''i sees, võib kirjutada sellise koodi:
	$('input[type=text]')
[attributeˇ=value] sobib elementidele selliste atribuutidega, mis algavad spetsiifilise väärtusega. Näiteks kui tahate valida linke, mis osutavad lehelt väljapoole, võib kirjutada sellise koodi:
	$('a[href^=http://]')
või siis leidmaks mailto: linke selline kood:
	$('a[href^=mailto:]')
	
[attribute$=value] sobib elementidele, mille atribuut lõppeb spetsiifilise väärtusega, näiteks suudab see selektor leida linke, mis osutavad pdf-failidele (et lisada JS, mis võivad lisada failile spetsiifilise ikooni või dünaamiliselt luua linke mingitele aadressidele mingite failide allalaadimiseks:
	$('a[href$=.pdf]')
	
[attribute*=value] sobib elementidele, mille atribuudid sisaldavad spetsiifilisi väärtusi kusiganes atribuudi sees, näiteks võib leida iga tüüpi linke, mis osutavad spetsiifilisele veebiaadressile. Näiteks, kuidas leida linke, mis osutavad aadressile missingmanuals.com
	$('a[href*=missingmanuals.com]')
	
See selektor ilmutab paindlikkust leidmaks mitte ainult http://www.missingmanuals.com, vaid ka http://missingmanuals.com ja http://www.missingmanuals.com/library.html-i

jQuery filtrid

jQuery lubab samuti filtreerida kindlate omadustega valimeid. Näiteks:even filter lubab valida iga paarilise elemendi elementide kogumis. samuti võib leida elemente konkreetse sildiga (tag), spetsiifilise tekstiga, varjatud objekte (hidden) ja ka objekte, mis ei sobi spetsiifilisele selektorile. Filtri kasutamiseks lisatakse koolon, millele järgneb filtri nimi, näiteks, et leida iga paariline tabelirida, kirjutatakse jQuery selektor selliselt:
	$('tr:even')  see kood valib iga paarse <tr> objekti. Et kitsendada seda valikut, võib leida tabeli iga paarse rea tabelis näiteks klassinimega striped:
	$('.striped tr:even')
	
Võib kasutada :not() meetodit leidmaks elemente, mis ei vasta selektori tüübile. Näiteks tahate valida kõik <a> elemendid peale nende, mis kuuluvad klassi navButton:
	$('a:not(.navButton)'); 
:not() funktsiooni võib kasutada iga jQuery filtri puhul ja enamiku jQuery selektorite puhul, näiteks iga link, mis ei hakka http://-ga,valitakse näiteks nii:
	$('a:not([href^=http://])')
	
:has() leiab elemendid, missisaldavad teisi selektoreid.Näiteks on vaja leida kõik <li> elemendid, kuid juhul, kui nad sisaldavad <a> elementi:
	$('li:has(a)')
	
:contains() leiab elemendid, mis sisaldavad mingit spetsiifilist teksti, näiteks, et leida iga link, mis ütleb "Click me!", tuleb kirjutada kood:
	$('a:contains(Click Me!)')
	
:hidden leiab kas CSS-iabil,jQuery  funktsiooniga või väljadena peidetud elemendid. (ei kehti CSS invisible väärtuse puhul). Peidetud objekte saab nähtavaks muuta nii:
	$('div:hidden').show();
	
	 
 						   
  */