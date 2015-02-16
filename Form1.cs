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
        protected List<Employee> employees { get; set; }
        protected List<Shift> shifts { get; set; }
        protected List<Shift> uniqueShifts { get; set; }

        public Form1()
        {
            InitializeComponent();

            employees = new List<Employee>();
            AddEmployees();

            comboEmployee.DataSource = employees;
            comboEmployee.DisplayMember = "Name";
            comboEmployee.ValueMember = "ID";

            shifts = new List<Shift>();
            AddShifts();
            uniqueShifts = shifts.Distinct(new MyComparer()).ToList();
                        
            comboShift.DataSource = uniqueShifts;
            comboShift.DisplayMember = "dayOfWeek";
            
        
        }  // end Form

       public class MyComparer : IEqualityComparer<Shift>
        {
           public bool Equals(Shift x, Shift y)
            {
                return x.dayOfWeek.Equals(y.dayOfWeek);
            }

           public int GetHashCode(Shift obj)
            {
                return obj.dayOfWeek.GetHashCode();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int EmpId;
            EmpId =Convert .ToInt32 (comboEmployee.SelectedValue);
            var availabilityDaysList = from s in shifts
                                   where s.id == EmpId
                                   select s.dayOfWeek;
            String str= str.Join ("\n", availabilityDaysList.ToList ().ToArray ());
            //for (int i=0;i<availabilityDaysList.Count ();i++)
            //{
            //    str .Concat(availabilityDaysList [i]);
            //}

            //for (int i = 0; i < availabilityDaysList.Count(); i++)
            //{
            //    textDaysOfEmp.Text = availabilityDaysList[i] + System.Environment.NewLine;

            //}
            textDaysOfEmp.Text = str;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Day;
            Day = comboShift.SelectedText;
            var availabilityEmployeesList = from s in shifts
                                            where s.dayOfWeek  == Day
                                            select s.id;

            //var EmployeeNames = from ex in employees
            //                    where ex.ID == 
            //                    select ex.name ;
            
        }

        void AddEmployees()
        {
            employees.Add(new Employee { ID = 1, name = "kanu" });
            employees.Add(new Employee { ID = 2, name = "vandana" });
            employees.Add(new Employee { ID = 3, name = "komal" });

            employees.Add(new Employee { ID = 4, name = "aishwarya" });
            employees.Add(new Employee { ID = 5, name = "ritika" });
            employees.Add(new Employee { ID = 6, name = "nishchint" });

            employees.Add(new Employee { ID = 7, name = "tabassum" });
            employees.Add(new Employee { ID = 8, name = "kanika" });
            employees.Add(new Employee { ID = 9, name = "ria" });

            employees.Add(new Employee { ID = 10, name = "john" });
            employees.Add(new Employee { ID = 11, name = "jane" });
        }

        void AddShifts()
        {
            shifts.Add(new Shift { id = 1, dayOfWeek = "monday" });
            shifts.Add(new Shift { id = 2, dayOfWeek = "monday" });
            shifts.Add(new Shift { id = 3, dayOfWeek = "monday" });

            shifts.Add(new Shift { id = 4, dayOfWeek = "tuesday" });
            shifts.Add(new Shift { id = 5, dayOfWeek = "tuesday" });
            shifts.Add(new Shift { id = 6, dayOfWeek = "tuesday" });

            shifts.Add(new Shift { id = 7, dayOfWeek = "wednesday" });
            shifts.Add(new Shift { id = 8, dayOfWeek = "wednesday" });
            shifts.Add(new Shift { id = 9, dayOfWeek = "wednesday" });

            shifts.Add(new Shift { id = 10, dayOfWeek = "thursday" });
            shifts.Add(new Shift { id = 11, dayOfWeek = "thursday" });
            shifts.Add(new Shift { id = 1, dayOfWeek = "thursday" });

            shifts.Add(new Shift { id = 2, dayOfWeek = "friday" });
            shifts.Add(new Shift { id = 3, dayOfWeek = "friday" });
            shifts.Add(new Shift { id = 4, dayOfWeek = "friday" });

            shifts.Add(new Shift { id = 5, dayOfWeek = "saturday" });
            shifts.Add(new Shift { id = 6, dayOfWeek = "saturday" });
            shifts.Add(new Shift { id = 7, dayOfWeek = "saturday" });

            shifts.Add(new Shift { id = 8, dayOfWeek = "sunday" });
            shifts.Add(new Shift { id = 9, dayOfWeek = "sunday" });
            shifts.Add(new Shift { id = 10, dayOfWeek = "sunday" });

        }

       


 
    }

}
