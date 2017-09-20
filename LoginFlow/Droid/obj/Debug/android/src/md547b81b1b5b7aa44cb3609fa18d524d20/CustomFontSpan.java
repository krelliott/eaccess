package md547b81b1b5b7aa44cb3609fa18d524d20;


public class CustomFontSpan
	extends android.text.style.MetricAffectingSpan
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_updateMeasureState:(Landroid/text/TextPaint;)V:GetUpdateMeasureState_Landroid_text_TextPaint_Handler\n" +
			"n_updateDrawState:(Landroid/text/TextPaint;)V:GetUpdateDrawState_Landroid_text_TextPaint_Handler\n" +
			"";
		mono.android.Runtime.register ("LoginNavigation.Droid.CustomFontSpan, LoginNavigation.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CustomFontSpan.class, __md_methods);
	}


	public CustomFontSpan () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CustomFontSpan.class)
			mono.android.TypeManager.Activate ("LoginNavigation.Droid.CustomFontSpan, LoginNavigation.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CustomFontSpan (java.lang.String p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CustomFontSpan.class)
			mono.android.TypeManager.Activate ("LoginNavigation.Droid.CustomFontSpan, LoginNavigation.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}


	public void updateMeasureState (android.text.TextPaint p0)
	{
		n_updateMeasureState (p0);
	}

	private native void n_updateMeasureState (android.text.TextPaint p0);


	public void updateDrawState (android.text.TextPaint p0)
	{
		n_updateDrawState (p0);
	}

	private native void n_updateDrawState (android.text.TextPaint p0);

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
