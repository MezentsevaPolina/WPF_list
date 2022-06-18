using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList3.json";
        private BindingList<TodoModel> _todoDataList;
        private FileIOService _fileIOService;
        //private SqlConnection _sqlConnection = null;

        public Window3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dgToDoList_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOService = new FileIOService(PATH);

            try
            {
                _todoDataList = _fileIOService.LoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            dgToDoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;
        }

        private void _todoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileIOService.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
    }
}
