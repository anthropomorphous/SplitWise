using System;
using SplitWiseDB.Data.SplitWise;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SplitWise.Data
{
    public class BillSplitService
    {

        private readonly SplitwiseContext _context;

        public BillSplitService(SplitwiseContext context)
        {
            _context = context;
        }

        private int _billId;
        public int NumberBillId
        {
            get
            {
                return _billId;
            }
            set
            {
                _billId = value;
                NotifyDataChanged();
            }
        }

        private string _recipient;
        public string RecipientName
        {
            get
            {
                return _recipient;
            }
            set
            {
                _recipient = value;
                NotifyDataChanged();
            }
        }

        public event Action OnClick;
        private void NotifyDataChanged() => OnClick?.Invoke();

        public Task<List<BillSplit>>
            GetBillSplitAsync(int intBillId)
        {
            List<BillSplit> colBills =
                new List<BillSplit>();           
            colBills =
                (from billSplitTable in _context.BillSplit
                 where billSplitTable.BillId == intBillId
                 select billSplitTable).ToList();
            return Task.FromResult(colBills);
        }

        public Task<List<BillSplit>>
          GetDebtAsync(string strCurrentUser)
        {
            List<BillSplit> colBillSplits =
                new List<BillSplit>();
            colBillSplits =
                (from billSplitTable in _context.BillSplit
                 where billSplitTable.RecipientName == strCurrentUser
                 select billSplitTable).ToList();
            return Task.FromResult(colBillSplits);
        }

        public Task<BillSplit>
           CreateBillSplitAsync(BillSplit objBillSplit)
        {
            _context.BillSplit.Add(objBillSplit);
            _context.SaveChanges();
            return Task.FromResult(objBillSplit);
        }

        public Task<bool>
            UpdateBillSplitAsync(BillSplit objBillSplit)
        {
            var ExistingBillSplit =
                _context.BillSplit
                .Where(x => x.Id == objBillSplit.Id)
                .FirstOrDefault();
            if (ExistingBillSplit != null)
            {
                ExistingBillSplit.Date =
                    objBillSplit.Date;
                ExistingBillSplit.RecipientName =
                    objBillSplit.RecipientName;
                ExistingBillSplit.Amount =
                    objBillSplit.Amount;
                ExistingBillSplit.UserName =
                    objBillSplit.UserName;
                ExistingBillSplit.Description =
                    objBillSplit.Description;
                ExistingBillSplit.Currency =
                    objBillSplit.Currency;

                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteBillSplitAsync(BillSplit objBillSplit)
        {
            var ExistingBillSplit =
                _context.BillSplit
                .Where(x => x.Id == objBillSplit.Id)
                .FirstOrDefault();
            if (ExistingBillSplit != null)
            {
                _context.BillSplit.Remove(ExistingBillSplit);
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