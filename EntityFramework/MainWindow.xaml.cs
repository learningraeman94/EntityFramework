using System;
using System.Windows;
using System.Linq;
using EntityFramework.Models;

namespace EntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly JournalContext db = new JournalContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubjectsJournal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
