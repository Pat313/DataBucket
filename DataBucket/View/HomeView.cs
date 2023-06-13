using DataBucket.UI;
using System.Globalization;

namespace DataBucket.View
{
    public partial class HomeView : UserControl
    {
        public static HomeView Instance { get; } = new();

        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            string changelogPath = Path.Combine(Settings.rootPath, "changelog.md");

            List<List<string>> updates = new List<List<string>>();
            byte updateMax = 25;

            using (StreamReader reader = new StreamReader(changelogPath))
            {
                string line;
                byte i = 0;
                List<string> updateLines = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("## "))
                    {
                        if (i == updateMax) break;
                        i++;

                        if (updateLines.Count > 0) updates.Add(updateLines);

                        updateLines = new List<string>();
                    }

                    if (!string.IsNullOrEmpty(line)) updateLines.Add(line);
                }

                if (updateLines.Count > 0) updates.Add(updateLines);
            }

            for (int i = 0; i < updates.Count; i++)
            {
                if (DateTime.TryParseExact(updates[i][0].Split(' ')[2].Substring(1, 10),
                    "yyyy-MM-dd", CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime date))
                {
                    flpReleaseNotes.Controls.Add(new ReleaseTitle()
                    {
                        Date = date.ToString("D"),
                        Version = updates[i][0].Split(' ')[1]
                    });
                }
                for (int j = 1; j < updates[i].Count; j++)
                    flpReleaseNotes.Controls.Add(new ReleaseNote()
                    {
                        Tag = updates[i][j].ElementAt(3),
                        Note = updates[i][j].Remove(0, 6)
                    });
            }
        }
    }
}
