using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public class PayloadBuilder
    {
        Models.PayLoadModelFusion model;
        public PayloadBuilder(string command, List<object> arguments = null)
        {
            model = new Models.PayLoadModelFusion();
            if (arguments is null) arguments = new List<object>();
            model.Arguments = arguments;
            model.Command = command;
        }

        public void AddArgument(string argument)
        {
            model.Arguments.Add(argument);
        }

        public Models.PayLoadModelFusion Build() => model;
        public string BuildToString() =>  JsonConvert.SerializeObject(model); 
        public override string ToString() => BuildToString();
        public static string BuildStatic(string command, List<object> arguments)
        {
            var model = new Models.PayLoadModelFusion();
            if (arguments is null) arguments = new List<object>();
            model.Arguments = arguments;
            model.Command = command;
            return JsonConvert.SerializeObject(model);
        }
        public static string BuildModel(Models.PayLoadModelFusion model) => JsonConvert.SerializeObject(model);
        public static string BuildModel(Models.PayLoadModel model) => JsonConvert.SerializeObject(model);
    }
}
