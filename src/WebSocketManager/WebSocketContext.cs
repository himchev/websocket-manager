using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace WebSocketManager
{
    public class WebSocketContext
    {
        public WebSocket Socket { get; set; }
        public HttpContext HttpContext { get; set; }
    }
}
