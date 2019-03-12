using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppMainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string user;
        public SecureString pass;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Btn_Click(object sender, RoutedEventArgs e)
        {
            string username = uc.Username.ToString();
            string pass = uc.Password.ToString();
            //string username = ((ChildLibrary.UserControl1.FindControl("usercontrol") as UserControl).FindControl("txtname") as TextBox).Text = ;
            //string password = pass;
            tbTxt.Text = username + " Pass: ";
            //if (ctrlBtn1.Content.ToString().Equals("Login"))
            //{
            //    if (username.Equals("baongan") && password.Equals("baongan@123"))
            //    {
            //        MessageBox.Show("Welcome back!");
            //    }
            //    else MessageBox.Show("Invalid login");
            //}
            //else if (ctrlBtn1.Content.ToString().Equals("Register"))
            //{
            //    if (!(username.Equals("baongan") && password.Equals("baongan@123")))
            //    {
            //        MessageBox.Show("Welcome new user," + username);
            //    }
            //    else MessageBox.Show("Existed user");
            //}
        }
    }
}
