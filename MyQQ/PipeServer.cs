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
    class PipeServer
    {
        private NamedPipeServerStream _pipeServer;

        public PipeServer()
        {
            _pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.InOut, 1);
        }

        public void StartListening()
        {
            _pipeServer.WaitForConnection();
            var data = new byte[10240];
            int count = _pipeServer.Read(data, 0, 10240);
            string message = Encoding.Default.GetString(data, 0, count);
            // 处理接收到的消息
            ProcessMessage(message);

            using (StreamWriter sw = new StreamWriter(_pipeServer))
            {
                sw.AutoFlush = true;
                sw.WriteLine("Message received by B");
            }
        }

        private void ProcessMessage(string message)
        {
            // 在这里处理接收到的消息，例如更新UI
            MessageBox.Show("Received: " + message);
        }
    }
}
