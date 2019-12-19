using System;
using SplitWiseDB.Data.SplitWise;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SplitWise.Data
{
    public class BillService
    {

        private readonly SplitwiseContext _context;

        public BillService(SplitwiseContext context)
        {
            _context = context;
        }

        private static int _idNumber;
        public int IdNumber
        {
            get
            {
                return _idNumber;
            }
            set
            {
                _idNumber = value;
                NotifyDataChanged();
            }
        }

        private static Bill _bill;

        public Bill Bill
        {
            get
            {
                return _bill;
            }

            set
            {
                _bill = value;
                NotifyDataChanged();
            }
        }

        private static string _currency;

        public string Currency
        {
            get
            {
                return _currency;
            }

            set
            {
                _currency = value;
                NotifyDataChanged();
            }
        }

        private static string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyDataChanged();
            }
        }

        private static string _username;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                NotifyDataChanged();
            }
        }

        public event Action OnClick;
        private void NotifyDataChanged() => OnClick?.Invoke();

        public Task<List<Bill>>
            GetBillAsync(int intGroupId)
        {
            List<Bill> colBills =
                new List<Bill>(); 
            colBills =
                (from billTable in _context.Bill
                 where billTable.GroupId == intGroupId
                 select billTable).ToList();
            return Task.FromResult(colBills);
        }

        public Task<List<Bill>>
           GetMyBillsAsync(string strCurrentUser)
        {
            List<Bill> colBills =
                new List<Bill>();
            colBills =
                (from billTable in _context.Bill
                 where billTable.UserName == strCurrentUser
                 select billTable).ToList();
            return Task.FromResult(colBills);
        }

        public Task<Bill>
           CreateBillAsync(Bill objBill)
        {
            _context.Bill.Add(objBill);
            _context.SaveChanges();
            return Task.FromResult(objBill);
        }

        public Task<bool>
            UpdateBillAsync(Bill objBill)
        {
            var ExistingBill =
                _context.Bill
                .Where(x => x.Id == objBill.Id)
                .FirstOrDefault();
            if (ExistingBill != null)
            {
                ExistingBill.Date =
                    objBill.Date;
                ExistingBill.GroupName =
                    objBill.GroupName;
                ExistingBill.Split =
                    objBill.Split;
                ExistingBill.Amount =
                    objBill.Amount;
                ExistingBill.Description =
                    objBill.Description;
                ExistingBill.Currency =
                    objBill.Currency;

                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
           DeleteBillAsync(Bill objBill)
        {
            var ExistingBill =
                _context.Bill
                .Where(x => x.Id == objBill.Id)
                .FirstOrDefault();
            if (ExistingBill != null)
            {
                _context.Bill.Remove(ExistingBill);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}