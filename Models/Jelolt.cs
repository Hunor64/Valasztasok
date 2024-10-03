namespace Valasztasok.Models
{
    public class Jelolt
    {
        public int Id { get; set; }
        public string KepviseloNev { get; set; }
        public string PartRovidNev { get; set; }
        public int KeruletID { get; set; }
        public int SzavazatSzam { get; set; }
        public virtual Part Part { get; set; }
    }
}
