arv1=int(input("Sisesta esimene arv "))
arv2=int(input("Sisesta teine arv "))

#jälgi IF lause süntaksit, oluline bloki alguse märkimine ":" (sama ka ELSE lause puhul)
#pythonile vajalik on, "if arv1>arv2:" ,kuid harjumuse tekitamiseks kirjutada sulud siiski sisse
# if (arv1>arv2):
#     print("Esimene arv on suurem.")
# else:
#     if (arv2>arv1):
#         print("Teine arv on suurem.")
#     else:
#         print("Arvud on võrdsed.")

#eelnev skript lihtsustatud kujul (ELSE + IF = ELIF)
#+ lisatud maksimumi välja toomine, kuna tingimused on samad (tehniliselt saab need kokku panna all oleva kujul)
if (arv1>arv2):
    print("Esimene arv on suurem.")
#     print("Maksimum on ", arv1)
elif (arv2>arv1):
    print("Teine arv on suurem.")
#     print("Maksimum on ", arv2)
else: 
    print("Arvud on võrdsed.")
#     print("Maksimum on ", arv1)

#maksimum välja toodud eraldi, et olla vastavuses algoritmiga
if (arv1>=arv2):
    maksimum = arv1  
else:
    maksimum = arv2
print("Maksimum = ",maksimum)
    
#maksimumi väljatoomine lühendatud kujul
# maksimum = max(arv1,arv2)
# print("Maksimum on ", maksimum)