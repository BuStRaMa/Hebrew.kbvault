namespace KBVault.Web.Helpers
{
    using System.Linq;
    using System.Web.Mvc;
    using KBVault.Dal;

    public sealed class SiteLock : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            bool _lock;

            using (var db = new KbVaultContext())
            {
                _lock = db.Settings.FirstOrDefault().LockSite;
            }

            if (_lock)
            {
                base.OnAuthorization(filterContext);
            }
            else
            {
                return;
            }
        }
    }
}