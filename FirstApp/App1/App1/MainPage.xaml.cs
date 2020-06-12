using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object sender, EventArgs e)
        {

            string text = Entry.Text; //cast sender to access the properties of the Entry

            //update value of label to value inputed by user
            Label.Text = text;
        }
    }
}
