using MVVMDatabase.Core;
using MVVMDatabase.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDatabase.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public MainViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact { UID = Guid.NewGuid(), Name = "John" },
                new Contact { UID = Guid.NewGuid(), Name = "Kirill" },
                new Contact { UID = Guid.NewGuid(), Name = "Elena" }
            };
        }
    }
}
