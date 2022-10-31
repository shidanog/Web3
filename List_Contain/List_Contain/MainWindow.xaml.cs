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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace List_Contain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Person p1 = new Person("a", 34);
            Person p2 = new Person("b", 45);
            Person p3 = new Person("c", 42);
           

            List<Person> listP = new List<Person>();
            listP.Add(p1);
            listP.Add(p2);
            listP.Add(p3);
            //if (!listP.Contains(p4))
            //{
            //    listP.Add(p2);
            //}
            //Hashtable ht = new Hashtable();
            Dictionary<object,object>ht=new Dictionary<object,object>();
            ht.Add(p1, p1.Id);
            ht.Add(p2, p2.Id);
            ht.Add(p3, p3.Id);
            Person p4 = new Person("a", 34);
            //ht.Add(p4, p4.Id);
            object b=ht[p3];
            object c = ht[p4];
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string peom1 = "Kubla Khan";
            string peom2 = "Kubla Khan";
            string peom3 = String.Copy(peom2);
            string peom4 = "Kubla Khan";
            bool b = ReferenceEquals(peom1, peom4);
            string result = string.Format("peom1 == peom2:{0}", "peom1 == peom3:{1}", "ReferenceEquals(peom1,peom3):{2}", peom1 == peom2, peom1 == peom3, ReferenceEquals(peom1, peom3));
            MessageBox.Show(result);
        }
    }
    public class Person
    {
        public String Name;
        public int Id;
        public Person()
        { }
        public Person(String _name, int _id)
        {
            Name = _name;
            Id = _id;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            return Equals(obj as Person);
        }

        private bool Equals(Person p)
        {
            return (this.Id == p.Id);
        }
        //public override int GetHashCode()
        //{
        //    return this.Id;
        //}

    }
}
