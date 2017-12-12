using Inventario.Core.Models;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;

using System.Collections.Generic;
using Android.App;

namespace Inventario.Adaptadores
{
    class ListaProductosAdapter : BaseAdapter<Productos>
    {
        private Activity _context;
        private List<Productos> _productos;
        

        public ListaProductosAdapter(Activity contexto,List<Productos> Productos) {

            _context = contexto;
            _productos = Productos;

        }

        public override Productos this[int position] => _productos[position];

        public override int Count => _productos.Count;


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return this[position].IdProducto;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            ListaProductosAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as ListaProductosAdapterViewHolder;

            if (holder == null)
            {
                holder = new ListaProductosAdapterViewHolder();
                var inflater = _context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
                //view = inflater.Inflate(Resource.Layout.item, parent, false);
                //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
                view.Tag = holder;
            }


            //fill in your items
            //holder.Title.Text = "new text here";

            return view;
        }


    }

    class ListaProductosAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}