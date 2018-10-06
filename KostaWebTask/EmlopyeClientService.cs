using EmployeServiceLib;
using System;
using System.ServiceModel;

namespace KostaWebTask {
    public static class EmlopyeClientService {
        private static IEmployeService channel;

        public static IEmployeService GetChannel() {
            if (channel == null) {
                var address = new Uri("http://localhost:4400/EmployeService.svc");

                var binding = new BasicHttpBinding();
                var endpoint = new EndpointAddress(address);

                ChannelFactory<IEmployeService> factory = new ChannelFactory<IEmployeService>(binding, endpoint);
                channel = factory.CreateChannel();
            }
            return channel;
        }
    }
}