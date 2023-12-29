//Exercise::Found the largest prime factor of the number {termninar}
const long numero = 600851475143;
long factor,maximo = 0;
int b = 0;

for(long i = 1; i<numero; i++){
    if(numero%i == 0){
        factor = i;
        if(b == 0 || factor > maximo){
            b = 1;
            maximo = factor;
        }
    }
}

Console.WriteLine($">> {maximo}");