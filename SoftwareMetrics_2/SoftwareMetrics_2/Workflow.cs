using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareMetrics_2_Workflow
{
    /*
     * Имате няколко класа: служител (Employee), работодател (Employer) и проект (Project), описани по-долу.
     * Имплементирайте методи:
     *      Employee.IsValid() - служителя да е на 18 или повече години;
     *      Employee.IsJobValid() - дали е на някоя от следните позиции: 
     *          Developer,
     *          QA,
     *          Designer,
     *          Project Manager,
     *          Product Owner;
     *      Employer.IsValid() - служителя да е на 18 или повече години;
     *      Project.IsTeamValid() - да изпълнява следните условия:
     *          Броят на служтелите да е равен на предварително зададения в Project.TeamSize;
     *          Броят на служителите с роля "Инженер" да отговаря на зададения в Project.EngineeringCount;
     *          
     * Може да променяте пропърита, класове, да създавате ваши при нужда.
     */

    class Workflow
    {
    }

    public class Person
    {
    }

    public class Job
    {
    }

    public class Constants
    {
    }

    public class Employee
    {
        public string JobTitle { get; set; }
        
        public Employee()
        {
        }

    }

    public class Employer : Person
    {

    }

    public class Project
    {
        List<Employee> Employees { get; set; }
        public int TeamSize { get; set; }
        public int EngineeringCount { get; set; }
        public bool IsTeamValid()
        {
            
            //1. check for TeamSize;
            

            //2. check for EngineeringCount. Enginnering positions: Developer, QA, Designer
            

            return true;
        }
    }
}
