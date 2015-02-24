using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace Geeks
{
    public class LinkedListFragment: Android.Support.V4.App.ListFragment
    {
         private List<ArticleModel> mItem;
        private ListView mListView;

        public LinkedListFragment()
        {

        }

        public async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var obj = new LinkedListArticle();
            Task<List<ArticleModel>> lItem = obj.DownloadAsyncPage();

            mItem = await lItem;
            var adaptor = new CustomListAdaptor(Activity, mItem);

            
            ListAdapter = adaptor;
         
            // Set our view from the "main" layout resource
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Array_fragment, container, false);
           // mListView = view.FindViewById<ListView>(Resource.Id.list);
           
           
            return view;
        }
    }
}