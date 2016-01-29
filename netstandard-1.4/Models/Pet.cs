using System;
using System.Collections.Generic;
using System.Text;

namespace Petstore.Models
{
    /// <summary>
    /// </summary>
    public class Pet : IEquatable<Pet>
    {
        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        public long? Id { get; set; }


        /// <summary>
        ///     Gets or Sets Category
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        ///     Gets or Sets Name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        ///     Gets or Sets PhotoUrls
        /// </summary>
        public List<string> PhotoUrls { get; set; }


        /// <summary>
        ///     Gets or Sets Tags
        /// </summary>
        public List<Tag> Tags { get; set; }


        /// <summary>
        ///     pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        public PetStatus Status { get; set; }

        #region Methods

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Pet other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && string.Equals(Name, other.Name);
        }

        /// <summary>
        ///     Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <returns>
        ///     true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param>
        /// <filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Pet)obj);
        }

        /// <summary>
        ///     Serves as the default hash function.
        /// </summary>
        /// <returns>
        ///     A hash code for the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Id.GetHashCode() * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        #endregion Methods

        #region Operators

        public static bool operator ==(Pet left, Pet right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Pet left, Pet right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}