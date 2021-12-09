using System;

namespace Adapter
{
    public class AdapterService
    {
        public ReturningStrings ReturningStrings { get; set; }

        public AdapterService()
        {
            ReturningStrings = new ReturningStrings();
        }

        public int ConvertToInt()
        {
            var connectionAsString = ReturningStrings.ReturnString();
            int connectionAsInt = Convert.ToInt32(connectionAsString);
            return connectionAsInt;
        }
    }
}