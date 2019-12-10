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
    public partial class InlineResponseDefault2Data : IEquatable<InlineResponseDefault2Data>
    { 
        /// <summary>
        /// Gets or Sets Menu
        /// </summary>
        [DataMember(Name="menu")]
        public InlineResponseDefault2DataMenu Menu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault2Data {\n");
            sb.Append("  Menu: ").Append(Menu).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefault2Data)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault2Data instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault2Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault2Data other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Menu == other.Menu ||
                    Menu != null &&
                    Menu.Equals(other.Menu)
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
                    if (Menu != null)
                    hashCode = hashCode * 59 + Menu.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault2Data left, InlineResponseDefault2Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault2Data left, InlineResponseDefault2Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
