using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AccesaEmployee
{
    public abstract class Employee
    {
        private readonly string _name;
        private readonly EmployeePosition _position;
        private readonly float _capacity;//max number of hours per day
        private readonly List<string> _hobbies = new List<string>();

        public string Name => _name;
        public EmployeePosition Position => _position;
        public float Capacity => _capacity;
        public List<string> Hobbies => _hobbies;

        protected Employee(string name, EmployeePosition position, float capacity)
        {
            _name = name;
            _position = position;
            _capacity = capacity;
        }

        public virtual void DisplayInfo()
        {
            var sb = new StringBuilder();
            _hobbies.ForEach(x => sb.Append(x + " "));
            Console.WriteLine($"{_name} ocupa pozitia {_position} si e angajat cu {_capacity} ore pe zi. Lui ii place {sb.ToString()}");
        }

        public void ReadXml(XmlReader x)
        {
            public void XmlWriter1(XmlWriter x)
            {
                using (XmlWriter writer = XmlWriter.Create(@"C:\Users\daniel.bogosel\Downloads\employees.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Employees");


                    foreach (Employee employee in _employees)
                    {
                        writer.WriteStartElement("Employee");

                        writer.WriteElementString("Name: ", employee.Name);
                        writer.WriteElementString("Position: ", employee.Position.ToString());
                        writer.WriteElementString("Capacity: ", employee.Capacity.ToString());

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }

            }

        }
    }
}
