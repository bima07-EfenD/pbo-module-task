class program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Arema", 10, 4);
        Gajah gajah = new Gajah("Yudha", 18, 4);
        Ular ular = new Ular("Kimbo", 2, 3);
        Buaya buaya = new Buaya("Bonek", 97, 19.27);
        Reptil reptil = new Buaya("Jojo", 27, 19.27);
        Console.WriteLine(reptil.Suara());

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nSuara yang didengar :");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\nAKtivitas Hewan:");
        singa.Mengaum();
        ular.Merayap();

    }
}

public class KebunBinatang
{
    public List<Hewan> KoleksiHewan= new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("\nDaftar hewan di Kebun Binatang:");
        foreach (var hewan in KoleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}


public class Hewan
{
    public string Nama;
    public int Umur;
    public Hewan(string Nama, int Umur)
    {
        this.Nama = Nama;
        this.Umur = Umur;
    }

    public virtual string Suara()
    {
        return "Hewan Bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}\nUmur: {Umur}\n";
    }
}


public class Mamalia : Hewan
{
    public int JumlahKaki;
    public Mamalia(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur)
    {
        this.JumlahKaki = jumlahKaki;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $"Jumlah Kaki : {JumlahKaki}\n";
    }

    public override string Suara()
    {
        return "Suara mamalia";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh;
    public Reptil(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur)
    {
        this.PanjangTubuh = panjangTubuh;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $"Panjang Tubuh : {PanjangTubuh} cm\n";
    }

    public override string Suara()
    {
        return "Suara reptil";
    }
}


public class Singa : Mamalia
{
    public Singa(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, jumlahKaki) { }
    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum!");
    }

    public override string Suara()
    {
        return "singa rawwwwr";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, jumlahKaki) { }
    public override string Suara()
    {
        return "Gajah ngomong Awas Awas, minggir lu misnadi";
    }
}

public class Ular : Reptil
{
    public Ular(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh) { }
    public void Merayap()
    {
        Console.WriteLine("Ular sedang merayap meliuk-liuk");
    }

    public override string Suara()
    {
        return "Ular sssstttt";
    }
}

public class Buaya : Reptil
{
    public Buaya(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh) { }
    public override string Suara()
    {
        return "Salam Satu Nyali! WANII!!!";
    }
}

