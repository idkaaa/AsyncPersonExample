using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncPersonExample
{
    /// <summary>
    /// A Dialog to demonstrate ASYNC loading of data in 
    /// Winforms using Tasks.
    /// </summary>
    public partial class PersonListDialog : Form
    {
        /// <summary>
        /// The list of persons.
        /// </summary>
        Person[] PersonList { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public PersonListDialog()
        {
            PersonList = MakeNewPeople();
            InitializeComponent();
        }

        /// <summary>
        /// This handles clicking the get person list button.
        /// </summary>
        private async void Handle_GetPersonListButtonClick(object sender, EventArgs e)
        {
            //runs in current thread
            LabelResponsiveUI.Visible = true; 

            //runs in different thread
            PersonList = await Task.Run(() => ValidatePersonList(PersonList));

            //back in current thread
            ShowPersonList();
            LabelResponsiveUI.Visible = false;
        }

        /// <summary>
        /// Filters out any people we don't want displayed.
        /// </summary>
        private Person[] ValidatePersonList(Person[] PersonList)
        {
            //Simulate long processing/
            //loading data in the background...
            Thread.Sleep(5000);

            PersonList = FilterOutBadPersons(PersonList);
            PersonList = FilterOutDeadPersons(PersonList);
            return PersonList;
        }

        /// <summary>
        /// Filters out dead people.
        /// </summary>
        private Person[] FilterOutDeadPersons(Person[] personList)
        {
            return PersonList
                .Where(r => r.isAlive == true)
                .ToArray();
        }

        /// <summary>
        /// Filters out bad people.
        /// </summary>
        private Person[] FilterOutBadPersons(Person[] personList)
        {
            return PersonList
                .Where(r => r.isGood == true)
                .ToArray();
        }

        /// <summary>
        /// Shows the person list. Must run in UI thread.
        /// </summary>
        private void ShowPersonList()
        {
            if (PersonList == null)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                foreach (Person p in PersonList)
                {
                    ComboBoxPersonList.Items.Add(p.Name);
                }
            }
        }


        /// <summary>
        /// Makes some new people.
        /// </summary>
        private Person[] MakeNewPeople()
        {
            List<Person> NewPersonList = new List<Person>();

            Person p1 = new Person();
            p1.Name = "John Doe";
            p1.isAlive = true;
            p1.isGood = true;
            NewPersonList.Add(p1);

            Person p2 = new Person();
            p2.Name = "Jane Doe";
            p2.isAlive = false;
            p2.isGood = true;
            NewPersonList.Add(p2);

            Person p3 = new Person();
            p3.Name = "Sam Elliot";
            p3.isAlive = false;
            p3.isGood = false;
            NewPersonList.Add(p3);

            Person p4 = new Person();
            p4.Name = "Mary Kate";
            p4.isAlive = true;
            p4.isGood = true;
            NewPersonList.Add(p4);

            Person p5 = new Person();
            p5.Name = "Bill Nye";
            p5.isAlive = true;
            p5.isGood = true;
            NewPersonList.Add(p5);

            return NewPersonList.ToArray();
        }

        /// <summary>
        /// this represents a single person.
        /// </summary>
        public class Person
        {
            public string Name { get; set; }
            public bool isAlive { get; set; }
            public bool isGood { get; set; }
        }
    }

    

    

    
}
