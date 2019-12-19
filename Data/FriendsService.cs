using System;
using SplitWiseDB.Data.SplitWise;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SplitWise.Data
{
    public class FriendsService
    {

        private readonly SplitwiseContext _context;

        public FriendsService(SplitwiseContext context)
        {
            _context = context;
        }

        private int _idNumber;
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


        public event Action OnClick;
        private void NotifyDataChanged() => OnClick?.Invoke();

        public Task<List<FriendsTable>>
            GetFriendsAsync(string strCurrentUser)
        {
            List<FriendsTable> colFriends =
                new List<FriendsTable>(); 
            colFriends =
                (from friendsTable in _context.FriendsTable
                 where friendsTable.UserName == strCurrentUser
                 select friendsTable).ToList();
            return Task.FromResult(colFriends);
        }

        //public Task<List<AspNetUsers>>
        //    GetFriendsIdAsync(string strCurrentUser)
        //{
        //    List<AspNetUsers> colUsers =
        //        new List<AspNetUsers>();
        //    colUsers =
        //        (from usersTable in _context.FriendsTable
        //         where usersTable.UserName ==
        //         select usersTable).ToList();

        //    List<FriendsTable> colFriends =
        //        new List<FriendsTable>();

        //    return Task.FromResult(colUsers);
        //}

        public Task<FriendsTable>
           CreateFriendsTableAsync(FriendsTable objFriendsTable)
        {
            _context.FriendsTable.Add(objFriendsTable);
            _context.SaveChanges();
            return Task.FromResult(objFriendsTable);
        }

        public Task<bool>
            UpdateFriendsTableAsync(FriendsTable objFriendsTable)
        {
            var ExistingFriendsTable =
                _context.FriendsTable
                .Where(x => x.Id == objFriendsTable.Id)
                .FirstOrDefault();

            if (ExistingFriendsTable != null)
            {
                ExistingFriendsTable.FriendName =
                    objFriendsTable.FriendName;
                ExistingFriendsTable.UserName =
                    objFriendsTable.UserName;
                ExistingFriendsTable.FriendId =
                    objFriendsTable.FriendId;
                ExistingFriendsTable.UserId =
                    objFriendsTable.UserId;

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