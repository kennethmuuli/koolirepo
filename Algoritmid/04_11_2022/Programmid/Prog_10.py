#Base case, deklaratsioon
def Fib_jada(n):
    if(n==0):
        return n
    elif (n==1):
        return 1
    else:
        arv1=0
        arv2=1
        for i in range(2,n+1):
            arv3 = arv1 + arv2
            arv1 = arv2
            arv2 = arv3
        return arv3
#Base case, deklaratsiooni lopp

mitu=int(input("mitu --> "))
print("\n")

for i in range(0, mitu+1):
    print(Fib_jada(i),end=' ')
print("\n")

#Recursive case, deklaratsioon
def Fib_jada_R(n):
    if(n==0):
        return n
    elif (n==1):
        return 1
    else:
        return Fib_jada_R(n-2)+Fib_jada_R(n-1)
#Recursive case, deklaratsiooni lopp

for i in range(0, mitu+1):
    print(Fib_jada_R(i),end=' ')
print("\n")
