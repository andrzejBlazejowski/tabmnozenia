public class Grupa
{
    public struct Potok
    {
        public string OznaczenieGrupy { get; set; }

        public Potok(string oznaczenieGrupy)
        {
            OznaczenieGrupy = oznaczenieGrupy;
        }

        public string GenerujKodGrupy(int rokRozpoczecia)
        {
            int rokZakonczenia = rokRozpoczecia + 1;
            return $"{OznaczenieGrupy} {rokRozpoczecia}/{rokZakonczenia}";
        }
    }

    public string Nazwa { get; set; }
    public int LiczbaStudentow { get; set; }
    private string[] członkowie = new string[10];

    public Grupa(string nazwa, int liczbaStudentow)
    {
        Nazwa = nazwa;
        LiczbaStudentow = liczbaStudentow;
    }

    public int LiczbaMiejsc
    {
        get { return członkowie.Length; }
        set
        {
            if (value > członkowie.Length)
            {
                Array.Resize(ref członkowie, value);
            }
            else if (value < członkowie.Length)
            {
                int emptySlots = członkowie.Length - LiczbaStudentow;
                if (value < emptySlots)
                {
                    throw new ArgumentException("Not enough empty slots to resize the array");
                }

                for (int i = 0; i < członkowie.Length && emptySlots > 0; i++)
                {
                    if (członkowie[i] == null)
                    {
                        int j = i + 1;
                        while (j < członkowie.Length && członkowie[j] == null)
                        {
                            j++;
                        }

                        if (j < członkowie.Length)
                        {
                            członkowie[i] = członkowie[j];
                            członkowie[j] = null;
                            emptySlots--;
                        }
                    }
                }

                Array.Resize(ref członkowie, value);
            }
        }
    }

    public override string ToString()
    {
        return $"{Nazwa} ({LiczbaStudentow} studentów)";
    }

    public static Grupa operator -(Grupa group, string member)
    {
        for (int i = 0; i < group.członkowie.Length; i++)
        {
            if (group.członkowie[i] == member)
            {
                group.członkowie[i] = null;
                group.LiczbaStudentow--;
            }
        }
        return group;
    }

    public static bool operator >(Grupa group1, Grupa group2)
    {
        return group1.LiczbaMiejsc > group2.LiczbaMiejsc;
    }

    public static bool operator <(Grupa group1, Grupa group2)
    {
        return group1.LiczbaStudentow < group2.LiczbaStudentow;
    }
}