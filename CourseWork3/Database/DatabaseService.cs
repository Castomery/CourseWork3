using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CourseWork3.Models;
using System.Data;
using System.Windows;

namespace CourseWork3.Database
{
    public class DatabaseService
    {
        private const string PATH = "myDB.db";
        private const string CONNECTIONSTRING = "Data Source=" + PATH;

        private SQLiteConnection _connection;

        private static DatabaseService _instance;
        public static DatabaseService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseService();
                }
                return _instance;
            }
        }

        public DatabaseService()
        {
            _connection = new SQLiteConnection(CONNECTIONSTRING);
        }

        public void ExecuteQuery(string query)
        {
            _connection.Open();
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataView ExecuteCustomQuery(string query)
        {
            _connection.Open();
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable datatable = new DataTable("DataTable");
            try
            {
                adapter.Fill(datatable);
                _connection.Close();
            }
            catch (SQLiteException)
            {

                MessageBox.Show("Query error");
                _connection.Close();
            }

            return datatable.DefaultView;
        }

        #region contacts
        public void CreateContact(string name, string phone, string email)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Contacts (fullname,phoneNumber,email)");
            query.Append($"VALUES (\"{name}\",\"{phone}\",\"{email}\")");
            ExecuteQuery(query.ToString());
        }

        public List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();

            string query = "SELECT * FROM Contacts";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contacts.Add(new Contact(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
            }
            _connection.Close();

            return contacts;
        }

        public void DeleteContact(int contactId)
        {
            string query = $"DELETE FROM Contacts WHERE id={contactId}";
            ExecuteQuery(query);

        }
        #endregion

        #region positions
        public void CreatePosition(string name)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Positions (position_name)");
            query.Append($"VALUES (\"{name}\")");
            ExecuteQuery(query.ToString());
        }

        public List<Position> GetAllPositions()
        {
            List<Position> positions = new List<Position>();

            string query = "SELECT * FROM Positions";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                positions.Add(new Position(reader.GetInt32(0), reader.GetString(1)));
            }
            _connection.Close();

            return positions;
        }

        public void DeletePosition(int positionId)
        {
            string query = $"DELETE FROM Positions WHERE id={positionId}";
            ExecuteQuery(query);

        }
        #endregion

        #region locations
        public void CreateLocation(string address)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Locations (address)");
            query.Append($"VALUES (\"{address}\")");
            ExecuteQuery(query.ToString());
        }

        public List<Location> GetAllLocations()
        {
            List<Location> locations = new List<Location>();

            string query = "SELECT * FROM Locations";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                locations.Add(new Location(reader.GetInt32(0), reader.GetString(1)));
            }
            _connection.Close();

            return locations;
        }

        public void DeleteLocation(int locationId)
        {
            string query = $"DELETE FROM Locations WHERE id={locationId}";
            ExecuteQuery(query);

        }
        #endregion

        #region types of department
        public void CreateTypeOfDepartment(string name)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Types_Of_Department (name)");
            query.Append($"VALUES (\"{name}\")");
            ExecuteQuery(query.ToString());
        }

        public List<TypeOfDepartment> GetAllTypesOfDepartment()
        {
            List<TypeOfDepartment> typesOfDepartment = new List<TypeOfDepartment>();

            string query = "SELECT * FROM Types_Of_Department";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                typesOfDepartment.Add(new TypeOfDepartment(reader.GetInt32(0), reader.GetString(1)));
            }
            _connection.Close();

            return typesOfDepartment;
        }

        public void DeleteTypeOfDepartment(int serviceId)
        {
            string query = $"DELETE FROM Types_Of_Department WHERE id={serviceId}";
            ExecuteQuery(query);

        }
        #endregion

        #region departments
        public void CreateDepartment(string name, int serviceId, int locationId)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Departments (name,type_of_department_id,location_id)");
            query.Append($"VALUES (\"{name}\",\"{serviceId}\",\"{locationId}\")");
            ExecuteQuery(query.ToString());
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            string query = "SELECT * FROM Departments";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                departments.Add(new Department(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)));
            }
            _connection.Close();

            return departments;
        }

        public void DeleteDepartment(int departmentId)
        {
            string query = $"DELETE FROM Departments WHERE id={departmentId}";
            ExecuteQuery(query);
        }
        #endregion

        #region faculties
        public void CreateFaculty(string name, int locationId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Faculties (name,location_id,contact_id)");
            query.Append($"VALUES (\"{name}\",\"{locationId}\",\"{contactId}\")");
            ExecuteQuery(query.ToString());
        }

        public List<Faculty> GetAllFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();

            string query = "SELECT * FROM Faculties";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                faculties.Add(new Faculty(reader.GetInt32(0), reader.GetString(1), 
                    reader.GetInt32(2), 
                    (reader.IsDBNull(3) ? null : reader.GetInt32(3))));
            }
            _connection.Close();

            return faculties;
        }

        public void DeleteFaculty(int facultyId)
        {
            string query = $"DELETE FROM Faculties WHERE id={facultyId}";
            ExecuteQuery(query);

        }

        public void EditFaculty(int currId, string name, int locationId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE Faculties SET name = \"{name}\", location_id=\"{locationId}\", contact_id=\"{contactId}\"");
            query.Append($"WHERE id = {currId}");
            ExecuteQuery(query.ToString());
        }
        #endregion

        #region faculty departments
        public void CreateFacultyDepartment(string name, int facultyId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Faculty_Departments (name,faculty_id,contact_id)");
            query.Append($"VALUES (\"{name}\",\"{facultyId}\",\"{contactId}\")");
            ExecuteQuery(query.ToString());
        }

        public List<FacultyDepartment> GetAllFacultyDepartments()
        {
            List<FacultyDepartment> facultyDepartments = new List<FacultyDepartment>();

            string query = "SELECT * FROM Faculty_Departments";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                facultyDepartments.Add(new FacultyDepartment(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), (reader.IsDBNull(3) ? null : reader.GetInt32(3))));
            }
            _connection.Close();

            return facultyDepartments;
        }

        public void DeleteFacultyDepartment(int facultydepartmentId)
        {
            string query = $"DELETE FROM Faculty_Departments WHERE id={facultydepartmentId}";
            ExecuteQuery(query);

        }

        public void EditFacultyDepartment(int currId, string name, int facultyId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE Faculty_Departments SET name = \"{name}\", faculty_id=\"{facultyId}\", contact_id=\"{contactId}\"");
            query.Append($"WHERE id = {currId}");
            ExecuteQuery(query.ToString());
        }
        #endregion

        #region department contacts
        public void CreateDepartmentContact(int departmentId, int positionId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Department_Contacts (department_id,position_id,contact_id)");
            query.Append($"VALUES (\"{departmentId}\",\"{positionId}\",\"{contactId}\")");
            ExecuteQuery(query.ToString());
        }

        public List<DepartmentContact> GetAllDepartmentContacts()
        {
            List<DepartmentContact> departmentContacts = new List<DepartmentContact>();

            string query = "SELECT * FROM Department_Contacts";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                departmentContacts.Add(new DepartmentContact(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
            }
            _connection.Close();

            return departmentContacts;
        }

        public void DeleteDepartmentContact(int departmentContactId)
        {
            string query = $"DELETE FROM Department_Contacts WHERE id={departmentContactId}";
            ExecuteQuery(query);
        }

        public void EditDepartmentContact(int currId, int departmentId, int positionId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE Department_Contacts SET department_id = \"{departmentId}\", position_id=\"{positionId}\", contact_id=\"{contactId}\"");
            query.Append($"WHERE id = {currId}");
            ExecuteQuery(query.ToString());
        }
        #endregion

        #region faculty contacts
        public void CreateFacultyContact(int facultyId, int positionId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Faculty_Contacts (faculty_id,position_id,contact_id)");
            query.Append($"VALUES (\"{facultyId}\",\"{positionId}\",\"{contactId}\")");
            ExecuteQuery(query.ToString());
        }

        public List<FacultyContact> GetAllFacultyContacts()
        {
            List<FacultyContact> facultyContacts = new List<FacultyContact>();

            string query = "SELECT * FROM Faculty_Contacts";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                facultyContacts.Add(new FacultyContact(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
            }
            _connection.Close();

            return facultyContacts;
        }

        public void DeleteFacultyContact(int facultyContactId)
        {
            string query = $"DELETE FROM Faculty_Contacts WHERE id={facultyContactId}";
            ExecuteQuery(query);
        }

        public void EditFacultyContact(int currId, int facultyId, int positionId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE Faculty_Contacts SET faculty_id = \"{facultyId}\", position_id=\"{positionId}\", contact_id=\"{contactId}\"");
            query.Append($"WHERE id = {currId}");
            ExecuteQuery(query.ToString());
        }
        #endregion

        #region faculty department contacts
        public void CreateFacultyDepartmentContact(int facultyDepartmentId, int positionId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO Faculty_Department_Contacts (faculty_department_id,position_id,contact_id)");
            query.Append($"VALUES (\"{facultyDepartmentId}\",\"{positionId}\",\"{contactId}\")");
            ExecuteQuery(query.ToString());
        }

        public List<FacultyDepartmentContact> GetAllFacultyDepartmentContacts()
        {
            List<FacultyDepartmentContact> facultyDepartmentContacts = new List<FacultyDepartmentContact>();

            string query = "SELECT * FROM Faculty_Department_Contacts";

            _connection.Open();
            using SQLiteCommand cmd = new SQLiteCommand(query, _connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                facultyDepartmentContacts.Add(new FacultyDepartmentContact(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
            }
            _connection.Close();

            return facultyDepartmentContacts;
        }

        public void DeleteFacultyDepartmentContact(int facultyDepartmentContactId)
        {
            string query = $"DELETE FROM Faculty_Department_Contacts WHERE id={facultyDepartmentContactId}";
            ExecuteQuery(query);
        }

        public void EditFacultyDepartmentContact(int currId, int facultydepartmentId, int positionId, int contactId)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE Faculty_Department_Contacts SET faculty_department_id = \"{facultydepartmentId}\", position_id=\"{positionId}\", contact_id=\"{contactId}\"");
            query.Append($"WHERE id = {currId}");
            ExecuteQuery(query.ToString());
        }
        #endregion
    }
}
