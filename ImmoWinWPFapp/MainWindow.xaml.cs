using ImmoWinWPFapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace ImmoWinWPFapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            AddToWoninglijst(false,false);

         
        }

        void AddToWoninglijst(bool? House, bool? Appartment)
        {
            try { 
            List<IWoning> woningen = new List<IWoning>()
            {
            new Huis("Rijhuis", 100000, "Xanderplein", 10, "Brussel", 1030),
            new Huis("Alleenstaand",500000,"DeKleistraat",45,"Wemmel",2015),
            new Appartement(2,171000,"Xeneraallaan",8,"Gent",3000),
            new Appartement(1,179000,"Xeneraallaan",8,"Gent",3000),
            new Appartement(3,175000,"Generaallaan",8,"Gent",3000),
            new Appartement(1,175000,"Generaallaan",8,"Gent",3000),
            new Appartement(2,125000,"Generaallaan",8,"Gent",3000),
            };
            woningen.Sort();
            Woninglijst.Items.Clear();

            if (Appartment == false && House == true)
            {
                List<IHuis> huisen = woningen.OfType<IHuis>().ToList();

                foreach (IWoning item in huisen)
                {
                    Woninglijst.Items.Add(item.ToString());
                }

            }
            else if (House == false && Appartment == true)
            {
                List<IAppartement> appartementen = woningen.OfType<IAppartement>().ToList();

                foreach (IWoning item in appartementen)
                {
                    Woninglijst.Items.Add(item.ToString());
                }
            }
            else
            {
                foreach (IWoning item in woningen)
                {
                    Woninglijst.Items.Add(item.ToString());
                }                  
            }
            }
            catch(Exception e) {
                Console.WriteLine(("Something went horribly wrong with my spaghetti code : " + e));
            };
        }


        private void OnCheckBoxClick(object sender, RoutedEventArgs e)
        {
            AddToWoninglijst(House.IsChecked, Appartment.IsChecked);
        }


    }
}
