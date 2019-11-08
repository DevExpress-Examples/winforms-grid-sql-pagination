using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DxSample {
    public partial class MainForm : XtraForm {
        private SqlDataAdapter DataAdapter;

        public MainForm() {
            InitializeComponent();
            OrdersGridView.OptionsCustomization.AllowFilter = false;
            OrdersGridView.OptionsCustomization.AllowGroup = false;
            OrdersGridView.OptionsCustomization.AllowSort = false;
            OrdersGridView.OptionsFind.AllowFindPanel = false;
            OrdersGridView.OptionsView.ShowGroupPanel = false;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string selectCommandText = @"
select OrderID, OrderDate, Freight, ShipName
from Orders
order by OrderID
offset @offset rows
fetch next @size rows only
";
            this.DataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            this.DataAdapter.SelectCommand.Parameters.Add("@offset", SqlDbType.Int);
            this.DataAdapter.SelectCommand.Parameters.Add("@size", SqlDbType.Int);
            this.DataAdapter.SelectCommand.Parameters["@offset"].Value = 0;
            this.DataAdapter.SelectCommand.Parameters["@size"].Value = PageSize;

            this.DataAdapter.Fill(this.dtOrders);

        }

        private int fPageSize = 10;
        public int PageSize {
            get { return fPageSize; }
            set { fPageSize = value; }
        }

        private void EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
            if (e.Button.ButtonType != NavigatorButtonType.Custom) return;
            e.Handled = true;
            int offset = (int)DataAdapter.SelectCommand.Parameters["@offset"].Value;
            string tag = (string)e.Button.Tag;
            switch(tag) {
                case "NextPage":
                    offset += PageSize;
                    break;
                case "PrevPage":
                    offset -= PageSize;
                    break;
            }
            offset = Math.Max(0, offset);
            OrdersGrid.EmbeddedNavigator.Buttons.CustomButtons[0].Enabled = offset > 0;
            DataAdapter.SelectCommand.Parameters["@offset"].Value = offset;
            dtOrders.Clear();
            DataAdapter.Fill(dtOrders);
            OrdersGrid.EmbeddedNavigator.Buttons.CustomButtons[1].Enabled = dtOrders.Rows.Count == PageSize;
        }

        private void PageSizeEditor_EditValueChanged(object sender, EventArgs e) {
            BarEditItem editor = (BarEditItem)sender;
            PageSize = int.Parse((string)editor.EditValue);
            DataAdapter.SelectCommand.Parameters["@size"].Value = PageSize;
            dtOrders.Clear();
            DataAdapter.Fill(dtOrders);
        }
    }
}
