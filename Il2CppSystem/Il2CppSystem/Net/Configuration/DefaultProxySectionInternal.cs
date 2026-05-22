using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200016C RID: 364
	public sealed class DefaultProxySectionInternal : Object
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x00066554 File Offset: 0x00064754
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultProxySectionInternal()
		{
			Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "DefaultProxySectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr);
			DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "webProxy");
			DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "classSyncObject");
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666514);
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666515);
			DefaultProxySectionInternal.NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666516);
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666517);
			DefaultProxySectionInternal.NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666518);
			DefaultProxySectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100666519);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00066624 File Offset: 0x00064824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00066658 File Offset: 0x00064858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetSystemWebProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0006668C File Offset: 0x0006488C
		public unsafe static Object ClassSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388635, XrefRangeEnd = 388642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000666C0 File Offset: 0x000648C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388660, RefRangeEnd = 388661, XrefRangeStart = 388642, XrefRangeEnd = 388660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DefaultProxySectionInternal GetSection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultProxySectionInternal>(intPtr3) : null;
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x000666F4 File Offset: 0x000648F4
		public unsafe IWebProxy WebProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00066734 File Offset: 0x00064934
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultProxySectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000B5FC File Offset: 0x000097FC
		public DefaultProxySectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00066770 File Offset: 0x00064970
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x0000B605 File Offset: 0x00009805
		public unsafe IWebProxy webProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000667A0 File Offset: 0x000649A0
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0000B624 File Offset: 0x00009824
		public unsafe static Object classSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeFieldInfoPtr_webProxy;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeFieldInfoPtr_classSyncObject;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
