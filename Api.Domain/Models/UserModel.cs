using System;

namespace Api.Domain.Models.Users
{
    public class UserModel : BaseModel
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private Guid _cepId;

        public Guid CepId
        {
            get { return _cepId; }
            set { _cepId = value; }
        }


    }
}
