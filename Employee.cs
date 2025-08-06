using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AdvSesstion03
{
    internal class Employee:IComparable<Employee>
    {
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            int result = 0;
            if(other == null) return 1;

            result= this.Salary.CompareTo(other.Salary);
            if(result == 0)
            {
                result=this.Id.CompareTo(other.Id);
                if (result == 0)
                {
                    result=this.Name.CompareTo(other.Name);  
                }
            }
            return result;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id &&
                   Name == employee.Name &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }
        public override string ToString()=>$"id ,{Id} name ,{Name} Salary {Salary}";




    }
}
