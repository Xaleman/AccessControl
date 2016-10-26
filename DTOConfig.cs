using System;
using System.Configuration;
using System.Net;
using System.Net.NetworkInformation;


namespace AccessControl
{
	public class DTOConfig
	{
		public string   Version;
		public string   VersionDate;
		public string   ConnectionString;
		public string   DeviceName;
		public string   DeviceUser;
		public int      IpNum;
		public string[] Ip;
		public int      MacNum;
		public string[] Mac;
		public string   HostName;
		public string   DomainName;
		public string   DBServer;
		public string   DBPort;
		public string   DB;
		public string   DBUser;
		public string   DBPassword;

		public DTOConfig ()
		{
			int                Idx = 0;
			IPGlobalProperties computerProperties;
			NetworkInterface[] nics;
			//PhysicalAddress    address;
			try{
				// GET INFORMATION FROM APP.CONFIG FILE.
				Version          = ConfigurationManager.AppSettings["version"];
				VersionDate      = ConfigurationManager.AppSettings["versiondate"];
				//ConnectionString = ConfigurationManager.AppSettings["connectionstring"];
				DeviceName       = ConfigurationManager.AppSettings["devicename"];
				DeviceUser       = ConfigurationManager.AppSettings["deviceuser"];
				// GET INFORMATION FROM NETWORKS DEVICES.
				IpNum			 = Dns.GetHostEntry(Environment.MachineName).AddressList.Length;
				Ip 				 = new string[IpNum];
				foreach(IPAddress address in Dns.GetHostEntry(Environment.MachineName).AddressList) {//GetHostByName
					if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
					{
						Ip[Idx++]    = address.ToString();
					}
				}
				IpNum			 = Idx;
				// GET INFORMATION FROM MAC.
				computerProperties = IPGlobalProperties.GetIPGlobalProperties();
				HostName           = computerProperties.HostName;
				DomainName		   = computerProperties.DomainName;
				nics               = NetworkInterface.GetAllNetworkInterfaces();
				MacNum 			   = nics.Length;
				Mac				   = new string[MacNum];
				Idx                = 0;
				if(MacNum > 0)
				{
					foreach (NetworkInterface adapter in nics)
					{
						PhysicalAddress address = adapter.GetPhysicalAddress();
					    byte[] bytes = address.GetAddressBytes();
						for (int i = 0; i < bytes.Length; i++)
						{
							Mac[Idx]=Mac[Idx]+bytes[i].ToString("X2");
						}
						Idx++;
					}
				}
				// DET DATABASE INFORMATION.
				DBServer         = ConfigurationManager.AppSettings["dbserver"];
				DBPort           = ConfigurationManager.AppSettings["dbport"];
				DB               = ConfigurationManager.AppSettings["db"];
				DBUser           = ConfigurationManager.AppSettings["dbuser"];
				DBPassword       = ConfigurationManager.AppSettings["dbpassword"];
				ConnectionString = "Server="+DBServer +";Port="+DBPort+
					               ";Database="+DB+";User ID="+DBUser+
						           ";Password="+DBPassword+";Pooling=false";
			}catch(Exception){
				Version          = "";
				VersionDate      = "";
				ConnectionString = "";
				DeviceName       = "";
				DeviceUser       = "";
				IpNum            = 0;
				MacNum           = 0;
				HostName         = "";
				DomainName       = "";
				DBServer         = "";
				DBPort           = "";
				DB               = "";
				DBUser           = "";
				DBPassword       = "";
			}
		}
	}
	/*
	 * public static void ShowNetworkInterfaces()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName);

            if (nics == null || nics.Length < 1)
            {
                Console.WriteLine("  No network interfaces found.");
                return;
            }

            Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);

            foreach (NetworkInterface adapter in nics)
            {
                Console.WriteLine();
                Console.WriteLine(adapter.Description);
                Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.Netwo$
                Console.Write("  Physical address ........................ : ");
                PhysicalAddress address = adapter.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Display the physical address in hexadecimal.
                    Console.Write("{0}", bytes[i].ToString("X2"));
                    // Insert a hyphen after each byte, unless we are at the end of the
                    // address.
                    if (i != bytes.Length - 1)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

	 */
}

