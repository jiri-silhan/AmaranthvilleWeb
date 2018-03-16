using System;
using KenticoCloud.Delivery;

namespace AmaranthvilleWeb
{
    public class CustomTypeProvider : ICodeFirstTypeProvider
    {
        public Type GetType(string contentType)
        {
            switch (contentType)
            {
                case "news":
                    return typeof(News);
                case "prezentace_psa":
                    return typeof(PrezentacePsa);
                default:
                    return null;
            }
        }
    }
}