Console.WriteLine("Hello, World!");

int osszead(int a, int b) {
    return a+b;
}

Console.WriteLine(osszead(2, 3));

double SecToMin(int sec) {
    return(sec/60.0);
}

Console.WriteLine(SecToMin(90));

void Hello (string nev, int kor) {
    Console.WriteLine($"szia {nev}, {kor} éves vagy");
}

Hello("andrás", 1);