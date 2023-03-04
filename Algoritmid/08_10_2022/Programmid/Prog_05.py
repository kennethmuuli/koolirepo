arv1=int(input("Sisesta esimene arv "))
arv2=int(input("Sisesta teine arv "))
arv3=int(input("Sisesta teine arv "))

maksimum=arv1

if (arv2>maksimum):
    maksimum = arv2
elif (arv3>maksimum):
    maksimum = arv3

print("Maksimum = ",maksimum)
    
#maksimumi väljatoomine lühendatud kujul
# maksimum = max(arv1,arv2)
# print("Maksimum on ", maksimum)