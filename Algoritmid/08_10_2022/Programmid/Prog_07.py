# while(True):
#     mitu=int(input("Mitut arvu soovid võrrelda (sisesta arvuna) "))
#     if (mitu>0):
#         break

mitu = 0
while(mitu<=0):
    mitu=int(input("Mitut arvu soovid võrrelda (sisesta arvuna) "))
    
#üleval do while asendus süntaksite variandid Pythonis

loendur=1

while (loendur <=mitu):
    arv=int(input("Sisesta võrreldav arv " + str(loendur) + " "))
#jälgi ülal olevat süntaksit stringi ja inti liitmisel üheks tekstiks

    if (loendur==1):
        maksimum=arv
    elif (arv>maksimum):
            maksimum = arv
    loendur+=1

print("Maksimum = ",maksimum)
