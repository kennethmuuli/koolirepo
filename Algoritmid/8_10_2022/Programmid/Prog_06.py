arv=int(input("Sisesta esimene arv "))

maksimum=arv
loendur=2

while (loendur <=5):
    arv=int(input("Sisesta järgmine arv "))
    if (arv>maksimum):
        maksimum = arv
    loendur+=1

print("Maksimum = ",maksimum)
    
#maksimumi väljatoomine lühendatud kujul
# maksimum = max(arv1,arv2)
# print("Maksimum on ", maksimum)