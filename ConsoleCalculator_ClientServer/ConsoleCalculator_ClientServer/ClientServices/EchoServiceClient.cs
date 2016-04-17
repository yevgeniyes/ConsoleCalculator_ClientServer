using System;
using NFX.Glue;
using NFX.Glue.Protocol;
using ConsoleCalculator.Contracts.Services;

namespace ConsoleCalculator.Client.ClientServices
{
    public class EchoServiceClient : ClientEndPoint, IEchoService
    {
        private static TypeSpec s_ts_CONTRACT;
        private static MethodSpec s_ms_Echo_0;

        static EchoServiceClient()
        {
            var t = typeof(IEchoService);
            s_ts_CONTRACT = new TypeSpec(t);
            s_ms_Echo_0 = new MethodSpec(t.GetMethod("Echo", new Type[] { typeof(string) }));
        }

        public EchoServiceClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
        public EchoServiceClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
        public EchoServiceClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
        public EchoServiceClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

        private void ctor()
        {

        }

        public override Type Contract
        {
            get { return typeof(IEchoService); }
        }

        public string Echo(string[] text)
        {
            var call = Async_Echo(text);
            return call.GetValue<string>();
        }

        public CallSlot Async_Echo(string[] text)
        {
            var request = new RequestAnyMsg(s_ts_CONTRACT, s_ms_Echo_0, false, RemoteInstance, new object[] { text });
            return DispatchCall(request);
        }
    }
}
