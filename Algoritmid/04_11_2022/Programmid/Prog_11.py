#Fibonacci jada massiiviga
k=int(input("Fibbonaci jada suurus "))

#k+1, sest 0-st 10-ni on 11 elementi
fib=[0] * (k+1)
#pane tahele "massiivi" deklareerimise syntaxit, massiivi kui sellist pythonis pole, on ainult jarjend

fib[0]=0
fib[1]=1

for i in range(2,k+1):
    fib[i] = fib[i-1] + fib[i-2]
for i in range(0,k+1):
    print(str(fib[i]), end=', ')
#alt print(fib) naitab kogu massivi eraldatult voi print(*fib), naitab ainult vaartuseid massiivis