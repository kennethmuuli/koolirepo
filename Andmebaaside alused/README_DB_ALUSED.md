# ANDMEBAASIDE ALUSED MÄRKMED

## Keeled
- SQL

## Ressursid
- PDFid siin kaustas: https://drive.google.com/drive/folders/1mgzmUqM1HryYkzz8Ttcyuzkb20qChWYb?usp=share_link

## Programmid
- Microsoft Access
- Opilane path: `\\tptlive\avalik\B307\AN_B307`

## Märkmed:
**Andmetüübid**

<details>
  <summary>Autonumber</summary>
  
  - Primary key: "A primary key is a field or set of fields with values that are unique throughout a table. Values of the     key can be used to refer to entire records, because each record has a different value for the key. Each table can only     have one primary key." S.t. indeks.
  - Andmebaasis kasutada (field name ja data type) ainult ladina tähti, numbreid, alakriipsud ja tühikud on kasutatavad.     Muud märgid lastakse läbi kui tekitab probleeme töötamisel hiljem.
  - Arvude andmetüübid:
    - Byte: täisnumber, väärtused = 0-255
    - Integer: täisnumber, väärtused <= 32000
    - Long Integer (AutoNumber): täisnumber, väärtused <= circa 2 miljardit
  
</details>

<details>
  <summary>Text</summary>
  
  Mask: võimaldab välja sisestusi piirata, näiteks # = ainult numbrid
  
</details>

<details>
  <summary>Date/Time</summary>
  
  Aega hoitakse "double" formaadis ja ainult reaalarvudena.
  Default valuesse võib sisestada ka funktsioone, näiteks 'now()'
  
</details>

<details>
  <summary>Currency</summary>
  
  Kui format on "currency" siis see tähis sõltub regionist. Tasub panna pigem konkreetne currency.
  
</details>


- Kui andmete sisestamisel jääb sisestus poolikuks, a la mõni kohustuslik välja täitmata ja andmebaas pannakse kinni siis primary key e. indeksi number hüppab sellest üle, näiteks 3 jääb tühjaks ja 4 on järgmine.

## Tunnid
###18_11_2022
Läbitud lehed Linntamm õpikust: 
