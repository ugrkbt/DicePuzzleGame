using System;


namespace Assets
{
    static class Matris
    {
        public static bool [,]alan;
        static int c,d;
       
 
        public static void   MatrisBoyut(int a,int b)
        {
            alan = new bool[a, b];
            c = ( a-1) / 2;
            d = 1;
        }
        public static void   MatrisEkle(int a,int b)
        {      
            alan[a, b] = true;
        }
        public static bool  MatrisYaz(int a,int b)
        {
            return alan[a, b];
        }
        public static void MatrisSil(int a,int b)
        {
            alan[a, b] = false;
            
        }
        public static bool SagGit()
        {
           
            return alan[c, d+1];
        }
        public static bool SolGit()
        {

            return alan[c, d - 1];
        }
        public static bool ileriGit()
        {

            return alan[c-1, d ];
        }
        public static bool AsagiGit()
        {
            return alan[c+1, d];
        }
        public static void SagaGitti()
        {
            d = d + 1;
        }
        public static void SolaGitti()
        {
            d = d - 1;
        }
        public static void ileriGitti()
        {
           c = c - 1;
        }
        public static void AsagiGitti()
        {
            c = c + 1;
        }
    }
}
