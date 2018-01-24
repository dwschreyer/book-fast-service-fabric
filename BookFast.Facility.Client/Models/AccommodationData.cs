// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BookFast.Facility.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AccommodationData
    {
        /// <summary>
        /// Initializes a new instance of the AccommodationData class.
        /// </summary>
        public AccommodationData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccommodationData class.
        /// </summary>
        /// <param name="name">Accommodation name</param>
        /// <param name="description">Accommodation description</param>
        /// <param name="roomCount">Number of rooms</param>
        /// <param name="images">Accommodation images</param>
        public AccommodationData(string name, string description = default(string), int? roomCount = default(int?), IList<string> images = default(IList<string>))
        {
            Name = name;
            Description = description;
            RoomCount = roomCount;
            Images = images;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets accommodation name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets accommodation description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets number of rooms
        /// </summary>
        [JsonProperty(PropertyName = "roomCount")]
        public int? RoomCount { get; set; }

        /// <summary>
        /// Gets or sets accommodation images
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<string> Images { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 100);
                }
                if (Name.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 3);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 1000);
                }
                if (Description.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 0);
                }
            }
            if (RoomCount > 20)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RoomCount", 20);
            }
            if (RoomCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RoomCount", 0);
            }
        }
    }
}
