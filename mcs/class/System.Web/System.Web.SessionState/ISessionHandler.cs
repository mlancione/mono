//
// System.Web.SessionState.ISessionHandler
//
// Authors:
//	Stefan G�rling, (stefan@gorling.se)
//
// (C) 2003 Stefan G�rling
//
// This interface is simple, but as it's internal it shouldn't be hard to change it if we need to.
//
namespace System.Web.SessionState
{
	internal interface ISessionHandler
	{
		void Dispose ();
		void Init (SessionStateModule module, HttpApplication context, SessionConfig config);
		HttpSessionState UpdateContext (HttpContext context, SessionStateModule module, bool required,
						bool read_only, ref bool isNew);

		void UpdateHandler (HttpContext context, SessionStateModule module);
	}
}

