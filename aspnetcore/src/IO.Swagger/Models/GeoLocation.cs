/*
 * Restaurant Orders
 *
 * Simple API to manage restaurant orders
 *
 * OpenAPI spec version: v1
 * Contact: sergio.adonis@outlook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class GeoLocation : IEquatable<GeoLocation>
    { 
        /// <summary>
        /// Gets or Sets Latitud
        /// </summary>
        [DataMember(Name="latitud")]
        public int? Latitud { get; set; }

        /// <summary>
        /// Gets or Sets Longitud
        /// </summary>
        [DataMember(Name="longitud")]
        public int? Longitud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocation {\n");
            sb.Append("  Latitud: ").Append(Latitud).Append("\n");
            sb.Append("  Longitud: ").Append(Longitud).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((GeoLocation)obj);
        }

        /// <summary>
        /// Returns true if GeoLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Latitud == other.Latitud ||
                    Latitud != null &&
                    Latitud.Equals(other.Latitud)
                ) && 
                (
                    Longitud == other.Longitud ||
                    Longitud != null &&
                    Longitud.Equals(other.Longitud)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Latitud != null)
                    hashCode = hashCode * 59 + Latitud.GetHashCode();
                    if (Longitud != null)
                    hashCode = hashCode * 59 + Longitud.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GeoLocation left, GeoLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GeoLocation left, GeoLocation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}