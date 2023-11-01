using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace school_wpf
{
    public partial class MainWindow : Window
    {
        ObservableCollection<string> studentObservable = new ObservableCollection<string>();
        Binding studentBinding = new Binding();

        private readonly database db;
        public MainWindow()
        {
            InitializeComponent();

            db = new database();
            studentBinding.Source = studentObservable;
            foreach (var CB_group in db.Group)
            {

                studentObservable.Add(CB_group.name);
                tbGroup.SetBinding(ComboBox.ItemsSourceProperty, studentBinding);

            }
            foreach (var stud in db.Student)
            {

                ListTeacher.Items.Add($"{stud.username} Группа: {db.Group.FirstOrDefault(x => x.id == stud.group_id).name}");

            }
        }

        private void School(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            var fullname = fullName.Text.Trim();
            var group = tbGroup.Text.Trim();
            student.username = fullname;
            student.id = + 1;
            student.group_id = db.Group.FirstOrDefault(x => x.name == group).id;
            db.Student.Add(student);
            db.SaveChanges();
            fullName.Clear();
        }
        private void Remove(object sender, RoutedEventArgs e)
        {
            ListTeacher.Items.Clear();
            foreach (var stud in db.Student)
            {

                ListTeacher.Items.Add($"{stud.username} Группа: {db.Group.FirstOrDefault(x => x.id == stud.group_id).name}");

            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (ListTeacher.SelectedItem == null)
            {
                return;
            }
            else
            {
                ListTeacher.IsEnabled = true;
            }
            var killStudent = ListTeacher.SelectedItems;

            string[] words = killStudent[0].ToString().Split(' ');
            ListTeacher.Items.Remove(ListTeacher.SelectedItem);
            ListTeacher.Items.Refresh();
        }
    }
}
