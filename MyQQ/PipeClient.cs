using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    class PipeClient
    {
        public void SendMessage(string message)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.InOut))
            {
                pipeClient.Connect();
                byte[] data = Encoding.Default.GetBytes(message);
                pipeClient.Write(data, 0, data.Length);

                using (StreamReader sr = new StreamReader(pipeClient))
                {
                    string response = sr.ReadLine();
                    // 处理服务端的响应
                    ProcessResponse(response);
                }
            }
        }

        private void ProcessResponse(string response)
        {
            // 在这里处理服务端的响应，例如更新UI
            MessageBox.Show("Response from B: " + response);
        }
    }
}
