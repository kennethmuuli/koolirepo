arv1=int(input("Sisesta esimene arv "))
arv2=int(input("Sisesta teine arv "))
arv3=int(input("Sisesta teine arv "))

if (arv1>=arv2 and arv1>=arv3):
    maksimum = arv1
elif (arv2>=arv3):
    maksimum = arv2
else:
    maksimum = arv3
print("Maksimum = ",maksimum)
    
#maksimumi väljatoomine lühendatud kujul
# maksimum = max(arv1,arv2)
# print("Maksimum on ", maksimum)