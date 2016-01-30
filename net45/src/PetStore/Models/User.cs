using System;
using System.Text;

namespace Petstore.Models
{
    /// <summary>
    /// </summary>
    public class User : IEquatable<User>
    {
        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        public long? Id { get; set; }


        /// <summary>
        ///     Gets or Sets Username
        /// </summary>
        public string Username { get; set; }


        /// <summary>
        ///     Gets or Sets FirstName
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        ///     Gets or Sets LastName
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        ///     Gets or Sets Email
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        ///     Gets or Sets Password
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        ///     Gets or Sets Phone
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        ///     User Status
        /// </summary>
        /// <value>User Status</value>
        public int? UserStatus { get; set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && string.Equals(Username, other.Username) &&
                   string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName) &&
                   string.Equals(Email, other.Email) && string.Equals(Password, other.Password) &&
                   string.Equals(Phone, other.Phone) && UserStatus == other.UserStatus;
        }

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((User) obj);
        }

        /// <summary>
        /// Serves as the default hash function. 
        /// </summary>
        /// <returns>
        /// A hash code for the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode*397) ^ (Username != null ? Username.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Password != null ? Password.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ UserStatus.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        #endregion Methods

        #region Operators

        public static bool operator ==(User left, User right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}