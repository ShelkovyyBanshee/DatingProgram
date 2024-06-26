﻿using DatingProgram.Data;
using DatingProgram.DataTools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatingProgram.Widgets
{
    internal class ProfilesDataGridView
    { 
        public int ActiveUserId { get { return activeUserId; } set { activeUserId = value; } }

        private DataBase dataBase;

        private DataGridView dataGridView;
        private Label emptyTableLabel;

        private GenderFilterStatus genderFilterStatus;
        private string filterCityName;
        private int bottomOrSingleAge;
        private int upperAge;

        private int activeUserId;

        public ProfilesDataGridView(DataGridView dataGridView, Label emptyTableLabel)
        {
            dataBase = DataBaseAccess.InstantiateProfilesBase();

            this.dataGridView = dataGridView;
            this.emptyTableLabel = emptyTableLabel;

            genderFilterStatus = GenderFilterStatus.NoFilter;
            bottomOrSingleAge = upperAge = -1;
            filterCityName = "";
        }

        public void SetFilterByCity(string cityName) 
        {
            filterCityName = cityName;
            UpdateTable();
        }

        public void SetFilterByAgeValue(int ageValue)
        {
            bottomOrSingleAge = ageValue;
            upperAge = -1;
            UpdateTable();
        }

        public void SetFilterByAgeInterval(int bottomAgeValue, int upperAgeValue)
        {
            bottomOrSingleAge = bottomAgeValue;
            upperAge = upperAgeValue;
            UpdateTable();
        }

        public void SetGenderFilter(GenderFilterStatus filterStatus)
        {
            genderFilterStatus = filterStatus;
            UpdateTable();
        }

        public void UpdateTable() 
        {
            dataGridView.ClearSelection();
            dataBase.OpenConnection();

            DataTable tempTable = new DataTable();
            DataTable tableToShow = new DataTable();
            TableTools.AddColumnsToProfilesTable(tableToShow);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ActualProfiles", dataBase.Connection);
            adapter.Fill(tempTable);

            dataBase.CloseConnection();
            for (int i = 0; i < tempTable.Rows.Count; i++)
            {
                if (CheckRow(tempTable.Rows[i]))
                {
                    TableTools.IncludeRow(tableToShow, tempTable.Rows[i]);
                }
            }

            dataGridView.DataSource = tableToShow;

            emptyTableLabel.Visible = dataGridView.Rows.Count == 0;
        }

        private bool CheckRow(DataRow row)
        {
            return GenderCheck(row) && CityCheck(row) && AgeCheck(row) && IdCheck(row);
           
        }

        private bool GenderCheck(DataRow row)
        {
            return genderFilterStatus == GenderFilterStatus.NoFilter ||
                row.Field<String>("gender") == (genderFilterStatus == GenderFilterStatus.Male ? "М" : "Ж");
        }

        private bool CityCheck(DataRow row)
        {
            return filterCityName == "" || row.Field<String>("city") == filterCityName;
        }

        private bool AgeCheck(DataRow row)
        {
            int age = DateTimeTools.YearsBetween(row.Field<DateTime>("birthDay"), DateTime.UtcNow);

            if (bottomOrSingleAge != -1 && upperAge != -1)
                return age <= upperAge && age >= bottomOrSingleAge;
            else if (bottomOrSingleAge != -1)
                return age == bottomOrSingleAge;
            return true;
        }

        private bool IdCheck(DataRow row)
        {
            int id = row.Field<int>("regid");
            return id != ActiveUserId;
        }
    }
}
