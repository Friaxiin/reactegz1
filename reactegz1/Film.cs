using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactegz1
{
    /****************************************
     * nazwa klasy:     Film
     * pola:            tytul - przechowuje tytul filmu
     *                  wypozyczenia - przechowuje liczbe wypozyczen filmu
     * metody:          getWypozyczenia, zwraca liczbe wypozyczen, metoda pozwala na zwrocenie liczby wypozyczen filmu
     *                  getTytul, zwraca tytul filmu - metoda pozwala na zwrocenie tytulu filmu
     *                  setTytul, brak - metoda pozwala na ustawienie tytulu filmu
     *                  inkrementacja, zwraca liczbe wypozyczen filmu powiekszone o 1 - pozwala na zwiekszenie liczby wypozyczen
     * informacje:      klasa reprezentuje obiekt filmu zawierajacego tytul oraz liczbe jego wypozyczen
     * autor:           PESEL Patryk Łabuz
     * 
    ****************************************/
    public class Film
    {
        protected string tytul = "";
        protected int wypozyczenia = 0;

        public int getWypozyczenia()
        {
            return wypozyczenia;
        }
        public string getTytul()
        {
            return tytul;
        }
        public void setTytul(string tytul)
        {
            this.tytul = tytul;
        }
        public int inkrementacja()
        {
            return wypozyczenia++;
        }
    }
}
