using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;

namespace BikeManagementSystemDesktop.Views
{
    public partial class BikeWearTableForm : Form
    {
        private readonly BikeWearService bikeWearService;
        private readonly TerrainService terrainService;
        private readonly BikeType bikeType;

        public BikeWearTableForm(BikeWearService bikeWearService, TerrainService terrainService, BikeType bikeType)
        {
            this.bikeWearService = bikeWearService;
            this.terrainService = terrainService;
            this.bikeType = bikeType;
            InitializeComponent();
            labelBikeType.Text = bikeType.Name;
            wearTable.Columns.Add("Id", "Id");
            wearTable.Columns.Add("Name", "Terrain name");
            wearTable.Columns.Add("WearRatio", "Wear ratio");
            wearTablePage.Maximum = terrainService.GetPageCount(BikeWearService.DEFAULT_PAGE_SIZE) + 1;
            ChangeWearTablePage(1);
        }

        private void ChangeWearTablePage(int page)
        {
            wearTable.Rows.Clear();
            terrainService.GetEntityPage(page, TerrainService.DEFAULT_PAGE_SIZE)
                .ForEach(terrain =>
                {
                    BikeWear? bikeWear = terrain.BikeWears.FirstOrDefault(
                        wear => wear.BikeTypeId == bikeType.Id
                        && wear.TerrainId == terrain.Id
                    );
                    wearTable.Rows.Add(terrain.Id, terrain.Name, bikeWear?.WearRatio);
                });
        }

        private void wearTablePage_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)wearTablePage.Value;
            ChangeWearTablePage(page);
        }

        private void buttonEditRatio_Click(object sender, EventArgs e)
        {
            if (wearTable.SelectedRows.Count != 0)
            {
                var selectedRow = wearTable.SelectedRows[0];
                int terrainID = (int)selectedRow.Cells[0].Value;
                Terrain terrain = terrainService.GetEntity(terrainID);
                decimal? wearRatio = (decimal?)selectedRow.Cells[2].Value;
                BikeWearForm editWear = new("Edit wear", "Update", bikeType, terrain, wearRatio??1M);
                editWear.Owner = this;
                editWear.OnSubmit += (wearRatio) => {
                    BikeWear bikeWear;
                    if(selectedRow.Cells[2].Value==null)
                    {
                        bikeWear = new BikeWear(bikeType.Id, terrainID, wearRatio);
                        bikeWearService.AddEntity(bikeWear);
                    }
                    else
                    {
                        bikeWear = bikeWearService.GetEntity(new BikeWearKey(bikeType.Id, terrainID));
                        bikeWear.WearRatio = wearRatio;
                        bikeWearService.EditEntity(bikeWear);
                    }
                    selectedRow.Cells[2].Value = wearRatio;
                };
                editWear.ShowDialog();
            }
            else
                GuiUtils.ShowError(this, "First you need to select terrain");
        }
    }
}
