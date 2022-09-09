using System;

namespace HuduAPI.Endpoints.Parameters
{
    /// <summary>
    /// Builder for the class <see cref="GetActivityLogs">GetActivityLogs</see>
    /// </summary>
    public class GetActivityLogsBuilder
    {
        private string? _actionMessage;
        private int? _page;
        private int? _pageSize;
        private int? _resourceID;
        private string? _resourceType;
        private string? _startDate;
        private string? _userEmail;
        private int? _userID;

        /// <summary>
        /// Create a new instance for the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see>
        /// </summary>
        public GetActivityLogsBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Build a class of type <see cref="GetActivityLogs">GetActivityLogs</see> with all the
        /// defined values
        /// </summary>
        /// <returns>
        /// Returns a <see cref="GetActivityLogs">GetActivityLogs</see> class
        /// </returns>
        public GetActivityLogs Build()
        {
            return new GetActivityLogs(_actionMessage, _page, _pageSize, _resourceID, _resourceType, _startDate, _userEmail, _userID);
        }

        /// <summary>
        /// Reset all properties' to the default value
        /// </summary>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// properties reseted
        /// </returns>
        public GetActivityLogsBuilder Reset()
        {
            _actionMessage = default;
            _page = default;
            _pageSize = default;
            _resourceID = default;
            _resourceType = default;
            _startDate = default;
            _userEmail = default;
            _userID = default;

            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="actionMessage">actionMessage</paramref>
        /// </summary>
        /// <param name="actionMessage">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="actionMessage">actionMessage</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithActionMessage(string actionMessage)
        {
            this._actionMessage = actionMessage;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="page">page</paramref>
        /// </summary>
        /// <param name="page">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="page">page</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithPage(int page)
        {
            this._page = page;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="pageSize">pageSize</paramref>
        /// </summary>
        /// <param name="pageSize">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="pageSize">pageSize</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithPageSize(int pageSize)
        {
            this._pageSize = pageSize;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="resourceId">resourceId</paramref>
        /// </summary>
        /// <param name="resourceId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="resourceId">resourceId</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithResourceID(int resourceId)
        {
            this._resourceID = resourceId;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="resourceType">resourceType</paramref>
        /// </summary>
        /// <param name="resourceType">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="resourceType">resourceType</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithResourceType(string resourceType)
        {
            this._resourceType = resourceType;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="startDate">startDate</paramref>
        /// </summary>
        /// <param name="startDate">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="startDate">startDate</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithStartDate(string startDate)
        {
            this._startDate = startDate;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="string" /> for the property <paramref name="userEmail">userEmail</paramref>
        /// </summary>
        /// <param name="userEmail">
        /// A value of type <typeparamref name="string" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="userEmail">userEmail</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithUserEmail(string userEmail)
        {
            this._userEmail = userEmail;
            return this;
        }

        /// <summary>
        /// Set a value of type <typeparamref name="int" /> for the property <paramref name="userId">userId</paramref>
        /// </summary>
        /// <param name="userId">
        /// A value of type <typeparamref name="int" /> will the defined for the property
        /// </param>
        /// <returns>
        /// Returns the <see cref="GetActivityLogsBuilder">GetActivityLogsBuilder</see> with the
        /// property <paramref name="userId">userId</paramref> defined
        /// </returns>
        public GetActivityLogsBuilder WithUserID(int userId)
        {
            this._userID = userId;
            return this;
        }
    }
}