using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Geeks
{
    public class CustomTabAdapter: FragmentPagerAdapter
    {
        private string[] Titles = {"Array", "Strings", "LinkedList", "Tree"};

        public CustomTabAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
        {
            
        }


        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(Titles[position]);
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return new ArrayFragment();
        }

        public override int Count
        {
            get
            {
                return Titles.Length;
            }
        }
    }
}