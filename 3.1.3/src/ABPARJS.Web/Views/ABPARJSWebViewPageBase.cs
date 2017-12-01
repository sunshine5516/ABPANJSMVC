using Abp.Web.Mvc.Views;

namespace ABPARJS.Web.Views
{
    public abstract class ABPARJSWebViewPageBase : ABPARJSWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPARJSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPARJSWebViewPageBase()
        {
            LocalizationSourceName = ABPARJSConsts.LocalizationSourceName;
        }
    }
}