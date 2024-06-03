namespace AntraUzduotis_ProduktuValdymoSistema.Models
{
        internal class Zaislas
        {
                string Pavadinimas { get; set; }
                decimal Kaina { get; set; }

                public Zaislas(string Pavadinimas, decimal Kaina)
                {
                        this.Pavadinimas = Pavadinimas;
                        this.Kaina = Kaina;
                }


                public override string ToString()
                {
                        return $"| {Pavadinimas} | {Kaina} |";
                }
        }
}
