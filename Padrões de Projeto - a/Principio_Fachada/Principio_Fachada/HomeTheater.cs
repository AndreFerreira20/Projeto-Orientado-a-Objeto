using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Fachada
{
    internal class HomeTheater
    {
        private TV tv;
        private Projetor projetor;
        private PlayerMidia midia;
        private SistemaSom som;
        private LuzAmbiente luz;
        private Receiver receiver;

        public HomeTheater()
        {
            tv = new TV();
            projetor = new Projetor();
            midia = new PlayerMidia();
            som = new SistemaSom();
            luz = new LuzAmbiente();
            receiver = new Receiver();
        }

        public void AssistirFilme()
        {
            if (tv.GetEnergia() == 0)
                tv.Energia();

            if (luz.GetEnergia() == 1)
                luz.Energia();

            if (midia.GetEnergia() == 0)
                midia.Energia();

            if (som.GetEnergia() == 0)
                som.Energia();

            while(som.GetVolume() < 30) { som.Volume("+"); }

            Console.WriteLine("Filme iniciado!");
        }

        public void OuvirMusica()
        {
            if (som.GetEnergia() == 0)
                som.Energia();

            while (som.GetVolume() < 20)
                som.Volume("+");

            som.Musica("Playlist");
        }

        public void Festa()
        {
            if (som.GetEnergia() == 0)
                som.Energia();

            while (som.GetVolume() < 40)
                som.Volume("+");

            som.Musica("Playlist-Festa");

            if (luz.GetEnergia() == 0)
                luz.Energia();

            luz.MudarCor("Mix de Cores");
        }
    }
}
