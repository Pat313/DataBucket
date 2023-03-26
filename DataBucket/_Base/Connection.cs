using System.Configuration;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace DataBucket._Base
{
    public class Connection
    {
        public static Connection Instance { get; } = new();

        #region Establishing & terminating connection
        // connectionstring
        //private MySqlConnectionStringBuilder conString = new MySqlConnectionStringBuilder();
        private readonly MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con_mobil33acc"].ConnectionString);
        /*MySqlConnectionStringBuilder builder = new();
        builder.Server = "192.168.100.2";
        builder.Database = "mobil33acc";
        builder.UserID = "root";
        builder.Password = string.Empty;
        builder.SslMode = MySqlSslMode.Disabled;*/
        //private readonly MySqlConnection con = new MySqlConnection("server=192.168.100.2; database=mobil33acc; uid=root; password=; sslmode = none");
        //private readonly ImageManager imageManager = ImageManager.Instance;

        /*private static Connection? instance;
        public static Connection Instance => instance ??= new Connection();*/
        //get => instance ?? (instance = new Connection());
        //set => connection = value;

        private async Task Connect() //=> await Task.Run(async () =>
        {
            try { if (con.State != ConnectionState.Open) await con.OpenAsync(); }
            catch (Exception ex) { MessageBox.Show("Hiba csatlakozáskor!\n" + ex); }

            
        }//);

        private async Task Close()
        {
            try { if (con.State != ConnectionState.Closed) await con.CloseAsync(); }
            catch (Exception ex) { MessageBox.Show("Hiba lecsatlakozáskor!\n" + ex); }
        }
        #endregion

        #region Fill & Get controls
        public async Task<long> GetWorkAll(MonthCalendar cld)
        {
            long count = 0;
            string dateQuery;
            if (cld.SelectionStart == cld.SelectionEnd) dateQuery = $"LIKE '{cld.SelectionStart:yyyy-MM-dd}'";
            else dateQuery = $"BETWEEN '{cld.SelectionStart:yyyy-MM-dd}' AND '{cld.SelectionEnd:yyyy-MM-dd}'";

            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(*) FROM work " +
                $"WHERE date {dateQuery}",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }

        public async Task<long> GetWork(MonthCalendar cld, ComboBox cmb1, ComboBox cmb2)
        {
            long count = 0;
            string dateQuery;
            if (cld.SelectionStart == cld.SelectionEnd) dateQuery = $"LIKE '{cld.SelectionStart:yyyy-MM-dd}'";
            else dateQuery = $"BETWEEN '{cld.SelectionStart:yyyy-MM-dd}' AND '{cld.SelectionEnd:yyyy-MM-dd}'";

            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(*) FROM work " +
                $"WHERE date {dateQuery} " +
                $"AND ((repairmanID = (SELECT id FROM worker WHERE fullName LIKE '{cmb1.Text}') " +
                $"AND concomitantID = (SELECT id FROM worker WHERE fullName LIKE '{cmb2.Text}')) " +
                $"OR (repairmanID = (SELECT id FROM worker WHERE fullName LIKE '{cmb2.Text}') " +
                $"AND concomitantID = (SELECT id FROM worker WHERE fullName LIKE '{cmb1.Text}'))) ",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }
        
        public async Task<long> GetWorkByWorker(MonthCalendar cld, ComboBox cmb)
        {
            long count = 0;
            string dateQuery;
            if (cld.SelectionStart == cld.SelectionEnd) dateQuery = $"LIKE '{cld.SelectionStart:yyyy-MM-dd}'";
            else dateQuery = $"BETWEEN '{cld.SelectionStart:yyyy-MM-dd}' AND '{cld.SelectionEnd:yyyy-MM-dd}'";

            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(*) FROM work " +
                $"WHERE date {dateQuery} " +
                $"AND (repairmanID = (SELECT id FROM worker WHERE fullName LIKE '{cmb.Text}') " +
                $"OR concomitantID = (SELECT id FROM worker WHERE fullName LIKE '{cmb.Text}'))",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }

        public async Task<long> GetAccountingAll(ComboBox cmb, DateTimePicker date1, DateTimePicker date2)
        {
            long count = 0;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(*) FROM work AS w " +
                $"INNER JOIN worker AS w1 ON w.repairmanID = w1.id " +
                $"INNER JOIN worker AS w2 ON w.concomitantID = w2.id " +
                $"WHERE (w1.fullName LIKE '{cmb.Text}' OR w2.fullName LIKE '{cmb.Text}') " +
                $"AND (w.date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}')",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }

        public async Task<long> GetAccountingDaily(ComboBox cmb, DateTimePicker date1, DateTimePicker date2)
        {
            long count = 0;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(DISTINCT date) FROM work AS w " +
                $"INNER JOIN worker AS w1 ON w.repairmanID = w1.id " +
                $"INNER JOIN worker AS w2 ON w.concomitantID = w2.id " +
                $"WHERE (w1.fullName LIKE '{cmb.Text}' OR w2.fullName LIKE '{cmb.Text}') " +
                $"AND (w.date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}')",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }

        public async Task<long> GetAccountingMonthly(ComboBox cmb, DateTimePicker date1, DateTimePicker date2)
        {
            long count = 0;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(DISTINCT MONTH(date)) FROM work AS w " +
                $"INNER JOIN worker AS w1 ON w.repairmanID = w1.id " +
                $"INNER JOIN worker AS w2 ON w.concomitantID = w2.id " +
                $"WHERE (w1.fullName LIKE '{cmb.Text}' OR w2.fullName LIKE '{cmb.Text}') " +
                $"AND (w.date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}')",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }

        public async Task<long> GetLiabilities(DateTimePicker date1, DateTimePicker date2, CheckBox chb)
        {
            long count = 0;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT COUNT(*) FROM work " +
                $"WHERE (date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}') " +
                $"AND transaction = 1 AND receipt = 1{(chb.Checked ? "" : " AND paid = 0")}",
                con))
                count = (long)await cmd.ExecuteScalarAsync();

            await Close();
            return count;
        }

        public async Task FillWorkAll(DataGridView dg, byte limit, short page, MonthCalendar cld)
        {
            string dateQuery;
            if (cld.SelectionStart == cld.SelectionEnd) dateQuery = $"LIKE '{cld.SelectionStart:yyyy-MM-dd}'";
            else dateQuery = $"BETWEEN '{cld.SelectionStart:yyyy-MM-dd}' AND '{cld.SelectionEnd:yyyy-MM-dd}'";

            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT id, name AS 'Név', address AS 'Cím', phone AS 'Telefonszám', invoice as 'Számlaszám', income AS 'Bevétel', material AS 'Anyagköltség', " +
                $"fuel AS 'Üzemanyag', other AS 'Egyéb kiadás', transaction AS 'Fizetésmód', receipt AS 'Számlázás', paid AS 'Törlesztés', imagerefs FROM work " +
                $"WHERE date {dateQuery} " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillWork(DataGridView dg, byte limit, short page, MonthCalendar cld, ComboBox cmb1, ComboBox cmb2)
        {
            string dateQuery;
            if (cld.SelectionStart == cld.SelectionEnd) dateQuery = $"LIKE '{cld.SelectionStart:yyyy-MM-dd}'";
            else dateQuery = $"BETWEEN '{cld.SelectionStart:yyyy-MM-dd}' AND '{cld.SelectionEnd:yyyy-MM-dd}'";

            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT id, name AS 'Név', address AS 'Cím', phone AS 'Telefonszám', invoice as 'Számlaszám', income AS 'Bevétel', material AS 'Anyagköltség', " +
                $"fuel AS 'Üzemanyag', other AS 'Egyéb kiadás', transaction AS 'Fizetésmód', receipt AS 'Számlázás', paid AS 'Törlesztés', imagerefs FROM work " +
                $"WHERE date {dateQuery} " +
                $"AND ((repairmanID = (SELECT id FROM worker WHERE fullName LIKE '{cmb1.Text}') " +
                $"AND concomitantID = (SELECT id FROM worker WHERE fullName LIKE '{cmb2.Text}')) " +
                $"OR (repairmanID = (SELECT id FROM worker WHERE fullName LIKE '{cmb2.Text}') " +
                $"AND concomitantID = (SELECT id FROM worker WHERE fullName LIKE '{cmb1.Text}'))) " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillWorkByWorker(DataGridView dg, byte limit, short page, MonthCalendar cld, ComboBox cmb)
        {
            string dateQuery;
            if (cld.SelectionStart == cld.SelectionEnd) dateQuery = $"LIKE '{cld.SelectionStart:yyyy-MM-dd}'";
            else dateQuery = $"BETWEEN '{cld.SelectionStart:yyyy-MM-dd}' AND '{cld.SelectionEnd:yyyy-MM-dd}'";

            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT id, name AS 'Név', address AS 'Cím', phone AS 'Telefonszám', invoice as 'Számlaszám', income AS 'Bevétel', material AS 'Anyagköltség', " +
                $"fuel AS 'Üzemanyag', other AS 'Egyéb kiadás', transaction AS 'Fizetésmód', receipt AS 'Számlázás', paid AS 'Törlesztés', imagerefs FROM work " +
                $"WHERE date {dateQuery} " +
                $"AND (repairmanID = (SELECT id FROM worker WHERE fullName LIKE '{cmb.Text}') " +
                $"OR concomitantID = (SELECT id FROM worker WHERE fullName LIKE '{cmb.Text}')) " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillWorker(DataGridView dg)
        {
            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                "SELECT firstName AS 'Vezetéknév', lastName AS 'Keresztnév', fullName AS 'Név' FROM worker",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillAccountingAll(DataGridView dg, byte limit, short page, ComboBox cmb, DateTimePicker date1, DateTimePicker date2)
        {
            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT w.date AS 'Dátum', w.delivered AS 'Bugyi', w.final AS 'Leadó' FROM work AS w " +
                $"INNER JOIN worker AS w1 ON w.repairmanID = w1.id " +
                $"INNER JOIN worker AS w2 ON w.concomitantID = w2.id " +
                $"WHERE (w1.fullName LIKE '{cmb.Text}' OR w2.fullName LIKE '{cmb.Text}') " +
                $"AND (w.date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}') " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillAccountingDaily(DataGridView dg, byte limit, short page, ComboBox cmb, DateTimePicker date1, DateTimePicker date2)
        {
            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT w.date AS 'Nap', SUM(w.delivered) AS 'Bugyi', SUM(w.final) AS 'Leadó' FROM work AS w " +
                $"INNER JOIN worker AS w1 ON w.repairmanID = w1.id " +
                $"INNER JOIN worker AS w2 ON w.concomitantID = w2.id " +
                $"WHERE (w1.fullName LIKE '{cmb.Text}' OR w2.fullName LIKE '{cmb.Text}') " +
                $"AND (w.date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}') " +
                $"GROUP BY date " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillAccountingMonthly(DataGridView dg, byte limit, short page, ComboBox cmb, DateTimePicker date1, DateTimePicker date2)
        {
            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT w.date AS 'Hónap', SUM(w.final) AS 'Leadó' FROM work AS w " +
                $"INNER JOIN worker AS w1 ON w.repairmanID = w1.id " +
                $"INNER JOIN worker AS w2 ON w.concomitantID = w2.id " +
                $"WHERE (w1.fullName LIKE '{cmb.Text}' OR w2.fullName LIKE '{cmb.Text}') " +
                $"AND (w.date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}') " +
                $"GROUP BY MONTH(date) " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        public async Task FillLiabilities(DataGridView dg, byte limit, short page, DateTimePicker date1, DateTimePicker date2, CheckBox chb)
        {
            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                $"SELECT name AS 'Név', address AS 'Cím', phone AS 'Telefonszám', invoice as 'Számlaszám', " +
                $"income AS 'Utalás összege', expense AS 'Össz. kiadás', paid AS 'Utalás státusza' FROM work " +
                $"WHERE transaction = 1 AND receipt = 1{(chb.Checked ? "" : " AND paid = 0")} " +
                $"AND date BETWEEN '{date1.Value:yyyy-MM-dd}' AND '{date2.Value:yyyy-MM-dd}' " +
                $"ORDER BY date " +
                $"LIMIT {limit} " +
                $"OFFSET {(page - 1) * limit}",
                con))
            using (DataTable dt = new DataTable())
            {
                await adapter.FillAsync(dt);
                dg.DataSource = dt;
            }

            await Close();
        }

        /*public async Task ChartTest(Chart chart)
        {
            await Connect();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                "SELECT w2.fullName AS 'Szerelő', SUM(w.income) AS 'Bruttó bevétel' " +
                "FROM work AS w INNER JOIN worker AS w2 ON w.repairmanID = w2.id GROUP BY w2.fullName",
                con))
            using (DataSet ds = new DataSet())
            {
                await adapter.FillAsync(ds);
                chart.DataSource = ds.Tables[0];

                //Mapping a field with x-value of chart
                chart.Series[0].XValueMember = "Szerelő";

                //Mapping a field with y-value of Chart
                chart.Series[0].YValueMembers = "Bruttó bevétel";

                chart.DataBind(); // https://stackoverflow.com/questions/53261981/c-sharp-set-sql-query-result-into-chart
            }

            await Close();
        }*/

        public async Task LoadRandom()
        {
            Random random = new Random();
            await Connect();

            for (int i = 1; i < 44; i++)
                using (MySqlCommand cmd = new MySqlCommand(
                    $"UPDATE location SET value = {random.Next(1000)} WHERE id = {i}",
                    con))
                    await cmd.ExecuteScalarAsync();

            await Close();
        }
        #endregion

        #region Commands
        public async Task<object> GetSingleData(string input)
        {
            object obj = null;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT CONCAT_WS(' ', innerID, name, value) FROM location WHERE innerID = {int.Parse(input)}",
                con))
                obj = await cmd.ExecuteScalarAsync();

            await Close();
            return obj;
        }

        public Dictionary<string, double> GetValues()
        {
            Dictionary<string, double> tempDic = new Dictionary<string, double>();
            Task.Run(async () => {
                await Connect();

                for (int i = 1; i < 44; i++)
                    using (MySqlCommand cmd = new MySqlCommand(
                        $"SELECT CONCAT_WS(' ', innerID, value) FROM location WHERE id = {i}",
                        con))
                    {
                        string obj = (string)await cmd.ExecuteScalarAsync();
                        tempDic[$"{obj.Split(' ')[0]}"] = double.Parse(obj.Split(' ')[1]);
                    }

                await Close();
            });
            return tempDic;
        }

        public async Task<object[]> LoadAllById(int id)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT * FROM work WHERE id = {id}",
                con))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    using (DataTable dt = new DataTable())
                    {
                        await da.FillAsync(dt);

                        await Close();
                        return dt.Rows[0].ItemArray.Select(n => n).ToArray();
                    }
        }

        public async Task<string> FillTextBox(string selection)
        {
            string str = string.Empty;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT {selection.Split('.').LastOrDefault()} " +
                $"FROM {selection.Split('.').FirstOrDefault()}",
                con))
                str = (string)await cmd.ExecuteScalarAsync();

            await Close();
            return str;
        }

        public async Task<List<object>> FillComboBox(string selection)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"SELECT {selection.Split('.').LastOrDefault()} " +
                $"FROM {selection.Split('.').FirstOrDefault()}",
                con)) {
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    using (DataTable dt = new DataTable()) {
                        await da.FillAsync(dt);
                        
                        await Close();
                        return dt.AsEnumerable().Select(n => n.Field<object>(0)).ToList();
                    }
            }
        }

        public async Task<string> GetImagerefs(int id) // for the menu on the left
        {
            string str = string.Empty;
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT imagerefs FROM work WHERE id = " + id,
                con))
                str = (string)await cmd.ExecuteScalarAsync();

            await Close();
            return str;
        }
        #endregion

        #region Insert, Update, Delete
        public async Task Insert_1T(string table, string fields, string tb0)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"INSERT INTO {table} ({fields}) " +
                $"VALUES ('{tb0}')",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task InsertWork(DateTime date, string name, string address, string phone, string invoice, int income, int material, 
            int fuel, int other, bool transaction, bool receipt, bool paid, string imagerefs, string repairman, string concomitant)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"INSERT INTO work (date, name, address, phone, invoice, income, material, fuel, other, transaction, " +
                $"receipt, paid, imagerefs, repairmanID, concomitantID) " +
                $"VALUES ('{date:yyyy-MM-dd}', '{name}', '{address}', '{phone}', '{invoice}', {income}, {material}, {fuel}, {other}, " +
                $"{transaction}, {receipt}, {paid}, '{imagerefs}', " +
                $"(SELECT DISTINCT id FROM worker WHERE fullName LIKE '{repairman}'), " +
                $"(SELECT DISTINCT id FROM worker WHERE fullName LIKE '{concomitant}'))",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task InsertClient(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6, string str, ComboBox tx7, ComboBox tx8)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"INSERT INTO clients (name, address, mobile, task, invoice, date, time, workerID, statusID) " +
                $"VALUES ('{tx1.Text}', '{tx2.Text}', '{tx3.Text}', '{tx4.Text}', '{tx5.Text}', '{tx6.Text}', '{str}', " +
                $"(SELECT DISTINCT id FROM worker WHERE worker.name = '{tx7.Text}'), " +
                $"(SELECT DISTINCT id FROM status WHERE status.name = '{tx8.Text}'))",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task UpdateWork(DateTime date, string name, string address, string phone, string invoice, int income, int material,
            int fuel, int other, bool transaction, bool receipt, bool paid, string imagerefs, string repairman, string concomitant, int id)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"UPDATE work SET date = '{date:yyyy-MM-dd}', name = '{name}', address = '{address}', phone = '{phone}', invoice = '{invoice}', income = {income}, " +
                $"material = {material}, fuel = {fuel}, other = {other}, transaction = {transaction}, receipt = {receipt}, paid = {paid}, imagerefs = '{imagerefs}', " +
                $"repairmanID = (SELECT DISTINCT id FROM worker WHERE fullName LIKE '{repairman}'), " +
                $"concomitantID = (SELECT DISTINCT id FROM worker WHERE fullName LIKE '{concomitant}') " +
                $"WHERE id = {id}",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task DeleteWork(List<int> id)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"DELETE FROM work WHERE id IN ({string.Join(", ", id)})",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task UpdateClient(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5, TextBox tx6, string str, ComboBox cb1, ComboBox cb2, Label id)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"UPDATE clients SET name = '{tx1.Text}', address = '{tx2.Text}', mobile = '{tx3.Text}', task = '{tx4.Text}', invoice = '{tx5.Text}', date = '{tx6.Text}', time = '{str}', " +
                $"workerID = (SELECT DISTINCT id FROM worker WHERE worker.name = '{cb1.Text}'), " +
                $"statusID = (SELECT DISTINCT id FROM status WHERE status.name = '{cb2.Text}') " +
                $"WHERE id = {id.Text.Split(' ').LastOrDefault()}",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task DeleteClient(int id)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"DELETE FROM clients WHERE id = {id}",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task InsertCrime(string cb0, string cb1, string cb2, string cb3)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"INSERT INTO crime (categoryID, locationID, invoiceID, criminalID) " +
                $"VALUES ((SELECT DISTINCT id FROM category WHERE category.name = '{cb0}'), " +
                $"(SELECT DISTINCT id FROM location WHERE location.name = '{cb1}'), " +
                $"(SELECT DISTINCT id FROM invoice WHERE invoice.datetime = '{cb2}'), " +
                $"(SELECT DISTINCT id FROM criminal WHERE criminal.firstName = '{cb3.Split(' ').FirstOrDefault()}' AND criminal.lastName = '{cb3.Split(' ').LastOrDefault()}'))",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task InsertCriminal(string tb0, string tb1, string tb2, string tb3, string tb4)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"INSERT INTO criminal (firstName, lastName, age, gender, status) " +
                $"VALUES ('{tb0}', '{tb1}', '{tb2}', '{tb3}', '{tb4}')",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }

        public async Task InsertDepartment(string tb0, string tb1, string tb2, string tb3, string tb4, string tb5, string tb6)
        {
            await Connect();

            using (MySqlCommand cmd = new MySqlCommand(
                $"INSERT INTO criminal (name, address1, address2, county_province, city, zip_or_post, other) " +
                $"VALUES ('{tb0}', '{tb1}', '{tb2}', '{tb3}', '{tb4}', '{tb5}', '{tb6}')",
                con))
                await cmd.ExecuteScalarAsync();

            await Close();
        }
        #endregion

        ~Connection()
        {
            Task.Run(async () => { await Close(); });
            //Close();
        }
    }
}

