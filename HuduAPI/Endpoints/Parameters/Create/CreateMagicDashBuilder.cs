namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="CreateMagicDash">CreateMagicDash</see>
    /// </summary>
    public class CreateMagicDashBuilder
    {
        private string _companyName;
        private string? _content;
        private string? _contentLink;
        private string? _icon;
        private string? _imageUrl;
        private string _message;
        private string? _shade;
        private string _title;

        /// <summary>
        /// Create a new instance for the <see cref="CreateMagicDashBuilder">CreateMagicDashBuilder</see>
        /// </summary>
        public CreateMagicDashBuilder(string title, string companyName, string message)
        {
            _companyName = companyName;
            _content = default;
            _contentLink = default;
            _icon = default;
            _imageUrl = default;
            _message = message;
            _shade = default;
            _title = title;
        }

        /// <summary>
        /// Build a class of type <see cref="CreateMagicDash">CreateMagicDash</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="CreateMagicDash">CreateMagicDash</see> class
        /// </returns>
        public CreateMagicDash Build()
        {
            return new CreateMagicDash(_title, _companyName, _message);
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="content">content</paramref>
        /// </summary>
        /// <param name="content">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateMagicDashBuilder">CreateMagicDashBuilder</see> with the
        /// property <paramref name="content">content</paramref> defined
        /// </returns>
        public CreateMagicDashBuilder WithContent(string content)
        {
            _content = content;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="contentLink">contentLink</paramref>
        /// </summary>
        /// <param name="contentLink">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateMagicDashBuilder">CreateMagicDashBuilder</see> with the
        /// property <paramref name="contentLink">contentLink</paramref> defined
        /// </returns>
        public CreateMagicDashBuilder WithContentLink(string contentLink)
        {
            _contentLink = contentLink;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="icon">icon</paramref>
        /// </summary>
        /// <param name="icon">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateMagicDashBuilder">CreateMagicDashBuilder</see> with the
        /// property <paramref name="icon">icon</paramref> defined
        /// </returns>
        public CreateMagicDashBuilder WithIcon(string icon)
        {
            _icon = icon;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="imageUrl">imageUrl</paramref>
        /// </summary>
        /// <param name="imageUrl">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateMagicDashBuilder">CreateMagicDashBuilder</see> with the
        /// property <paramref name="imageUrl">imageUrl</paramref> defined
        /// </returns>
        public CreateMagicDashBuilder WithImageUrl(string imageUrl)
        {
            _imageUrl = imageUrl;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="shade">shade</paramref>
        /// </summary>
        /// <param name="shade">
        /// Options are to use a null string, success, or danger (not case sensitive). Setting to
        /// any other string value will result in a blank shade.
        /// </param>
        /// <returns>
        /// Returns the <see cref="CreateMagicDashBuilder">CreateMagicDashBuilder</see> with the
        /// property <paramref name="shade">shade</paramref> defined
        /// </returns>
        public CreateMagicDashBuilder WithShade(string shade)
        {
            _shade = shade;
            return this;
        }
    }
}