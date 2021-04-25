using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile
{/// <summary>
/// entity class of name Mobiles
/// </summary>
    class Mobiles
    {
        private int Mobileid;
        private String Mobilemodel;
        private double Mobileprice;
        private int Dateofmanufacture;
        /// <summary>
        /// default constructor or super class
        /// </summary>
        public Mobiles()
        {

        }

        /// <summary>
        /// parameterized constructors
        /// </summary>
        /// <param name="mobileid"></param>
        /// <param name="mobilemodel"></param>
        /// <param name="mobileprice"></param>
        /// <param name="dateofmanufacture"></param>
        public Mobiles(int mobileid, string mobilemodel,double mobileprice, int dateofmanufacture)
        {
            Mobileid = mobileid;
            Mobilemodel = mobilemodel;
            Mobileprice = mobileprice;
            Dateofmanufacture = dateofmanufacture;
        }
        /// <summary>
        /// getters and setters used to access the concept of encapsulation
        /// </summary>
        public int Mobileid1 { get => Mobileid; set => Mobileid = value; }
        public string Mobilemodel1 { get => Mobilemodel; set => Mobilemodel = value; }
        public double Mobileprice1 { get => Mobileprice; set => Mobileprice = value; }
        public int Dateofmanufacture1 { get => Dateofmanufacture; set => Dateofmanufacture = value; }
    }
}
