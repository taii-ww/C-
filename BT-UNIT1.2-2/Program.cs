// See https://aka.ms/new-console-template for more information


using BT_UNIT1._2_2;

Employee[] emp = new Employee[4];

emp[0] = new HourlyWorker("John", 10, 40);
emp[1] = new HourlyWorker("Anna", 12, 35);

emp[2] = new SalaryWorker("Mike", 48000);
emp[3] = new SalaryWorker("Sara", 60000);

foreach (Employee e in emp)
{
    e.calcPaidCheck();
}
