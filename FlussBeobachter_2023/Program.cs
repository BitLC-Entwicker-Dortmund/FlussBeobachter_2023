namespace FlussBeobachter_2023 {

    // delegates deklarieren
    //delegate void AufgabenHandler (object sender, EventArgs e);

    internal class Program {
        static void Main(string[] args) {
            // Objekte erzeugen
            Fluss rhein = new Fluss();
            Schiff rheingold = new Schiff();

            // Events festlegen und an Methode binden
            rheingold.EinEvent += rheingold.OnWasserstand;

            // Programmverlauf

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(rhein.GetPegel());                
                Thread.Sleep(1000);
            }

            Console.Read();
        }
    }
}