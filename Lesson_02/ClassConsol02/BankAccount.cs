using System;

namespace Finances
{
    class BankAccount
    {
        private static Guid _accountNumber;
        private float _balance;
        private string _typeOfBankAccount;
        private enum typeOfBankAccount
        {
            TotalScore = 0,                 // Общий счёт
            ForeignCurrencyAccount = 1,     // Валютный счёт
            CorrespondentAccount = 2,       // Корреспондентский счёт
            CheckingAccount = 3,            // Расчётный счёт
            SavingsAccount = 4              // Сберегательный счёт
        }

        private float _sum;

        ConsoleLine consoleLine = new ConsoleLine();

        public string TypeOfBankAccount
        {
            get
            {
                return _typeOfBankAccount;
            }

            set
            {
                _typeOfBankAccount = value;
            }
        }

        public Guid AccountNumber 
        {
            get
            {
                return _accountNumber = Guid.NewGuid();
            }
        }

        public float Balance 
        { 
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            } 
        }

        public float Sum
        {
            get
            {
                return _sum;
            }

            set
            {
                _sum = value;
            }
        }


        public BankAccount() : this(0)
        {

        }

        public BankAccount(float balance) : this(0)
        {
            _balance = balance;
        }

        public BankAccount(int typeOfBankAccount) : this(typeOfBankAccount, 0)
        {
            _typeOfBankAccount =
                Enum.GetName(typeof(typeOfBankAccount), typeOfBankAccount);
        }

        public BankAccount(int typeOfBankAccount, float balance)
        {
            _typeOfBankAccount =
                Enum.GetName(typeof(typeOfBankAccount), typeOfBankAccount);
            _balance = balance;
        }

        public float SumRead()
        {
            Console.ResetColor();
            var sum = float.Parse(Console.ReadLine().Trim());
            return sum;
        }

        public float UpLoad(float balance)
        {
            consoleLine.InputSum(ConsoleColor.White, "Сумма пополнения: ");
            _balance += SumRead();

            consoleLine.WriteEnd(ConsoleColor.Green, "Успешно!");

            return _balance; 
        }

        public float DownLoad(float balance)
        {
            consoleLine.InputSum(ConsoleColor.White, "Сумма снятия: ");
            var sum = SumRead();
            if (_balance < sum)
            {
                consoleLine.WriteEnd(ConsoleColor.Red, "Недостаточно средств!");
            }
            else
            {
                consoleLine.WriteEnd(ConsoleColor.Green, "Успешно!");
                _balance -= sum;
            }

            return _balance;
        }
    }
}
