using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_DB.DataSetTableAdapters;

namespace WPF_DB
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public string name;
        public string Password;
        private UsersTableAdapter adapter = new UsersTableAdapter();
        private DataSet dataSet = new DataSet();

        public Login()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            adapter.Fill(dataSet.Users);
            DataContext = dataSet.Users.DefaultView;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
           IEnumerable<DataSet.UsersDataTable> usersRows = (IEnumerable<DataSet.UsersDataTable>)dataSet.Users;
           //usersRows = from Users in Name where Name = txtName.Text;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            DataSet.UsersRow row = (DataSet.UsersRow)dataSet.Users.NewRow();
            // set row Name to name textbox Text
            // set row Password to password textbox 

            dataSet.Users.AddUsersRow(row);
            adapter.Update(dataSet);

            // show message box that states the user was registered
            // on the message box show an information icon and “Register” caption
            // look at resources section below for message box information

            // clear text boxes
        }

    }
}
