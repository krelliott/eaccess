package md547b81b1b5b7aa44cb3609fa18d524d20;


public class CustomLayoutInflaterFactory
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.view.LayoutInflaterFactory
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;:GetOnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler:Android.Support.V4.View.ILayoutInflaterFactoryInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("LoginNavigation.Droid.CustomLayoutInflaterFactory, LoginNavigation.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CustomLayoutInflaterFactory.class, __md_methods);
	}


	public CustomLayoutInflaterFactory () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CustomLayoutInflaterFactory.class)
			mono.android.TypeManager.Activate ("LoginNavigation.Droid.CustomLayoutInflaterFactory, LoginNavigation.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.View p0, java.lang.String p1, android.content.Context p2, android.util.AttributeSet p3)
	{
		return n_onCreateView (p0, p1, p2, p3);
	}

	private native android.view.View n_onCreateView (android.view.View p0, java.lang.String p1, android.content.Context p2, android.util.AttributeSet p3);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
