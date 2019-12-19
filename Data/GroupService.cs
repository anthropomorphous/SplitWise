using System;
using SplitWiseDB.Data.SplitWise;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SplitWise.Data
{
    public class GroupService
    {
        private readonly SplitwiseContext _context;
        public GroupService(SplitwiseContext context)
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

        private Group _group;

        public Group Group
        {
            get
            {
                return _group;
            }

            set
            {
                _group = value;
                NotifyDataChanged();
            }
        }

        private string _groupname;
        public string Name
        {
            get
            {
                return _groupname;
            }
            set
            {
                _groupname = value;
                NotifyDataChanged();
            }
        }

        public event Action OnClick;
        private void NotifyDataChanged() => OnClick?.Invoke();

        public Task<List<Group>>
            GetGroupAsync(string strCurrentUser)
        {
            List<Group> colGroups =
                new List<Group>();
            // Get groups  
            colGroups =
                (from groupTable in _context.Group
                     // only get entries for the current logged in user
                 where groupTable.UserName == strCurrentUser
                 select groupTable).ToList();
            return Task.FromResult(colGroups);
        }

        public Task<Group>
           CreateGroupAsync(Group objGroup)
        {
            _context.Group.Add(objGroup);
            _context.SaveChanges();
            return Task.FromResult(objGroup);
        }

        public Task<bool>
            UpdateGroupAsync(Group objGroup)
        {
            var ExistingGroup =
                _context.Group
                .Where(x => x.Id == objGroup.Id)
                .FirstOrDefault();
            if (ExistingGroup != null)
            {
                ExistingGroup.Date =
                    objGroup.Date;
                ExistingGroup.GroupName =
                    objGroup.GroupName;

                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteGroupAsync(Group objGroup)
        {
            var ExistingGroup =
                _context.Group
                .Where(x => x.Id == objGroup.Id)
                .FirstOrDefault();
            if (ExistingGroup != null)
            {
                _context.Group.Remove(ExistingGroup);
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