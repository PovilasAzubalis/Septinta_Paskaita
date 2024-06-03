namespace AntraUzduotis_ProduktuValdymoSistema.Models
{
        internal class Pirkejas
        {
                string VardasPavarde { get; set; }
                List<Zaislas> PirkiniuKrepselis { get; set; }


                public Pirkejas(string Vardas, string Pavarde)
                {
                        Console.Write("Iveskite savo varda: ");
                        Vardas = Console.ReadLine();
                        Console.Write("Iveskite savo pavarde: ");
                        Pavarde = Console.ReadLine();
                        VardasPavarde = Vardas + Pavarde;

                        List<Zaislas> PirkiniuKrepselis = new List<Zaislas>();
                }
        }
}
