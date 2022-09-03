namespace HuduAPI.Endpoints.Parameters
{
    /// <summary> Builder for the class <see cref="GetCompany">GetCompany</see> <summary>
    public class GetCompanyBuilder
    {
        private int _id;

        /// <summary> Create a new instance for the <see
        /// cref="GetCompanyBuilder">GetCompanyBuilder</see> <summary>
        public GetCompanyBuilder()
        {
            Reset();
        }

        /// <summary> Build a class of type <see cref="GetCompany">GetCompany</see> with all the
        /// defined values <summary> <returns>Returns a <see cref="GetCompany">GetCompany</see> class</returns>
        public GetCompany Build()
        {
            return new GetCompany(_id);
        }

        /// <summary> Reset all properties' to the default value <summary> <returns>Returns the <see
        /// cref="GetCompanyBuilder">GetCompanyBuilder</see> with the properties reseted</returns>
        public GetCompanyBuilder Reset()
        {
            _id = default;

            return this;
        }

        /// <summary> Set a value of type <typeparamref name="int"/> for the property <paramref
        /// name="id">id</paramref> <summary> <param name="id">A value of type <typeparamref
        /// name="int"/> will the defined for the property</param> <returns>Returns the <see
        /// cref="GetCompanyBuilder">GetCompanyBuilder</see> with the property <paramref
        /// name="id">id</paramref> defined</returns>
        public GetCompanyBuilder WithID(int id)
        {
            this._id = id;
            return this;
        }
    }
}