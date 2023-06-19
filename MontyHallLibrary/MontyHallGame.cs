namespace MontyHallLibrary
{
    // 0 is a goat
    // 1 is a car
    public class MontyHallGame
    {
        public Random generator = new Random();
        public List<int>? porte { get; set; }
        int portaaperta { get; set; }
        int portascelta { get; set; }

        public MontyHallGame()
        {
            var lista = createlist();

            while (!checklist(lista))
            {
                lista = createlist();
            }

            porte = lista;

        }
        public static void testautomatico(int partite, string scelta)
        {
            int vittorie = 0;
            string scritta = "";
            int choice;

            if (scelta == "cambiando")
            {
                choice = 1;
                scritta = "cambiando porta";
            }
            else
            {
                choice = 0;
                scritta = "non cambiando porta";
            }

            for (int i = 0; i < partite; i++)
            {

                MontyHallGame montyHallGame = new MontyHallGame();

                int userdoor = montyHallGame.generator.Next(0, 3);
                montyHallGame.opendoor(userdoor);


                var res = montyHallGame.verificavincita(choice);
                if (res == "Hai Vinto!")
                {
                    vittorie++;
                }

            }
            double percentuale = (double)vittorie / (double)partite;
            Console.WriteLine($"Percentuale di vittoria {scritta}: {percentuale * 100}%");
        }
        private List<int> createlist()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(generator.Next(0, 2));
            }
            return list;
        }


        private bool checklist(List<int> list)
        {
            var ritorno = list.FindAll(x => x == 1);

            if (ritorno.Count > 1 || ritorno.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int opendoor(int choice)
        {
            var lista = new List<int>();
            this.porte.ForEach(x => lista.Add(x));
            this.portascelta = choice;
            lista[choice] = 3;

            int caso = generator.Next(0, 3);

            while (!(lista[caso] == 0))
            {

                caso = generator.Next(0, 3);
            }
            // Console.WriteLine($"Dietro la porta {caso + 1} c'è una capra! ");
            this.portaaperta = caso;
            return caso;
        }

        public string verificavincita(int scelta)
        {
            if (scelta == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (!(this.portaaperta == i || this.portascelta == i))
                    {
                        portascelta = i;
                        break;
                    }
                }

            }

            if (porte[portascelta] == 1)
            {
                return "Hai Vinto!";
            }
            else
            {
                return "Hai Perso!";
            }

        }
    }
}