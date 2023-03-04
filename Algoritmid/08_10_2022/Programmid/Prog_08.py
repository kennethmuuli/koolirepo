esimene=-8
samm=3
mitu=6
summa=0
arv=esimene

for i in range (1,mitu+1):
    if(i==1 or arv<0):
        print(arv, end="")
        #jälgi süntaksit rea jätkamiseks
    else:
        print("+"+str(arv), end="")
    summa+=arv
    arv+=samm
    
print ("="+str(summa))