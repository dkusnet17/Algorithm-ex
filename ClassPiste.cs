using System;

namespace OOS18
{
    /// <summary>
    /// luokka, joka tietää x- ja y-koordinaatit
    /// </summary>
    public class Piste
    {
        private double x;
        private double y;
        /// <summary>
        /// oletusmuodostin
        /// </summary>
        public Piste()
        {

        }
        ///// <summary>
        ///// parametroitu muodostin
        ///// </summary>
        public Piste(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// laskee etäisyyden origosta
        /// </summary>
        public double Pituus()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public double Etäisyys(Piste piste)
        {
            return Math.Sqrt(Math.Pow(this.X - piste.x, 2) + Math.Pow(this.Y - piste.y, 2));
        }
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }


        }
    }

}