/*pseduo code
 * create entity class of name Mobiles
 having properties of
 	private int Mobileid;
	private String Mobilemodel;
	private float Mobileprice;
	private int Dateofmanufacture;
	
*create business class->MobileStore
no of mobiles to be passed
*register mobile details
    1.add details of the mobiles
    2.display them
*sort mobile details based on model name
*    update
     1>enter id to be updated and display it
*delete 
 1.based on id delete the the details
*exit
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mobile
{/// <summary>
/// creation of a class of MobileStore
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int noOfMobiles = 0;
            Console.WriteLine("enter number of mobile detail to be added");
            noOfMobiles = Convert.ToInt32(Console.ReadLine());
            Mobiles[] mobileobj = new Mobiles[noOfMobiles];
            bool flag = true;
            int choice = 0;
            do
            {
                displayMenu();
                Console.WriteLine("enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        mobileobj = registerMobileDetails(mobileobj);
                        displayMobileDetails(mobileobj);
                        break;
                    case 2:
                        mobileobj = sort(mobileobj);
                        displayMobileDetails(mobileobj);
                        break;
                    case 3:
                        Console.WriteLine("enter the id to be which things need to be updated");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter new  price");
                        double price = Convert.ToDouble(Console.ReadLine());
                        mobileobj = updatePrice(mobileobj, Id, price);
                        displayMobileDetails(mobileobj);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id to be deleted");
                        int Id1 = Convert.ToInt32(Console.ReadLine());
                        mobileobj = delete(mobileobj, Id1);
                        displayMobileDetails(mobileobj);
                        break;
                    case 5:
                        Console.WriteLine("exit");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;

                }
            } while (flag);
        }
/// <summary>
/// deletion using particular id is been implemented
/// </summary>
/// <param name="mobileobj"></param>
/// <param name="id1"></param>
/// <returns></returns>
        private static Mobiles[] delete(Mobiles[] mobileobj, int id1)
        {
            Mobiles[] newarr = new Mobiles[mobileobj.Length - 1];
            int j = 0;
            for (int i=0;i< mobileobj.Length;i++)
            {
                if(mobileobj[i].Mobileid1==id1)
                {
                    continue;
                }

                newarr[j] = mobileobj[i];
                j++;
            }
            mobileobj = newarr;
            return mobileobj;
        }
        /// <summary>
        /// price of particular mobileId is been implemented 
        /// </summary>
        /// <param name="mobileobj"></param>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <returns></returns>

        private static Mobiles[] updatePrice(Mobiles[] mobileobj, int id, double price)
        {
            for(int i=0;i< mobileobj.Length;i++)
            {
                if(mobileobj[i].Mobileid1==id)
                {
                    mobileobj[i].Mobileprice1 = price;
                }
            }
            return mobileobj;
        }
/// <summary>
/// sorting is used to sort mobile details based on mobilemodel 
/// (.compareTo is used because property used  to sort is of string type ie.MobileModel
/// </summary>
/// <param name="mobileobj"></param>
/// <returns></returns>
        private static Mobiles[] sort(Mobiles[] mobileobj)
        {
            Mobiles temp;
            for(int i=0;i< mobileobj.Length;i++)
            {
                for(int j=0; j<mobileobj.Length-i-1;j++)
                {
                    if (mobileobj[j].Mobilemodel1.CompareTo(mobileobj[j + 1].Mobilemodel1) > 0)
                    {
                        temp = mobileobj[j];
                        mobileobj[j] = mobileobj[j + 1];
                        mobileobj[j + 1] = temp;
                    }
                }
            }

            return mobileobj;
        }
        /// <summary>
        /// display entered mobile details is been done using getters
        /// </summary>
        /// <param name="mobileobj"></param>

        private static void displayMobileDetails(Mobiles[] mobileobj)
        {
            for(int i=0;i<mobileobj.Length;i++)
            {
                Console.WriteLine("1. mobile id is->"+mobileobj[i].Mobileid1);
                Console.WriteLine("2. mobilemodel  is->" + mobileobj[i].Mobilemodel1);
                Console.WriteLine("3. mobileprice is->" + mobileobj[i].Mobileprice1);
                Console.WriteLine("4. mobile date of manufacture  is->" + mobileobj[i].Dateofmanufacture1);


            }

        }
        /// <summary>
        /// Adding mobile details is done using contructors 
        /// </summary>
        /// <param name="mobileobj"></param>
        /// <returns></returns>
        private static Mobiles[] registerMobileDetails(Mobiles[] mobileobj)
        {
           for(int i=0;i< mobileobj.Length;i++)
            {
                Console.WriteLine(" Enter mobile id:");
                int Mobileid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter mobilemodel :");
                String Mobilemodel = Console.ReadLine();
                Console.WriteLine(" Enter mobileprice :");
                double Mobileprice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" Enter mobile date of manufacture :");
                int Dateofmanufacture = Convert.ToInt32(Console.ReadLine());
                mobileobj[i] = new Mobiles(Mobileid, Mobilemodel, Mobileprice, Dateofmanufacture);
            }
            return mobileobj;
        }
        /// <summary>
        /// Displaying the menu i.e the tasks performed in the program based on our choice 
        /// </summary>
        private static void displayMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("1.Add and display them");
           Console.WriteLine("2.sort all the mobiles based on model and display them");
            Console.WriteLine("3.update price for given id and display ");
            Console.WriteLine("4.delete mobile details of particular id");
            Console.WriteLine("5.Exit");
            Console.WriteLine("============================================");
        }
    }
}
