using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using StudentExercisesMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace StudentExercises.Models.ViewModels
{
    public class CohortCreateViewModel
    {
        public List<Cohort> Cohorts { get; set; }

        private readonly string _connectionString;

        private SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public CohortCreateViewModel() { }

        public CohortCreateViewModel(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}