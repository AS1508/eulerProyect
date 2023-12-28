const int maximo = 1000;
int total = 0;

for(int i = 0; i<maximo; i++){
    if(i%3 == 0 || i%5 == 0){
        total += i;
    }
}

Console.WriteLine($">> {total}");