// See https://aka.ms/new-console-template for more information

using AddressBook;

ContactManager contactList = new ContactManager();

contactList.Add();
contactList.Add();
contactList.Add();

contactList.DisplayAllRecords();
contactList.Search();
contactList.Delete();
contactList.DisplayAllRecords();
contactList.Update();