﻿namespace Inheritance
{
    public sealed class Handyman : Employee
    {
        public decimal Hardship { get; set; }


        protected override decimal CalculateGrossPay()
        {
            return base.CalculateGrossPay() + Hardship;
        }

        public override string ShowSalarySlip()
        {
            decimal basicSalary = CalculateBasicSalary();
            decimal grossSalary = CalculateGrossPay();
            decimal taxAmount = CalculateTaxAmount();
            decimal netSalary = CalculateNetSalary();
            decimal overtime = CalculateOvertimeAmount();

            return $"Employee: #{Id} ({FullName}).\n" +
            $"Hours Logged: {LoggedHours} hrs.\n" +
            $"Hourly rate: {HourlyRate.ToString("C")} /hr.\n" +
            $"Basic Salary: {basicSalary.ToString("C")}\n" +
            $"Overtime({HRConstants.OvertimeRate}x): {overtime.ToString("C")}\n" +
            $"Hardship: {Hardship.ToString("C")}\n" +
            $"Gross Pay: {grossSalary.ToString("C")}\n" +
            $"Tax Amount ({HRConstants.TaxRate.ToString("%0")}): {taxAmount.ToString("C")}\n" +
            $"-------------------------------------\n" +
            $"Net Salary: {netSalary.ToString("C")}";
        }
    }
}