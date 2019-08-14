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

namespace StudentExercisesMVC.Controllers
{
    public class CohortsController : Controller
    {
        private readonly IConfiguration _config;

        public CohortsController(IConfiguration config)
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
        // GET: Cohorts
        public ActionResult Index()
        {
            List<Cohort> cohorts = new List<Cohort>();
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id, [Name]
                        FROM Cohort
                    ";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Cohort cohort = new Cohort
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            CohortName = reader.GetString(reader.GetOrdinal("Name"))
                        };

                        cohorts.Add(cohort);
                    }

                    reader.Close();
                }
            }
            return View(cohorts);
        }

        // GET: Cohorts/Details/5
        public ActionResult Details(int id)
        {
            Cohort cohort = GetSingleCohort(id);
            return View(cohort);
        }

        // GET: Cohorts/Create
        public ActionResult Create()
        {
            var viewModel = new CohortCreateViewModel(_config.GetConnectionString("DefaultConnection"));
            return View(viewModel);
        }

        // POST: Cohorts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cohort cohort)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            INSERT INTO Cohort (
                                [Name]
                            ) VALUES (
                                @name
                            )
                        ";

                        cmd.Parameters.AddWithValue("@name", cohort.CohortName);

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

        // GET: Cohorts/Edit/5
        public ActionResult Edit(int id)
        {
            Cohort cohort = GetSingleCohort(id);
            return View(cohort);
        }

        // POST: Cohorts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cohort cohort)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                        UPDATE Cohort
                        SET [Name] = @cohortName
                        WHERE Id = @id
                    ";
                        cmd.Parameters.Add(new SqlParameter("@cohortName", cohort.CohortName));
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cohorts/Delete/5
        public ActionResult Delete(int id)
        {
            Cohort cohort = GetSingleCohort(id);
            return View(cohort);
        }

        // POST: Cohorts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                        SELECT Id, [Name]
                        FROM Cohort
                        WHERE Id = @id
                    ";
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private Cohort GetSingleCohort(int id)
        {
            Cohort cohort = null;
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id, [Name]
                        FROM Cohort
                        WHERE Id = @id
                    ";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cohort = new Cohort()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            CohortName = reader.GetString(reader.GetOrdinal("Name"))
                        };
                    }

                    reader.Close();
                }
            }
            return cohort;
        }
    }
}