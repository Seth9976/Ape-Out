using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C0 RID: 192
	public sealed class X509ChainPolicy : Object
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x00037390 File Offset: 0x00035590
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainPolicy()
		{
			Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr);
			X509ChainPolicy.NativeFieldInfoPtr_apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "apps");
			X509ChainPolicy.NativeFieldInfoPtr_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "cert");
			X509ChainPolicy.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store");
			X509ChainPolicy.NativeFieldInfoPtr_store2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store2");
			X509ChainPolicy.NativeFieldInfoPtr_rflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "rflag");
			X509ChainPolicy.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "mode");
			X509ChainPolicy.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "timeout");
			X509ChainPolicy.NativeFieldInfoPtr_vflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vflags");
			X509ChainPolicy.NativeFieldInfoPtr_vtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vtime");
			X509ChainPolicy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100664763);
			X509ChainPolicy.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100664764);
			X509ChainPolicy.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100664765);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x000374B0 File Offset: 0x000356B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374474, XrefRangeEnd = 374475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainPolicy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000374EC File Offset: 0x000356EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374475, XrefRangeEnd = 374476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainPolicy(X509CertificateCollection store)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00037538 File Offset: 0x00035738
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 374491, RefRangeEnd = 374499, XrefRangeStart = 374476, XrefRangeEnd = 374491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainPolicy.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00006356 File Offset: 0x00004556
		public X509ChainPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0003756C File Offset: 0x0003576C
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0000635F File Offset: 0x0000455F
		public unsafe OidCollection apps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_apps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0003759C File Offset: 0x0003579C
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0000637E File Offset: 0x0000457E
		public unsafe OidCollection cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000375CC File Offset: 0x000357CC
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0000639D File Offset: 0x0000459D
		public unsafe X509CertificateCollection store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000375FC File Offset: 0x000357FC
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000063BC File Offset: 0x000045BC
		public unsafe X509Certificate2Collection store2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_store2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0003762C File Offset: 0x0003582C
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x000063DB File Offset: 0x000045DB
		public unsafe X509RevocationFlag rflag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_rflag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_rflag)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00037654 File Offset: 0x00035854
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x000063F6 File Offset: 0x000045F6
		public unsafe X509RevocationMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0003767C File Offset: 0x0003587C
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00006411 File Offset: 0x00004611
		public unsafe TimeSpan timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000376A4 File Offset: 0x000358A4
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0000642C File Offset: 0x0000462C
		public unsafe X509VerificationFlags vflags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vflags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vflags)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000376CC File Offset: 0x000358CC
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00006447 File Offset: 0x00004647
		public unsafe DateTime vtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainPolicy.NativeFieldInfoPtr_vtime)) = value;
			}
		}

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_apps;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_cert;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_store2;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_rflag;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_vflags;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_vtime;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateCollection_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
	}
}
