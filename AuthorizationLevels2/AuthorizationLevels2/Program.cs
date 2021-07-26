using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationLevels2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region bankaccount
            //BankAccaount b = new BankAccaount("discont",10000,2802);
            //Console.WriteLine(b.GetAccountDetails());
            #endregion

            #region clients
            //ClientsManagment cl1 = new ClientsManagment(new string[4], new int[4], new bool[4],4);
            //cl1.AddClient("ori", 23, false);
            #endregion

            #region persons
            //person p1 = new person("ori", 0547788027);
            //person p2 = new person("ori", 0547788027);
            //person p3 = new person("ori", 0547788027);

            //Console.WriteLine(p1);
            #endregion

            #region user
            user u1 = new user();

            #endregion
        }


    }

    class BankAccaount
    {
        private string bankName;
        private double balance;
        private int accountNumber;

        public BankAccaount(string bankName, double balance, int accountNumber)
        {
            this.bankName = bankName;
            this.balance = balance;
            this.accountNumber = accountNumber;
        }

        public void WithdrawOrDepisit(double moeny)
        {
            balance += moeny;
        }

        public string GetAccountDetails()
        {
            return bankName + "\t" + accountNumber;
        }
    }

    public class person
    {
        private string name;
        private int phone;
        readonly int MyID;
        private static int numberOfPersons = 0;

        public person(string name, int phone)
        {
            this.name = name;
            this.phone = phone;
            numberOfPersons++;
            MyID = numberOfPersons;
        }
        public static void changeName(person p, string newname)
        {
            p.name = newname;
        }
        public static void changePhone(person p, int phone)
        {
            p.phone = phone;
        }

        public override string ToString()
        {
            return $"name: {name}\nphone: {phone}\nID: {MyID}";
        }

    }

    public class ClientsManagment
    {
        private string[] clientsNames = new string[10];
        private int[] clientsAges = new int[10];
        private bool[] vagie = new bool[10];
        private int howManyClients;

        public ClientsManagment(string[] clientsNames, int[] clientsAges, bool[] vagie, int howManyClients)
        {
            this.clientsNames = clientsNames;
            this.clientsAges = clientsAges;
            this.vagie = vagie;
            this.howManyClients = howManyClients;
        }
        private void AddNewNameToList(string newName)
        {

            for (int i = 0; i < clientsNames.Length; i++)
            {
                if (string.IsNullOrEmpty(clientsNames[i]))
                {
                    clientsNames[i] = newName;
                    break;
                }
            }
        }

        private void AddNewAgeToList(int newAge)
        {
            for (int i = 0; i < clientsAges.Length; i++)
            {
                if (clientsAges[i] == 0)
                {
                    clientsAges[i] = newAge;
                    break;
                }
            }

        }

        private void AddNewBoolToList(bool isVegetarian)
        {

            for (int i = 0; i < vagie.Length; i++)
            {
                if (vagie[i] != isVegetarian)
                {
                    vagie[i] = isVegetarian;
                    break;
                }
            }
        }

        public void AddClient(string newName, int newAge, bool IsVeg)
        {
            AddNewNameToList(newName);
            AddNewAgeToList(newAge);
            AddNewBoolToList(IsVeg);
        }


        public string GetName(int index)
        {
            return clientsNames[index - 1];
        }

        public int GetAge(int index)
        {
            return clientsAges[index - 1];
        }
        public bool GetifisVeg(int index)
        {
            return vagie[index - 1];
        }
    }





}
