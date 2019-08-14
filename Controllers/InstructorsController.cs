using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentExercises.Models.ViewModels;
using StudentExercisesMVC.Models;
using StudentExercisesMVC.Models.ViewModels;

namespace StudentExercisesMVC.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly IConfiguration _config;

        public InstructorsController(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        // GET: Instructors
        public ActionResult Index()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id, FirstName, LastName, SlackHandle, CohortId, Specialty
                        FROM Instructor
                    ";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Instructor> instructors = new List<Instructor>();
                    while (reader.Read())
                    {
                        Instructor instructor = new Instructor
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                            CohortId = reader.GetInt32(reader.GetOrdinal("CohortId")),
                            Specialty = reader.GetString(reader.GetOrdinal("Specialty"))
                        };

                        instructors.Add(instructor);
                    }

                    reader.Close();

                    return View(instructors);
                }
            }
        }

        // GET: Instructors/Details/5
        public ActionResult Details(int id)
        {
            Instructor instructor = GetSingleInstructor(id);
            return View(instructor);
        }

        // GET: Instructors/Create
        public ActionResult Create()
        {
            var viewModel = new InstructorCreateViewModel(_config.GetConnectionString("DefaultConnection"));
            return View(viewModel);
        }

        // POST: Instructors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instructor instructor)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            INSERT INTO Instructor (
                                FirstName, 
                                LastName, 
                                SlackHandle,
                                CohortId,
                                Specialty
                            ) VALUES (
                                @firstName,
                                @lastName,
                                @slackHandle,
                                @cohortId,
                                @specialty
                            )
                        ";

                        cmd.Parameters.AddWithValue("@firstName", instructor.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", instructor.LastName);
                        cmd.Parameters.AddWithValue("@slackHandle", instructor.SlackHandle);
                        cmd.Parameters.AddWithValue("@cohortId", instructor.CohortId);
                        cmd.Parameters.AddWithValue("@specialty", instructor.Specialty);

                        cmd.ExecuteNonQuery();
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Instructors/Edit/5
        public ActionResult Edit(int id)
        {

            Instructor instructor = GetSingleInstructor(id);
            List<Cohort> cohorts = GetAllCohorts();
            var viewModel = new InstructorEditViewModel(instructor, cohorts);
            return View(viewModel);
        }

        // POST: Instructors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instructor instructor)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            UPDATE Instructor 
                            SET FirstName = @firstname,
                            SET LastName = @lastname,
                            SET SlackHandle = @slackhandle,
                            SET Specialty = @specialty
                            WHERE Id = @id
                            ";

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@firstName", instructor.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", instructor.LastName);
                        cmd.Parameters.AddWithValue("@slackHandle", instructor.SlackHandle);
                        cmd.Parameters.AddWithValue("@cohortId", instructor.CohortId);
                        cmd.Parameters.AddWithValue("@specialty", instructor.Specialty);

                        cmd.ExecuteNonQuery();
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Instructors/Delete/5
        public ActionResult Delete(int id)
        {
            Instructor instructor = GetSingleInstructor(id);
            return View(instructor);
        }

        // POST: Instructors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Instructor instructor)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            DELETE FROM StudentExercise
                            WHERE InstructorId = @id;
                            DELETE FROM Instructor 
                            WHERE Id = @id
                            ";

                        cmd.Parameters.Add(new SqlParameter("@id", instructor.Id));

                        cmd.ExecuteNonQuery();
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private List<Cohort> GetAllCohorts()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name FROM Cohort";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Cohort> cohorts = new List<Cohort>();
                    while (reader.Read())
                    {
                        cohorts.Add(new Cohort
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            CohortName = reader.GetString(reader.GetOrdinal("Name")),
                        });
                    }

                    reader.Close();

                    return cohorts;
                }
            }
        }

        private Instructor GetSingleInstructor(int id)
        {
            Instructor instructor = null;
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id, FirstName, LastName, SlackHandle, CohortId, Specialty
                        FROM Instructor
                        WHERE Id = @id
                    ";
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        instructor = new Instructor()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                            CohortId = reader.GetInt32(reader.GetOrdinal("CohortId")),
                            Specialty = reader.GetString(reader.GetOrdinal("Specialty"))
                        };
                    }

                    reader.Close();

                    return instructor;
                }
            }
        }
    }
}