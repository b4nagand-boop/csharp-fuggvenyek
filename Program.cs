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

// Jelszóerősség mérő
// Magánhangzó eltávolítás
// Szöveg titkosítása

int jelszo_erosseg (string jelszo) {
    int pontszam = 1;
    
    if (jelszo.Count() >= 5) {
        pontszam++;
    }
    
    if (jelszo.Count() >= 8) {
        pontszam += 2;
    }

    for (int i = 0; i < jelszo.Count(); i++) {
        if (jelszo[i] == '_' || jelszo[i] == '-' || jelszo[i] == '.') {
            pontszam += 2;
        }
    }
    
    if (jelszo.Contains("jelszo") || jelszo.Contains("123") || jelszo.Count() == 0) {
        pontszam = 0;
    }
    
    return(pontszam);
}

Console.WriteLine(jelszo_erosseg("hazi_macska_4_life"));
Console.WriteLine(jelszo_erosseg("ez1feltorhetetlenjelszo"));
Console.WriteLine(jelszo_erosseg("forloopTeszt_"));
Console.WriteLine(jelszo_erosseg("forloopTeszt"));