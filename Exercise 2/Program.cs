//Exercise::By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
const double maximo = 4000000;
double fibonacci = 0, fibonacciSuma = 0;
double n1 = 0, n2 = 1;

while(fibonacciSuma < maximo){
    fibonacci = n1 + n2;
    if(fibonacci%2 == 0){
        fibonacciSuma += fibonacci;
        n1 = n2;
        n2 = fibonacci;
    }else{
        n1 = n2;
        n2 = fibonacci;
    }
}

Console.WriteLine($">> {fibonacciSuma}");