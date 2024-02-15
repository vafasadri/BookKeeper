using System;
using System.Globalization;
using System.Windows.Forms;

namespace BookKeeper
{
    enum OnRecordDeleteAction
    {
        DeleteDependencies, Prompt
    }
    internal static class Utilities
    {
        static readonly PersianCalendar persianCalendar = new PersianCalendar();

        public static bool ConfirmViewClosing()
        {
            var result = MessageBox.Show(
                "تغییرات شما ذخیره نشده اند! آیا از بستن فرم مطمئن هستید؟",
                "هشدار",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );
            return result == DialogResult.Yes;
        }
        public static bool ConfirmRecordDeletion(string model)
        {
            var result = MessageBox.Show(
                $"آیا از حذف کردن این {model} مطمئن هستید؟",
                "هشدار",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );
            return result == DialogResult.Yes;
        }
        public static void FieldRequired(string fieldName)
        {
            MessageBox.Show(
                $"فیلد '{fieldName}' نمی تواند خالی باشد!",
                "خطا",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading
                );
        }
        public static void FieldInvalid(string fieldName, string errorMsg)
        {
            MessageBox.Show(
                $"مقدار فیلد'{fieldName}' معتبر نیست:\n {errorMsg}",
                "خطا",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading
                );
        }

        public static string ToPersianDate(DateTime dateTime)
        {
            return persianCalendar.GetYear(dateTime).ToString("0000") + "/" +
                persianCalendar.GetMonth(dateTime).ToString("00") +
                "/" + persianCalendar.GetDayOfMonth(dateTime).ToString("00");
        }
        public static bool FromPersianDate(string text, out DateTime output)
        {
            output = DateTime.MinValue;
            var split = text.Split('/');
            if (split.Length != 3) return false;
            if (!int.TryParse(split[0], out int year) || year < 0) return false;
            if (!int.TryParse(split[1], out int month) || month < 0 || month > 12) return false;
            if (!int.TryParse(split[2], out int day) || day < 0 || day > persianCalendar.GetDaysInMonth(year, month)) return false;
            output = persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
            return true;
        }
        //public static IEnumerable<Loan> GetLoansOfUser(this IRepository<Loan> repository, int id)
        //{
        //    return repository.GetAll().Where(n => n.UserId == id);
        //}
        //public static Loan? GetLoanOfBook(this IRepository<Loan> repository, int id)
        //{
        //    return repository.GetAll().Where(n => n.BookId == id).Cast<Loan?>().SingleOrDefault();
        //}
    }
}
