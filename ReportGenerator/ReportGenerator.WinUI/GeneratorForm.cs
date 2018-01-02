using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReportGenerator.DAL;
using ReportGenerator.DataObjects;
using ReportGenerator.DataObjects.CustomExceptions;
using System.Configuration;
using ReportGenerator.DataObjects.Constants;

namespace ReportGenerator.WinUI
{
    public partial class GeneratorForm : Form
    {
        private DummyDAL dummyDAL;
        private int numberOfRows;
        private int applicationRowsLimit;

        public GeneratorForm()
        {
            InitializeComponent();

            dummyDAL = new DummyDAL();
            numberOfRows = 0;
            int.TryParse(ConfigurationSettings.AppSettings[ConfigurationConstants.applicationRowsLimit], out applicationRowsLimit);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateRequest();
                IList<DummyObject> dummyObjects = dummyDAL.GetDummyObjects(numberOfRows);
                ReportGeneratorBL.GeneratePDFReport(dummyObjects, applicationRowsLimit);

                MessageBox.Show("File uspješno kreiran!");
            }
            catch (UserException ue)
            {
                MessageBox.Show(ue.Message);
            }
        }

        private void ValidateRequest()
        {
            ValidateConfiguration();

            if (String.IsNullOrEmpty(tbNumberOfRows.Text))
            {
                throw new UserException(CustomExceptionMessages.numberOfRowsMandatory);
            }
            if (!int.TryParse(tbNumberOfRows.Text, out numberOfRows))
            {
                throw new UserException(CustomExceptionMessages.numberOfRowsInteger);
            }
            if (numberOfRows <= 0)
            {
                throw new UserException(CustomExceptionMessages.numberOfRowsPositiveInteger);
            }
        }

        private void ValidateConfiguration()
        {
            if(applicationRowsLimit <= 0)
            {
                throw new UserException(CustomExceptionMessages.invalidConfiguration);
            }
        }


    }
}
