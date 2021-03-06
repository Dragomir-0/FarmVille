﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace DAL
{

        
    public class Datahandler: IDatahandlerDAL
    {
        #region Connections
        private string connectionstring;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable datatable;
        public Datahandler(string connectionstringP = "default")
        {
            this.connectionstring = ConfigurationManager.ConnectionStrings[connectionstringP].ConnectionString;
            connection = new SqlConnection(this.connectionstring);
        }

        #endregion

        #region PushData

        public void InsertUser(ArrayList userTableInfo)
        {
            string StoredProcedureName = "InsertNewUser";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", userTableInfo[0]));
                command.Parameters.Add(new SqlParameter("@Name", userTableInfo[1]));
                command.Parameters.Add(new SqlParameter("@Surname", userTableInfo[2]));
                command.Parameters.Add(new SqlParameter("@Gender", userTableInfo[3])); //hier
                command.Parameters.Add(new SqlParameter("@Password", userTableInfo[4]));
                command.Parameters.Add(new SqlParameter("@UserName", userTableInfo[5]));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            
        }
        public void InsertFarm(ArrayList farmTableInfo)
        {
            string StoredProcedureName = "InsertNewFarm";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", farmTableInfo[0]));
                command.Parameters.Add(new SqlParameter("@UserName", farmTableInfo[1]));
                command.Parameters.Add(new SqlParameter("@Size", farmTableInfo[2]));
                
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void InsertFarmAnimal(ArrayList animalTableInfo)
        {
            string StoredProcedureName = "InsertFarmAnimals";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Species", animalTableInfo[0]));
                command.Parameters.Add(new SqlParameter("@Gender", animalTableInfo[1]));
                command.Parameters.Add(new SqlParameter("@DateofBirth", animalTableInfo[2]));
                command.Parameters.Add(new SqlParameter("@FarmName", animalTableInfo[3]));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteDeadAnimal(ArrayList animalTableInfo)
        {
            //@Name   farmName
            string StoredProcedureName = "DeleteDeadAnimal";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", animalTableInfo[0]));
                command.Parameters.Add(new SqlParameter("@Species", animalTableInfo[1]));
                command.Parameters.Add(new SqlParameter("@DateofBirth", animalTableInfo[2]));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void InsertNewFarmAnimal(ArrayList animalTableInfo)
        {
            //AddNewFarmAnimal
            //@Species
            //@Name  FarmName
            //@Gender
            //@DateofBirth   string    format DD-MM-YYYY
            string StoredProcedureName = "DeleteDeadAnimal";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", animalTableInfo[0]));
                command.Parameters.Add(new SqlParameter("@Species", animalTableInfo[1]));
                command.Parameters.Add(new SqlParameter("@DateofBirth", animalTableInfo[2]));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        #endregion

        #region RetrieveData

        public DataTable AllUsers()
        {
            string StoredProcedureName = "SelectLoginDetails";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }

        public DataTable getUserInformation(string userName, string userPassword)
        {
            string StoredProcedureName = "UserInformation";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Username", userName));
                command.Parameters.Add(new SqlParameter("@Password", userPassword));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

        public DataTable getAnimalsNameAndType()
        {
            string StoredProcedureName = "SelectComboboxInfo";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }
        public DataTable getAnimalInfo(int animalID)
        {
            string StoredProcedureName = "SelectAnimalInformation";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID",animalID));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

        public DataTable getUserFarms(string userName)
        {
            string StoredProcedureName = "SelectUserFarms";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserName", userName));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

        public DataTable getUserFarmSize(string farmName)
        {
            //SelectFarmSize
            //@FarmName
            string StoredProcedureName = "SelectFarmSize";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@FarmName", farmName));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

        public DataTable getFarmAnimals(string farmName)
        {
            string StoredProcedureName = "SelectFarmAnimals";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@FarmName", farmName));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

        

        
        #endregion
    }
}

