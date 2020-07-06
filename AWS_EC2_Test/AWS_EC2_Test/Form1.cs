using Amazon.CognitoIdentity;
using AWS_EC2_Test.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace AWS_EC2_Test
{
    public partial class Form1 : Form
    {
        IEC2Manager EC2Manager;

        public Form1(IEC2Manager ec2Manager)
        {
            InitializeComponent();
            EC2Manager = ec2Manager;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                EC2Manager.StartInstance().StartingInstances.ForEach(result =>
                {
                    lisResult.Items.Add("實例:" + result.InstanceId + "先前狀態:" + result.PreviousState.Name.Value.Trim());
                    lisResult.Items.Add("實例:"+result.InstanceId+"目前狀態:"+result.CurrentState.Name.Value.Trim());
                });

            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void btnStopInstance_Click(object sender, EventArgs e)
        {
            try
            {
                //propertyGrid1.SelectedObject = 
                EC2Manager.StopInstances().StoppingInstances.ForEach(result =>
                {
                    lisResult.Items.Add("實例:" + result.InstanceId + "先前狀態:" + result.PreviousState.Name.Value.Trim());
                    lisResult.Items.Add("實例:" + result.InstanceId + "目前狀態:" + result.CurrentState.Name.Value.Trim());
                });

            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }
    }
}
