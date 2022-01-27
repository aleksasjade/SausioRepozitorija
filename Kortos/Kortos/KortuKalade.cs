﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class KortuKalade
    {
        public List<Korta> KortuSarasas { get; private set; }

        public KortuKalade()
        {
            KortuSarasas = new List<Korta>();
            UzpildytiKortuSarasa();
        }
        
        private void UzpildytiKortuSarasa()
        {
            UzpildytiZenklu("Sirdis");
            UzpildytiZenklu("Kryzius");
            UzpildytiZenklu("Vynas");
            UzpildytiZenklu("Bugnas");
        }

        public void UzpildytiZenklu(string zenklas)
        {
            for (int i = 2; i <=10; i++)
            {
                KortuSarasas.Add(new SkaitineKorta(i, zenklas));
            }

            KortuSarasas.Add(new GalvaKorta("Valetas", zenklas));
            KortuSarasas.Add(new GalvaKorta("Dama", zenklas));
            KortuSarasas.Add(new GalvaKorta("Karalius", zenklas));
            KortuSarasas.Add(new Tuzas(zenklas));

        }

        public void Sumaisyti()
        {
            var random = new Random();
            KortuSarasas = KortuSarasas.OrderBy(korta => random.Next()).ToList();
        }
    }
}
