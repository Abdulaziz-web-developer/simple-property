namespace PracticeOOP2.SchoolAutoEncapsulated
{
    public class SchoolAuto
    {
        private  int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private int _studentNumber;
        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }
            set
            {
                _studentNumber = value;
            }
        }
        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        private string _directorName;
        public string DirectorName
        {
            get
            {
                return _directorName;
            }
            set
            {
                _directorName = value;
            }
        }
        /*
        CREATE TABLE Persons (
        ID int,
        StudentNumber int,
        Address varchar,
        DirectorName varchar);
        */
    }
}