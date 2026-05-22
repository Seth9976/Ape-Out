using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000248 RID: 584
	public sealed class Ping
	{
		// Token: 0x060021B2 RID: 8626 RVA: 0x00076DD0 File Offset: 0x00074FD0
		public ~Ping()
		{
			this.DestroyPing();
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00011E0A File Offset: 0x0001000A
		public void DestroyPing()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00011E17 File Offset: 0x00010017
		public static void Internal_Destroy(IntPtr ptr)
		{
			Ping.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00011E24 File Offset: 0x00010024
		public static IntPtr Internal_Create(string address)
		{
			return Ping.Internal_CreateDelegateField(IL2CPP.ManagedStringToIl2Cpp(address));
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00011E36 File Offset: 0x00010036
		public bool isDone
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00011E43 File Offset: 0x00010043
		public bool Internal_IsDone()
		{
			return Ping.Internal_IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00011E55 File Offset: 0x00010055
		public int time
		{
			get
			{
				return Ping.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00076E00 File Offset: 0x00075000
		public string ip
		{
			get
			{
				IntPtr intPtr = Ping.get_ipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x04001BCD RID: 7117
		private static readonly Ping.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Ping.Internal_DestroyDelegate>("UnityEngine.Ping::Internal_Destroy");

		// Token: 0x04001BCE RID: 7118
		private static readonly Ping.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Ping.Internal_CreateDelegate>("UnityEngine.Ping::Internal_Create");

		// Token: 0x04001BCF RID: 7119
		private static readonly Ping.Internal_IsDoneDelegate Internal_IsDoneDelegateField = IL2CPP.ResolveICall<Ping.Internal_IsDoneDelegate>("UnityEngine.Ping::Internal_IsDone");

		// Token: 0x04001BD0 RID: 7120
		private static readonly Ping.get_timeDelegate get_timeDelegateField = IL2CPP.ResolveICall<Ping.get_timeDelegate>("UnityEngine.Ping::get_time");

		// Token: 0x04001BD1 RID: 7121
		private static readonly Ping.get_ipDelegate get_ipDelegateField = IL2CPP.ResolveICall<Ping.get_ipDelegate>("UnityEngine.Ping::get_ip");

		// Token: 0x02000B88 RID: 2952
		// (Invoke) Token: 0x06003570 RID: 13680
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x02000B89 RID: 2953
		// (Invoke) Token: 0x06003572 RID: 13682
		private delegate IntPtr Internal_CreateDelegate(IntPtr address);

		// Token: 0x02000B8A RID: 2954
		// (Invoke) Token: 0x06003574 RID: 13684
		private delegate bool Internal_IsDoneDelegate(IntPtr @this);

		// Token: 0x02000B8B RID: 2955
		// (Invoke) Token: 0x06003576 RID: 13686
		private delegate int get_timeDelegate(IntPtr @this);

		// Token: 0x02000B8C RID: 2956
		// (Invoke) Token: 0x06003578 RID: 13688
		private delegate IntPtr get_ipDelegate(IntPtr @this);
	}
}
