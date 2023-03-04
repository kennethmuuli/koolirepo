#selle asemel, et kirjutada kahel real
    #print("Sisesta esimene arv ")
    #arv=input()
    #kirjutame hoopis (järgmine rida)
arv1=int(input("Sisesta esimene arv "))
arv2=int(input("Sisesta teine arv "))
arv3=arv1+arv2
#arv3 kandub int tüüp üle, kuna selle sisu tekib kahest intist, seda pole vaja eraldi deklareerida
print("Summa = ",arv3)
#üks alternatiiv eelneva summa kirjutamisele ja kuvamisele)
print(arv1, " + ", arv2, " = ", arv1+arv2)

print(arv1, " - ", arv2, " = ", arv1-arv2)

print(arv1, " x ", arv2, " = ", arv1*arv2)

print(arv1, " : ", arv2, " = ", arv1/arv2)

print(arv1, " jagatud täisarvudena ", arv2, "-ga = ", arv1//arv2)
#pane tähele täisjagamise süntaksit
print(arv1, " jagatud reaalarvudena (Jääk) ", arv2, "-ga = ", arv1%arv2)
#pane tähele reaalarvudena jagamise süntaksit
print(arv1, " astmes ", arv2, " = ", arv1**arv2)
#pane tähele astendamise süntaksit