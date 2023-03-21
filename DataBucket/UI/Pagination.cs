using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBucket.UI
{
    public partial class Pagination : UserControl
    {
        /*public event EventHandler LeftJumpEvent;
        public event EventHandler LeftPageEvent;
        public event EventHandler RightPageEvent;
        public event EventHandler RightJumpEvent;*/
        public event EventHandler PagingEvent;

        private int previousPageLocation;

        public Pagination()
        {
            InitializeComponent();
        }

        private void Pagination_Load(object sender, EventArgs e)
        {
            previousPageLocation = lblPages.Location.X;

            btnLeftJump.MouseEnter += BtnPage_MouseEnter;
            btnLeftPage.MouseEnter += BtnPage_MouseEnter;
            btnRightPage.MouseEnter += BtnPage_MouseEnter;
            btnRightJump.MouseEnter += BtnPage_MouseEnter;
            btnLeftJump.MouseLeave += BtnPage_MouseLeave;
            btnLeftPage.MouseLeave += BtnPage_MouseLeave;
            btnRightPage.MouseLeave += BtnPage_MouseLeave;
            btnRightJump.MouseLeave += BtnPage_MouseLeave;
            btnLeftJump.Click += btnLeftJump_Click;
            btnLeftPage.Click += btnLeftPage_Click;
            btnRightPage.Click += btnRightPage_Click;
            btnRightJump.Click += btnRightJump_Click;
            lblPages.TextChanged += lblPages_TextChanged;
        }

        public byte PageLimit { get => (byte)numRows.Value; set => numRows.Value = value; }
        //public string Pages { get => lblPages.Text; set => lblPages.Text = value; }
        //public Label TotalRows { get => lblResults; set => lblResults = value; }
        //public bool PageLeftVisible { get => btnLeftPage.Visible; set => btnLeftPage.Visible = value; }
        //public bool PageRightVisible { get => btnRightPage.Visible; set => btnRightPage.Visible = value; }
        public short CurrentPage { get => Convert.ToInt16(lblPages.Text.Split(' ')[0]); set => lblPages.Text = $"{value} / {LastPage}"; }
        public short LastPage { get => Convert.ToInt16(lblPages.Text.Split(' ')[2]); set => lblPages.Text = $"{CurrentPage} / {value}"; }
        public long TotalRows { get => Convert.ToInt64(lblResults.Text.Split(' ')[1]); set => lblResults.Text = $"a(z) {value} találatból"; }

        private void GoToFirstPage()
        {
            CurrentPage = 1;
        }

        private void CalculateLastPage()
        {
            LastPage = (short)Math.Ceiling((decimal)TotalRows / PageLimit);
        }

        public async void SetResults(Task<long> t)
        {
            TotalRows = await t;
            CalculateLastPage();
            GoToFirstPage();
        }

        private void BtnPage_MouseEnter(object sender, EventArgs e) => ((IconButton)sender).IconColor = Color.DodgerBlue;

        private void BtnPage_MouseLeave(object sender, EventArgs e) => ((IconButton)sender).IconColor = Color.FromArgb(200, 200, 200);

        private void btnLeftJump_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            //LeftJumpEvent?.Invoke(this, e);
            if (lblPages.Text == "1 / 1")
            {
                btnLeftPage.Visible = false; btnRightPage.Visible = false;
            }
            PagingEvent?.Invoke(this, e);
        }

        private void btnLeftPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1) CurrentPage--; else return;       
            //LeftPageEvent?.Invoke(this, e);
            PagingEvent?.Invoke(this, e);
        }

        private void btnRightPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage < LastPage) CurrentPage++; else return;
            //RightPageEvent?.Invoke(this, e);
            PagingEvent?.Invoke(this, e);
        }

        private void btnRightJump_Click(object sender, EventArgs e)
        {
            CurrentPage = LastPage;
            //RightJumpEvent?.Invoke(this, e);
            PagingEvent?.Invoke(this, e);
        }

        private void lblPages_TextChanged(object sender, EventArgs e)   
        {
            if (previousPageLocation != lblPages.Location.X)
            {
                //int currentLocationX = pnlPages.Width - 128 - (lblPages.Text.Length - 5) * 12;
                //lblPages.Location = new Point(currentLocationX, 2);
                //btnLeftPage.Location = new Point(currentLocationX - 34, 3);
                //btnLeftJump.Location = new Point(currentLocationX - 68, 3);
            }

            if (lblPages.Text == "1 / 1") { btnLeftPage.Visible = false; btnRightPage.Visible = false; return; }

            if (CurrentPage > 1) btnLeftPage.Visible = true;
            else btnLeftPage.Visible = false;

            if (CurrentPage < LastPage) btnRightPage.Visible = true;
            else btnRightPage.Visible = false;
        }
    }

    public interface IPageCollection
    {
        byte PageLimit { get; set; }
        short CurrentPage { get; set; }
        short LastPage { get; set; }
        long TotalRows { get; set; }
    }

    public static class Pages
    {
        static readonly Pagination pagination = new Pagination();

        public static void GoToFirst()
        {
            pagination.CurrentPage = 1;
        }
    }
}