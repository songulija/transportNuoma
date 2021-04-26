using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportoNuoma.Classes;

namespace TransportoNuoma.Repositories
{
    class UsersRepository
    {
        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;database=lsongulija";
        SqlConnection cnn;


        //REGISTER STUDENT
        public Klientas RegisterClient(Klientas klientas)//provide student object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new SqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                SqlCommand cmd = new SqlCommand("Select * from klientas where email=@email", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@email", klientas.email);
                SqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))//if dataReader.Read is true then it means that it found User with that Username
                {
                    //then User with that Username already exists
                    Console.WriteLine("User with that Username already exists");
                    return null;//if username exist than it will not watch script bellow, it will just return
                }

                else//there is no user with that Username that we want to register
                {
                    //so we can register user
                    Console.WriteLine("Username is free so you can register");
                }
                dataReader.Close();//close data reader when it finishes work

                SqlCommand cmd1 = new SqlCommand("Insert into klientas (Vardas,Pavarde,Asmens_Kodas,email,slaptazodis) VALUES(@Vardas,@Pavarde,@Asmens_Kodas,@email,@slaptazodis)", cnn);
                cmd1.Parameters.AddWithValue("@Vardas", klientas.vardas);
                cmd1.Parameters.AddWithValue("@Pavarde", klientas.pavarde);
                cmd1.Parameters.AddWithValue("@Asmens_Kodas", klientas.kodas);
                cmd1.Parameters.AddWithValue("@email", klientas.email);
                cmd1.Parameters.AddWithValue("@slaptazodis", klientas.pavarde);

                cmd1.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return klientas;//return 
        }

        /*
        public Student LoginStudent(string username, string password)
        {
            Student student = new Student();
            try
            {

                //STUDENT
                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select StudentId,FirstName,LastName,GroupId FROM StudentsTable where Username=@Username AND Password=@Password", cnn);
                //parametrised Sql Command, have to provide values that we wrote
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();//we want to read rows that we get with this command
                while (reader.Read())//while reader can read, while there is information/rows of data
                {
                    //get all values from row
                    int StudentId = int.Parse(reader["StudentId"].ToString());
                    string FirstName = reader["FirstName"].ToString();
                    string LastName = reader["LastName"].ToString();
                    int GroupId = int.Parse(reader["GroupId"].ToString());

                    //create Student object

                    student.StudentId = StudentId;
                    student.FirstName = FirstName;
                    student.LastName = LastName;
                    student.Username = username;
                    student.Password = password;
                    student.GroupId = GroupId;

                }

                cnn.Close();
                Console.WriteLine(student.Password);
                return student;

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }

        }
        */


    }
}
