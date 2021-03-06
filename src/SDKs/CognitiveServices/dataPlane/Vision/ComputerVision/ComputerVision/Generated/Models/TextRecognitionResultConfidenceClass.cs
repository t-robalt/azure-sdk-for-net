// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TextRecognitionResultConfidenceClass.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextRecognitionResultConfidenceClass
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Low")]
        Low
    }
    internal static class TextRecognitionResultConfidenceClassEnumExtension
    {
        internal static string ToSerializedValue(this TextRecognitionResultConfidenceClass? value)
        {
            return value == null ? null : ((TextRecognitionResultConfidenceClass)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TextRecognitionResultConfidenceClass value)
        {
            switch( value )
            {
                case TextRecognitionResultConfidenceClass.High:
                    return "High";
                case TextRecognitionResultConfidenceClass.Low:
                    return "Low";
            }
            return null;
        }

        internal static TextRecognitionResultConfidenceClass? ParseTextRecognitionResultConfidenceClass(this string value)
        {
            switch( value )
            {
                case "High":
                    return TextRecognitionResultConfidenceClass.High;
                case "Low":
                    return TextRecognitionResultConfidenceClass.Low;
            }
            return null;
        }
    }
}
