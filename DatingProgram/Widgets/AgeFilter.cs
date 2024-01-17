using System;
using System.Windows.Forms;

namespace DatingProgram.Widgets
{
    internal class AgeFilter
    {
        private NumericUpDown firstNumeric;
        private NumericUpDown secondNumeric;
        private Label labelPart1;
        private Label labelPart2;

        private bool intervalMode;

        private int BottomAge => (int)firstNumeric.Value;
        private int UpperAge => (int)secondNumeric.Value;

        private ProfilesDataGridView table;

        public AgeFilter(NumericUpDown firstNumeric,
            NumericUpDown secondNumeric, Label labelPart1, Label labelPart2,
            ProfilesDataGridView table)
        {
            this.firstNumeric = firstNumeric;
            this.secondNumeric = secondNumeric;
            this.labelPart1 = labelPart1;
            this.labelPart2 = labelPart2;

            this.table = table;
            intervalMode = true;
         }

        // Метод включает (true) или отключает (false) возраст в виде промежутка.
        public void SetIntervalMode(bool intervalMode)
        {
            this.intervalMode = intervalMode;

            UpdateLabels();

            secondNumeric.Enabled = intervalMode;
            secondNumeric.Visible = intervalMode;

            if (intervalMode)
                BottomValueChanged();
            else 
               
                UpdateTable();
        }

        // Метод, обновляющий элементы окна (true) или отключающий их (false)
        public void SetEnabled(bool enabled)
        {
            if (enabled)
            {
                firstNumeric.Enabled = true;
                SetIntervalMode(intervalMode);
            }
            else
            {
                firstNumeric.Enabled = false;
                secondNumeric.Enabled = false;
                labelPart1.Enabled = false;
                labelPart2.Enabled = false;
                table.SetFilterByAgeValue(-1);
            }
        }

        // Метод изменения нижней границы возраста
        public void BottomValueChanged()
        {
            if (intervalMode && BottomAge >= UpperAge)
                secondNumeric.Value = BottomAge + 1;

            UpdateTable();
        }
       
        // Метод изменения верхней границы возраста
        public void UpperValueChanged()
        {
            if (UpperAge <= BottomAge)
                firstNumeric.Value = UpperAge - 1;

            UpdateTable();
        }

        // Метод обновления подписей перед полями ввода возраста
        private void UpdateLabels()
        {
            labelPart1.Text = intervalMode ? "Возраст от" : "Возраст";
            labelPart2.Visible = intervalMode;
        }

        // Метод обновляющий таблицу table
        private void UpdateTable()
        {
            if (!intervalMode)
                table.SetFilterByAgeValue(BottomAge);
            else
                table.SetFilterByAgeInterval(BottomAge, UpperAge);
        }
    }
}
