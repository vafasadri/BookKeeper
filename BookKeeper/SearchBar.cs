using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BookKeeper
{
    [DefaultEvent("Search")]
    public partial class SearchBar : UserControl
    {
        public event EventHandler Search;
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }
        public object SearchProperties
        {
            get => cmbBy.DataSource;
            set => cmbBy.DataSource = value;
        }
        public int SelectedPropertyIndex
        {
            get => cmbBy.SelectedIndex;
            set => cmbBy.SelectedIndex = value;
        }
        public string SelectedProperty
        {
            get => (string)cmbBy.SelectedValue;
            set => cmbBy.SelectedValue = value;
        }
        public string SearchKey
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
        }
        public SearchBar()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search?.Invoke(this, EventArgs.Empty);
        }

        private void cmbBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search?.Invoke(this, EventArgs.Empty);
        }
    }
    public class SearchEventArgs : EventArgs
    {
        public string SearchKey { get; }
        public string By { get; }
        public SearchEventArgs(string searchKey, string by)
        {
            SearchKey = searchKey;
            By = by;
        }
    }
}
