namespace Infass_Vequiso.Models
{
    public class User
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;

        public string getquery(string[] fields, object[] values, string tb)
        {
            string fieldList = "";
            string valueList = "";

            for (int i = 0; i < fields.Length; i++)
            {
                fieldList += fields[i];

                if (i < fields.Length - 1)
                {
                    fieldList += ", ";
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] is string)
                {
                    valueList += "'" + values[i] + "'";
                }
                else
                {
                    valueList += values[i];
                }

                if (i < values.Length - 1)
                {
                    valueList += ", ";
                }
            }

            string query = "INSERT INTO " + tb +
                           " (" + fieldList + ")" +
                           " VALUES (" + valueList + ");";

            return query;
        }

        public string getloginquery(string[] fields, object[] values, string tb)
        {
            string conditionList = "";

            for (int i = 0; i < fields.Length; i++)
            {
                if (values[i] is string)
                {
                    conditionList += fields[i] + " = '" + values[i] + "'";
                }
                else
                {
                    conditionList += fields[i] + " = " + values[i];
                }

                if (i < fields.Length - 1)
                {
                    conditionList += " AND ";
                }
            }

            string query = "SELECT * FROM " + tb +
                           " WHERE " + conditionList + ";";

            return query;
        }
    }
}
