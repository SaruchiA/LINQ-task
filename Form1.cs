using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Employee employee1 = new Employee();
            Shift shift1 = new Shift();
            employee1.populateEmpDictionary();
            shift1.populateShiftList();
            comboEmployee.Items.AddRange(employee1.empDictionary.Values.ToArray());
            for (int i = 0; i < shift1.shiftList.Count; i++)
            {
                if (!comboShift.Items.Contains(shift1.shiftList.ElementAt(i).Value.ToString()))
                //if (shift1.shiftList .Contains 
                comboShift.Items.Add(shift1.shiftList.ElementAt(i).Value.ToString());
            }
            

        }        

        private void button1_Click(object sender, EventArgs e)
        {         
                     
        }

 
    }

    public class Employee
    {
        private int id;
        private String name;
        List<Employee> employees = new List<Employee>();
        Employee emp = new Employee();
        public void populateEmployees()
        {
            emp.id = 1;
            emp.name = "kanu";
            employees.Add(emp);

            emp .id=2;
            emp.name = "vandana";
            employees.Add(emp);

            emp.id = 3;
            emp.name = "komal";
            employees.Add(emp);

            emp.id = 4;
            emp.name = "aishwarya";
            employees.Add(emp);

            emp.id = 5;
            emp.name = "ritika";
            employees.Add(emp);

            emp.id = 6;
            emp.name = "nishchint";
            employees.Add(emp);

            emp.id = 7;
            emp.name = "tabassum";
            employees.Add(emp);

            emp.id = 8;
            emp.name = "john";
            employees.Add(emp);

            emp.id = 9;
            emp.name = "jane";
            employees.Add(emp);

            emp.id = 10;
            emp.name = "ria";
            employees.Add(emp);

            emp.id = 11;
            emp.name = "kanika";
            employees.Add(emp);
                        
        }

    }

    public class Shift
    {
        private int id;
        private String dayOfWeek;
        List <Shift >=new List <Shift >();
        Shift shift1 = new Shift();
        
        public void populateShifts()
        {
            shift1.id = 1;
            shift1.dayOfWeek = "monday";
            s
        }
       
    }


    /*------------------------------- Approach 1:- without using objects ----------------------------------*/

    //class Employee
    //{
    //    private int id;
    //    private String name;
    //    public Dictionary<int, String> empDictionary = new Dictionary<int, String>();
    //    public void populateEmpDictionary()
    //    {
    //        empDictionary.Add(1, "vandana");
    //        empDictionary.Add(2, "komal");
    //        empDictionary.Add(3, "aishwarya");
    //        empDictionary.Add(4, "ritika");
    //        empDictionary.Add(5, "nishchint");
    //        empDictionary.Add(6, "tabassum");
    //        empDictionary.Add(7, "john");
    //        empDictionary.Add(8, "jane");
    //        empDictionary.Add(9, "ria");
    //        empDictionary.Add(10, "kanika");
    //    }

    //}


    //class Shift
    //{

    //    public List<KeyValuePair<string, int>> shiftList = new List<KeyValuePair<string, int>>();
    //    public void populateShiftList()
    //    {
    //        shiftList.Add(new KeyValuePair<string, int>("monday", 1));
    //        shiftList.Add(new KeyValuePair<string, int>("monday", 2));
    //        shiftList.Add(new KeyValuePair<string, int>("monday", 3));
    //        shiftList.Add(new KeyValuePair<string, int>("tuesday", 4));
    //        shiftList.Add(new KeyValuePair<string, int>("tuesday", 5));
    //        shiftList.Add(new KeyValuePair<string, int>("tuesday", 6));
    //        shiftList.Add(new KeyValuePair<string, int>("wednesday", 7));
    //        shiftList.Add(new KeyValuePair<string, int>("wednesday", 8));
    //        shiftList.Add(new KeyValuePair<string, int>("wednesday", 9));
    //        shiftList.Add(new KeyValuePair<string, int>("thursday", 10));
    //        shiftList.Add(new KeyValuePair<string, int>("thursday", 1));
    //        shiftList.Add(new KeyValuePair<string, int>("thursday", 2));
    //        shiftList.Add(new KeyValuePair<string, int>("friday", 3));
    //        shiftList.Add(new KeyValuePair<string, int>("friday", 4));
    //        shiftList.Add(new KeyValuePair<string, int>("friday", 5));
    //        shiftList.Add(new KeyValuePair<string, int>("saturday", 6));
    //        shiftList.Add(new KeyValuePair<string, int>("saturday", 7));
    //        shiftList.Add(new KeyValuePair<string, int>("saturday", 8));
    //        shiftList.Add(new KeyValuePair<string, int>("sunday", 9));
    //        shiftList.Add(new KeyValuePair<string, int>("sunday", 10));
    //        shiftList.Add(new KeyValuePair<string, int>("sunday", 1));

    //    }

    // }
}
