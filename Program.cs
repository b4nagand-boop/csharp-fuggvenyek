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

int abs_max (int a, int b) {
    int aAbs = Math.Abs(a);
    int bAbs = Math.Abs(b);
    if (aAbs > bAbs) {
        return(aAbs);
    } else {
        return(bAbs);
    }
}

Console.WriteLine(abs_max(12, -15));

int fibo (int sorszam) {
    List<int> alapLista = [0, 1];
    for (int i = 2; i <= sorszam; i++) {
        alapLista.Add(alapLista[i-1] + alapLista[i-2]);
    }
    return(alapLista[alapLista.Count()-1]);
}

Console.WriteLine(fibo(10));