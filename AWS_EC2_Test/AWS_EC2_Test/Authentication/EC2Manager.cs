using Amazon;
using Amazon.CognitoIdentity;
using Amazon.EC2;
using Amazon.EC2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWS_EC2_Test.Authentication
{
    public interface IEC2Manager
    {
        public StartInstancesResponse StartInstance();

        public StopInstancesResponse StopInstances();
    }

    public class EC2Manager : IEC2Manager
    {
        private AmazonEC2Client client = new AmazonEC2Client("ACCESSKEY", "SECRECT KEY", RegionEndpoint.USEast1);

        public StartInstancesResponse StartInstance()
        {
            StartInstancesResponse response = client.StartInstances(new StartInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-0f43c5ddaac4b6dac",
                    "i-02d50d9e0cb2eb2b6"
                }
            });

            return response;
        }

        public StopInstancesResponse StopInstances()
        {
            StopInstancesResponse response = client.StopInstances(new StopInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-0f43c5ddaac4b6dac",
                    "i-02d50d9e0cb2eb2b6"
                }
            });

            return response;
        }
    }
}
