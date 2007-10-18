// /home/xavier/Projects/SuPOS/SuposAdmin/LoginDialog.cs created with MonoDevelop
// User: xavier at 17:31 25/07/2007
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using Mono.Unix;
using Gtk;
using Glade;

namespace SuposAdmin
{
	public class LoginDialog
	{
		[Widget] public Gtk.Dialog logindialog;
		[Widget] public Gtk.Entry userentry;
		[Widget] public Gtk.Entry passentry;
			
		public LoginDialog()
		{
			Catalog.Init("suposadmin","./locale");
			Glade.XML gxml = new Glade.XML (null, "suposadmin.glade", "logindialog", "suposadmin");
			gxml.Autoconnect (this);
			
		}

	}
}
