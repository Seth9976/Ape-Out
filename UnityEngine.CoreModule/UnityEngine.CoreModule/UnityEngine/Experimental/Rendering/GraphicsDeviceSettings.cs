using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D6 RID: 726
	public static class GraphicsDeviceSettings
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x00012C39 File Offset: 0x00010E39
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x00012C45 File Offset: 0x00010E45
		public static WaitForPresentSyncPoint waitForPresentSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_waitForPresentSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_waitForPresentSyncPointDelegateField(value);
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x00012C52 File Offset: 0x00010E52
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x00012C5E File Offset: 0x00010E5E
		public static GraphicsJobsSyncPoint graphicsJobsSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegateField(value);
			}
		}

		// Token: 0x04001E20 RID: 7712
		private static readonly GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate get_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint");

		// Token: 0x04001E21 RID: 7713
		private static readonly GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate set_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint");

		// Token: 0x04001E22 RID: 7714
		private static readonly GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate get_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint");

		// Token: 0x04001E23 RID: 7715
		private static readonly GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate set_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint");

		// Token: 0x02000C10 RID: 3088
		// (Invoke) Token: 0x06003676 RID: 13942
		private delegate WaitForPresentSyncPoint get_waitForPresentSyncPointDelegate();

		// Token: 0x02000C11 RID: 3089
		// (Invoke) Token: 0x06003678 RID: 13944
		private delegate void set_waitForPresentSyncPointDelegate(WaitForPresentSyncPoint value);

		// Token: 0x02000C12 RID: 3090
		// (Invoke) Token: 0x0600367A RID: 13946
		private delegate GraphicsJobsSyncPoint get_graphicsJobsSyncPointDelegate();

		// Token: 0x02000C13 RID: 3091
		// (Invoke) Token: 0x0600367C RID: 13948
		private delegate void set_graphicsJobsSyncPointDelegate(GraphicsJobsSyncPoint value);
	}
}
