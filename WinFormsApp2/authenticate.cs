﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace WinFormsApp2
{
    // Authentication class
    public class authenticate
    {
   
              
                public class User
                {
                    public string username { get; set; } // User's username property
                }

                /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
                * This is a good practice in software design, as it allows for better organization and maintainability. */
                public class DatabaseManager
                {
                    // Method to authenticate user
                    public static User AuthenticateUser(string username, string password)
                    {
                        User user = RetrieveUserInformation(username, password);
                        return user;
                    }

                    /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
                    * This method is private, meaning it is intended to be used only within the DatabaseManager class. */
                    private static User RetrieveUserInformation(string username, string password)
                    {
                        // Using statement ensures proper disposal of resources
                        using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC04\SQLEXPRESS; Initial Catalog=MovieCatalog; Integrated Security=True;"))
                        {
                            sqlCon.Open(); // Open SQL connection

                            string Query = "SELECT COUNT(1) FROM LogInInfo WHERE username=@username AND password=@password";

                            SqlCommand cmd = new SqlCommand(Query, sqlCon);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@username", username); // pass username parameter
                            cmd.Parameters.AddWithValue("@password", password); // pass password parameter

                            int count = Convert.ToInt32(cmd.ExecuteScalar()); // Execute query and get the count

                            if (count == 1)
                            {
                                // Return a User object with the retrieved information
                                return new User { username = username };
                            }
                            return null; // Return null if no user is found with the specified username and password
                        }
                    }
                }

            }
        }