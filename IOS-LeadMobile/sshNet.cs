using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOS_LeadMobile
{
    public class sshNet
    {
        string ip;
        public sshNet(string ip)
        {
            this.ip = ip;
        }



        //Func 
        public bool isDirAndFileApp(string path, string nameos)
        {
            try
            {
                using (var client = new SftpClient(ip, "root", "alpine"))
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        var files = client.ListDirectory(path);
                        //   Console.WriteLine(nameos + ": --------------------------");
                        foreach (var file in files)
                        {
                            //     Console.WriteLine(file.Name +"---"+ nameos);
                            if (file.Name == nameos)
                            {
                                client.Disconnect();
                                return true;
                            }
                        }
                        //    Console.WriteLine(nameos + ": --------------------------");
                    }
                    return false;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool RestoreApp(string ApplicationRRS,string app)
        {
            try
            {
               
               
                ConnectionInfo connectionInfo = new ConnectionInfo(ip, 22, "root", new AuthenticationMethod[]
                {
                    new PasswordAuthenticationMethod("root", "alpine")
                });
                using (SshClient sshClient = new SshClient(connectionInfo))
                {
                    sshClient.Connect();
                    sshClient.CreatenExecute("unzip /var/root/backup/" + ApplicationRRS+".zip");
                    //MobileOS.ExtensionOS exten = new MobileOS.ExtensionOS(ip, "alpine");
                    //exten.RestoreRRS(ApplicationRRS, app);
                    string Null;
                    Null = sshClient.CreatenExecute("find /private/var/mobile/Containers/Data/Application/*/ -name '" + app + "'");
                    string[] arrResuftCommand = StringFunctions.ArrSplitOpTion(Null, "\n");
                    if (arrResuftCommand.Count<string>() <= 0 || !(arrResuftCommand[0] != ""))
                    {
                    }
                    string[] arrResuftCommand2 = StringFunctions.ArrSplitOpTion(arrResuftCommand[0], "Library");
                    string strResuftCommand = arrResuftCommand2[0] + "Library";
                    sshClient.CreatenExecute("cp -rf " + "/var/root/" + ApplicationRRS + "/Library " + arrResuftCommand2[0]  );
                    Console.WriteLine("cp -rf " + "/var/root/" + ApplicationRRS + "/Library " + arrResuftCommand2[0]);
                    sshClient.CreatenExecute("cp -rf " + "/var/root/" + ApplicationRRS + "/Documents " + arrResuftCommand2[0] );
                    sshClient.CreatenExecute("rm -rf /var/root/" +ApplicationRRS);
                    sshClient.Disconnect();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool backUpApp(string Application,string Date)
        {
            try
            {
                MobileOS.ExtensionOS exten = new MobileOS.ExtensionOS(ip, "alpine");
                exten.BackupRRS(Application, Date);
              
                ConnectionInfo connectionInfo = new ConnectionInfo(ip, 22, "root", new AuthenticationMethod[]
                {
                    new PasswordAuthenticationMethod("root", "alpine")
                });
                using (SshClient sshClient = new SshClient(connectionInfo))
                {
                    sshClient.Connect();
                    string Null;
                    Null = sshClient.CreatenExecute("find /private/var/mobile/Containers/Data/Application/*/ -name '" + Application + "'");
                    string[] arrResuftCommand = StringFunctions.ArrSplitOpTion(Null, "\n");
                    if (arrResuftCommand.Count<string>() <= 0 || !(arrResuftCommand[0] != ""))
                    {
                    }
                    string[] arrResuftCommand2 = StringFunctions.ArrSplitOpTion(arrResuftCommand[0], "Library");
                    string strResuftCommand = arrResuftCommand2[0] + "Library";
                    string str= sshClient.CreatenExecute("cp -rf " + arrResuftCommand2[0] + "/Library/ /var/root/backup/"+ Application + Date);
                    Console.WriteLine("cp -rf " + arrResuftCommand2[0] + "/Library/ /var/root/backup/" + Application + Date);
                    sshClient.CreatenExecute("cp -rf " + arrResuftCommand2[0] + "/Documents/ /var/root/backup/" + Application + Date);
                    sshClient.CreatenExecute("cd /var/root/backup/;zip -r "+ Application + Date+".zip "+ Application + Date);
                    sshClient.CreatenExecute("rm -rf /var/root/backup/" + Application + Date);
                    sshClient.Disconnect();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        //App-------------- Install---------
        public bool installApp(string Application)
        {
            bool resuft = false;
            try
            {
                ConnectionInfo connectionInfo = new ConnectionInfo(ip, 22, "root", new AuthenticationMethod[]
                {
                new PasswordAuthenticationMethod("root", "alpine")
                });

                using (SshClient sshClient = new SshClient(connectionInfo))
                {
                    sshClient.Connect();
                    resuft = sshClient.CreatenExecute("ipainstaller -c /private/var/Data/"+ Application + ".ipa").Contains("success");
                    return resuft;
                }
            }
            catch
            {
                return resuft;
            }
        }
        public bool checkinstallApp(string Application)
        {
            if (isDirAndFileApp("/private/var/Data", Application + ".ipa"))
            {
                try
                {
                    ConnectionInfo connectionInfo = new ConnectionInfo(ip, 22, "root", new AuthenticationMethod[]
                    {
                      new PasswordAuthenticationMethod("root", "alpine")
                    });

                    using (SshClient sshClient = new SshClient(connectionInfo))
                    {
                        sshClient.Connect();
                        sshClient.CreatenExecute("mkdir /private/var/Data");
                        sshClient.CreatenExecute("chmod 777 /private/var/Data");
                        sshClient.CreatenExecute(string.Concat(new string[]
                        {
                        "ipainstaller -b ",
                        Application,
                        " -o /private/var/Data",
                        Application,
                        ".ipa"
                        }));
                        sshClient.CreatenExecute("chmod 777 /private/var/Data" + Application + ".ipa");
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
