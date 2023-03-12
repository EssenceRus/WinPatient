using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void TBFind_change(object sender, TextChangedEventArgs e)
        {
            //var patientsList = context;
            //patientsList = ContextBoundObject.Where(propa => propa.Name.ToLower().Contains(TBFind.Text.ToLower())).Tolist();
        }
    }
}
