#Deklareerin funktsiooni
def ajada(e,s,n):
    arv=e
    for i in range(2,n+1):
        arv=arv+s
    return arv


esimene=int(input("alg --> "))
samm=int(input("alg samm --> "))
mitu=int(input("mitu --> "))
print("\n")

for i in range(1, mitu+1):
#Kasutan eelnevalt deklareeritud funktsiooni "ajada" + argumendid
    print(ajada(esimene,samm,i),end=' ')
print("\n")

#Deklaratsioon > Rekursiivne funktsioon aritmeetilisest jadas
def ajada_R(e,s,n):
    if(n==1):
        return e
    else:
        return ajada_R(e,s,n-1)+s
    
for i in range(1, mitu+1):
    print(ajada_R(esimene,samm,i),end=' ')
print("\n")